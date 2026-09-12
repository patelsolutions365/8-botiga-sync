using System.Reflection;
using System.Text.Json;
using BotigaSync.Contracts.Models;
using BotigaSync.Contracts.Services;
using BotigaSync.Entity.Entities;
using BotigaSync.Repository.MasterData;
using BotigaSync.RepositoryService.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace BotigaSync.RepositoryService.Services;

public sealed class SyncEventService(
    MasterBotigaDataContext master,
    IEnumerable<ISyncEventValidator> validators,
    ILogger<SyncEventService> logger) : ISyncEventService
{
    public async Task<SyncEventResponse> ProcessAsync(SyncEventEnvelope envelope, CancellationToken cancellationToken)
    {
        if (envelope.EventId == Guid.Empty || envelope.StoreId <= 0 || envelope.Records.Count == 0)
            throw new ArgumentException("EventId, StoreId, and Records are required.");

        foreach (var validator in validators.Where(x => x.CanValidate(envelope.EventType)))
        {
            validator.Validate(envelope);
        }

        logger.LogInformation(
            "Applying sync event {EventId} ({EventType}) for store {StoreId} with {RecordCount} records.",
            envelope.EventId,
            envelope.EventType,
            envelope.StoreId,
            envelope.Records.Count);

        SyncEventResponse response;
        try
        {
            response = await master.Database.CreateExecutionStrategy().ExecuteAsync(async () =>
            {
                await using var transaction = await master.Database.BeginTransactionAsync(cancellationToken);
                if (await master.SyncInboxes.AnyAsync(x => x.EventId == envelope.EventId, cancellationToken))
                {
                    return new SyncEventResponse { Success = true, Duplicate = true, EventId = envelope.EventId };
                }

            // Same batching idea as the reference-resolution pass further down, applied to the
            // "does this record already exist" check instead - resolve every record's type
            // first, then fetch existing rows with one "WHERE GlobalId IN (...)" query per
            // entity type in the envelope, instead of one query per record. Doesn't change what
            // gets found - a record still can't see an earlier record in the same envelope that
            // was Added but not yet SaveChanges'd, exactly as before (a plain query against the
            // DB was never going to return an unsaved Added entity either way) - just fewer
            // round-trips to get there.
            var recordTypes = envelope.Records
                .Select(record => (Record: record, Type: ResolveOutboundRecordType(record.EntityType)))
                .ToList();
            var existingByType = new Dictionary<Type, Dictionary<Guid, object>>();
            foreach (var group in recordTypes.GroupBy(r => r.Type.ClrType))
            {
                var ids = group.Select(r => r.Record.GlobalId).Distinct().ToList();
                existingByType[group.Key] = await FindManyAsync(group.Key, ids, cancellationToken);
            }

            var references = new List<(object Entity, SyncReference Reference)>();
            foreach (var (record, type) in recordTypes)
            {
                var referenceColumns = record.References
                    .Select(reference => reference.ForeignKey)
                    .ToHashSet(StringComparer.OrdinalIgnoreCase);
                var entity = existingByType.TryGetValue(type.ClrType, out var existingOfType)
                    && existingOfType.TryGetValue(record.GlobalId, out var found)
                        ? found
                        : null;
                var isNew = entity == null;

                if (record.Operation.Equals("Deleted", StringComparison.OrdinalIgnoreCase))
                {
                    if (entity != null) master.Remove(entity);
                    continue;
                }
                entity ??= Activator.CreateInstance(type.ClrType) ?? throw new InvalidOperationException($"Cannot create {record.EntityType}.");

                // GlobalId/StoreId/LocalId (and the PK-copy below) only ever need
                // setting once, at creation - they identify where a row came from,
                // and that never changes for the life of a synced row. Re-setting
                // them on every update is harmless for entities where these are
                // plain columns, but for Employee, StoreId is HALF OF THE PRIMARY
                // KEY - EF refuses to touch a key property on an already-tracked
                // entity at all, even to reassign the same value ("is part of a key
                // and so cannot be modified"), so this must be skipped entirely on
                // update, not just for inserts.
                // Most synced entities have a database-generated primary key on this side
                // (cloud assigns its own identity value; GlobalId is what correlates the row
                // back to the originating store, not the PK). A few (e.g. Employee's
                // EmployeeId, GroupCategory's CategoryId) are deliberately NOT
                // database-generated, so the same key matches the originating store's own
                // value (or, for GroupCategory, matches its principal's key directly - see
                // pkReference below). Computed here (not just inside isNew) because it's also
                // needed to exclude this column from the later reference-resolution pass -
                // once a key property has been set once (new row) or read from the database
                // (existing row), EF refuses to touch it again at all, even to reassign the
                // same value ("is part of a key and so cannot be modified") - true on both
                // insert and update, not just insert.
                var newEntityPrimaryKey = type.FindPrimaryKey();
                var pkProperty = newEntityPrimaryKey?.Properties.FirstOrDefault(p =>
                    p.ValueGenerated == ValueGenerated.Never
                    && !p.Name.Equals("StoreId", StringComparison.OrdinalIgnoreCase));

                // A column can be BOTH a table's own primary key AND a reference to another
                // table - e.g. GroupCategory has no independent id of its own; its PK,
                // CategoryId, IS the reference to Category (at most one GroupCategory row per
                // Category). Found 2026-09-11: crashed every first-time GroupCategory insert
                // with "CategoryId is part of a key and so cannot be modified", because the
                // key was being set from the raw local id below, then the normal reference
                // pass further down tried to correct it to the resolved cloud id afterward -
                // too late, the key was already locked in from the first Add().
                //
                // Deliberately checked across ALL of this entity's key properties, not just
                // pkProperty above - pkProperty is scoped to ValueGenerated.Never (the Employee
                // case), but GroupCategory.CategoryId has no explicit ValueGeneratedNever() in
                // the model (just HasKey(e => e.CategoryId)), so EF's default convention treats
                // it as ValueGenerated.OnAdd even though the real column isn't an identity
                // column - which made pkProperty null and this whole fix a no-op the first time
                // it was written. The "can't modify a key property on a tracked entity" error
                // applies to any key column regardless of its ValueGenerated setting, so this
                // check has to too.
                // Excludes a reference whose PrincipalType is this same entity type - the naming
                // convention that generates references also trivially matches an entity's own PK
                // against its own class (InvoiceItem.InvoiceItemId -> InvoiceItem), for nearly
                // every table. That's always been harmless as a no-op further down (the row
                // resolves to itself, so nothing actually changes), but this block runs BEFORE
                // Add()/SaveChanges - resolving it here would look up a row that doesn't exist
                // yet and throw "Missing X for Y" on the very first insert of practically every
                // synced table. Only a reference to a genuinely DIFFERENT entity type (like
                // GroupCategory -> Category) belongs in this branch. Kept as a defense here
                // rather than relying solely on the source no longer generating the self-match,
                // since this path shouldn't depend on that staying true everywhere it's called
                // from.
                var pkReferenceProperty = newEntityPrimaryKey?.Properties.FirstOrDefault(p =>
                    record.References.Any(r => r.GlobalId.HasValue
                        && r.ForeignKey.Equals(p.Name, StringComparison.OrdinalIgnoreCase)
                        && !r.PrincipalType.Equals(type.ClrType.Name, StringComparison.OrdinalIgnoreCase)));
                var pkReference = pkReferenceProperty != null
                    ? record.References.First(r => r.GlobalId.HasValue
                        && r.ForeignKey.Equals(pkReferenceProperty.Name, StringComparison.OrdinalIgnoreCase)
                        && !r.PrincipalType.Equals(type.ClrType.Name, StringComparison.OrdinalIgnoreCase))
                    : null;

                if (isNew)
                {
                    // Set before Add() - for entities whose primary key is entirely
                    // client-generated (every key property is ValueGenerated.Never,
                    // e.g. Employee's composite StoreId+EmployeeId), EF needs the
                    // full key populated the instant tracking begins. Setting it via
                    // Entry(...).Property(...) first is safe - the entry stays
                    // Detached (no key validation) until Add() actually transitions
                    // its state.
                    Set(master.Entry(entity), "GlobalId", record.GlobalId);
                    SetIfExists(master.Entry(entity), "StoreId", envelope.StoreId);
                    SetIfExists(master.Entry(entity), "LocalId", record.LocalId);

                    if (pkReferenceProperty != null && pkReference != null)
                    {
                        // The PK doubles as a reference - resolve it from the reference's
                        // GlobalId now (the only chance to get it right; see comment above),
                        // not from the raw local id like a normal client-generated key below.
                        var pkPrincipalType = ResolveReferenceType(pkReference.PrincipalType);
                        var pkPrincipal = await FindAsync(pkPrincipalType.ClrType, pkReference.GlobalId!.Value, cancellationToken)
                            ?? throw new InvalidOperationException($"Missing {pkReference.PrincipalType} for {pkReference.ForeignKey}.");
                        var pkPrincipalKey = pkPrincipalType.FindPrimaryKey();
                        var pkPrincipalKeyProperty = pkPrincipalKey?.Properties.Count == 1
                            ? pkPrincipalKey.Properties[0]
                            : pkPrincipalKey?.Properties.FirstOrDefault(p => p.Name.Equals(pkReference.ForeignKey, StringComparison.OrdinalIgnoreCase));
                        if (pkPrincipalKeyProperty == null) throw new InvalidOperationException($"Unsupported reference {pkReference.ForeignKey}.");
                        Set(master.Entry(entity), pkReferenceProperty.Name, master.Entry(pkPrincipal).Property(pkPrincipalKeyProperty.Name).CurrentValue);
                    }
                    else if (pkProperty != null && record.LocalId.HasValue)
                    {
                        var pkValue = Convert.ChangeType(record.LocalId.Value, Nullable.GetUnderlyingType(pkProperty.ClrType) ?? pkProperty.ClrType);
                        Set(master.Entry(entity), pkProperty.Name, pkValue);
                    }
                }

                if (master.Entry(entity).State == EntityState.Detached) master.Add(entity);

                foreach (var item in record.Data)
                {
                    var property = FindProperty(type, item.Key);
                    if (property == null || property.IsPrimaryKey() || item.Key is "GlobalId" or "LocalId" or "IsSync" || referenceColumns.Contains(item.Key)) continue;
                    Set(master.Entry(entity), property.Name, JsonSerializer.Deserialize(item.Value.GetRawText(), property.ClrType));
                }
                // pkReference was already resolved above (new row) or never needs to change
                // (existing row - it's this row's own identity) - excluded here either way,
                // since touching a key property again in the pass below throws regardless.
                references.AddRange(record.References.Where(x =>
                    x.GlobalId.HasValue && (pkReference == null || x.ForeignKey != pkReference.ForeignKey)).Select(x => (entity, x)));
                }
                await master.SaveChangesAsync(cancellationToken);

                // Resolve every reference's principal with one "WHERE GlobalId IN (...)" query
                // per principal type, instead of one query per reference. A table like
                // InvoiceItem has 2-3 references per row (InvoiceId, ProductId,
                // RefInvoiceItemId) - at full table size that was 600,000+ individual
                // sequential SELECTs for one push. Grouped by principal type first so a batch
                // referencing, say, 150 different Products and 80 different Vendors costs 2
                // queries total, not 230+.
                var referencesWithType = references
                    .Select(r => (r.Entity, r.Reference, PrincipalType: ResolveReferenceType(r.Reference.PrincipalType)))
                    .ToList();
                var principalsByType = new Dictionary<Type, Dictionary<Guid, object>>();
                foreach (var group in referencesWithType.GroupBy(r => r.PrincipalType))
                {
                    var neededIds = group.Select(r => r.Reference.GlobalId!.Value).Distinct().ToList();
                    principalsByType[group.Key.ClrType] = await FindManyAsync(group.Key.ClrType, neededIds, cancellationToken);
                }

                foreach (var (entity, reference, principalType) in referencesWithType)
                {
                    if (!principalsByType.TryGetValue(principalType.ClrType, out var byGlobalId)
                        || !byGlobalId.TryGetValue(reference.GlobalId!.Value, out var principal))
                    {
                        throw new InvalidOperationException($"Missing {reference.PrincipalType} for {reference.ForeignKey}.");
                    }
                    var key = principalType.FindPrimaryKey();
                    // Normally the principal has a single-column key, so there's only
                    // one value to copy onto the child's FK column. Employee is the
                    // one exception (composite StoreId+EmployeeId) - for it, pick the
                    // specific key column matching the FK's name (EmployeeId) rather
                    // than the whole key; the child's StoreId is already set
                    // separately (from envelope.StoreId), so only the EmployeeId half
                    // needs copying here.
                    var keyProperty = key?.Properties.Count == 1
                        ? key.Properties[0]
                        : key?.Properties.FirstOrDefault(p => p.Name.Equals(reference.ForeignKey, StringComparison.OrdinalIgnoreCase));
                    if (keyProperty == null || reference.ForeignKey.Contains(',')) throw new InvalidOperationException($"Unsupported reference {reference.ForeignKey}.");
                    Set(master.Entry(entity), reference.ForeignKey, master.Entry(principal).Property(keyProperty.Name).CurrentValue);
                }
                await master.SaveChangesAsync(cancellationToken);
                master.SyncInboxes.Add(new SyncInbox
                {
                    EventId = envelope.EventId,
                    StoreId = envelope.StoreId,
                    EventType = envelope.EventType
                });
                await master.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                return new SyncEventResponse
                {
                    Success = true,
                    EventId = envelope.EventId,
                    AppliedRecords = envelope.Records.Count
                };
            });
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception exception)
        {
            logger.LogError(
                exception,
                "Failed to apply sync event {EventId} ({EventType}) for store {StoreId}.",
                envelope.EventId,
                envelope.EventType,
                envelope.StoreId);

            response = new SyncEventResponse
            {
                Success = false,
                EventId = envelope.EventId,
                ErrorMessage = exception.GetBaseException().Message
            };
        }
        logger.LogInformation("Completed sync event {EventId}; duplicate: {Duplicate}.", envelope.EventId, response.Duplicate);
        return response;
    }

    private IEntityType ResolveOutboundRecordType(string name)
    {
        if (!LocalToCloudEntityRegistry.TryResolve(name, out var registeredEntity))
        {
            throw new InvalidOperationException($"Entity '{name}' is not approved for Local-to-Cloud sync.");
        }

        return FindMasterEntityType(registeredEntity.LocalEntityType, name);
    }

    private IEntityType ResolveReferenceType(string name)
    {
        if (LocalToCloudEntityRegistry.TryResolve(name, out var registeredEntity))
        {
            return FindMasterEntityType(registeredEntity.LocalEntityType, name);
        }

        var candidates = new[]
        {
            name,
            $"{name}s",
            name.EndsWith("y", StringComparison.OrdinalIgnoreCase) ? $"{name[..^1]}ies" : string.Empty
        };

        var type = master.Model.GetEntityTypes().SingleOrDefault(entity =>
            candidates.Any(candidate => entity.ClrType.Name.Equals(candidate, StringComparison.OrdinalIgnoreCase)));

        if (type == null || type.FindProperty("GlobalId") == null || name.StartsWith("AspNet", StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException($"Unsupported sync reference entity '{name}'.");
        }

        return type;
    }

    private IEntityType FindMasterEntityType(string localEntityType, string sourceEntityType)
    {
        var candidates = new[]
        {
            localEntityType,$"{localEntityType}s", localEntityType.EndsWith("y", StringComparison.OrdinalIgnoreCase) ? $"{localEntityType[..^1]}ies" : string.Empty
        };

        var type = master.Model.GetEntityTypes().SingleOrDefault(entity => candidates.Any(candidate => entity.ClrType.Name.Equals(candidate, StringComparison.OrdinalIgnoreCase)));

        if (type == null || type.FindProperty("GlobalId") == null ||
            sourceEntityType.StartsWith("AspNet", StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException($"Unsupported sync entity '{sourceEntityType}'.");
        }

        return type;
    }
    private async Task<object?> FindAsync(Type type, Guid globalId, CancellationToken ct)
    {
        var method = GetType().GetMethod(nameof(FindGenericAsync), BindingFlags.Instance | BindingFlags.NonPublic)!.MakeGenericMethod(type);
        return await (Task<object?>)method.Invoke(this, [globalId, ct])!;
    }

    private async Task<object?> FindGenericAsync<TEntity>(Guid globalId, CancellationToken ct) where TEntity : class => await master.Set<TEntity>().FirstOrDefaultAsync(x => EF.Property<Guid>(x, "GlobalId") == globalId, ct);

    // Batched counterpart to FindAsync above - one "WHERE GlobalId IN (...)" query for a whole
    // set of ids instead of one query per id. Used for reference resolution, where a single
    // batch push can need many rows of the same principal type at once.
    private async Task<Dictionary<Guid, object>> FindManyAsync(Type type, List<Guid> globalIds, CancellationToken ct)
    {
        var method = GetType().GetMethod(nameof(FindManyGenericAsync), BindingFlags.Instance | BindingFlags.NonPublic)!.MakeGenericMethod(type);
        return await (Task<Dictionary<Guid, object>>)method.Invoke(this, [globalIds, ct])!;
    }

    private async Task<Dictionary<Guid, object>> FindManyGenericAsync<TEntity>(List<Guid> globalIds, CancellationToken ct) where TEntity : class
    {
        var rows = await master.Set<TEntity>().Where(x => globalIds.Contains(EF.Property<Guid>(x, "GlobalId"))).ToListAsync(ct);
        return rows.ToDictionary(x => (Guid)master.Entry(x).Property("GlobalId").CurrentValue!, x => (object)x);
    }

    private static IProperty? FindProperty(IEntityType type, string name)
    {
        var property = type.FindProperty(name);
        if (property != null)
        {
            return property;
        }

        return type.GetProperties().SingleOrDefault(candidate =>
            candidate.Name.Equals(name, StringComparison.OrdinalIgnoreCase) ||
            candidate.GetColumnName().Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    // Case-insensitive, via the FindProperty helper above - local and the relay maintain their
    // entity models independently (Code-First here, Database-First there), so the same physical
    // column can end up spelled differently on each side (e.g. local's MixNMatchProduct.MixNMatchId
    // vs the relay's MixNmatchProducts.MixNmatchId) - confirmed 2026-09-11 when this caused every
    // MixNMatchProduct row to fail with "Unknown property MixNMatchId".
    private static void Set(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entry, string name, object? value)
    {
        var property = FindProperty(entry.Metadata, name) ?? throw new InvalidOperationException($"Unknown property {name}.");
        entry.Property(property.Name).CurrentValue = value;
    }

    private static void SetIfExists(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entry, string name, object? value)
    {
        var property = FindProperty(entry.Metadata, name);
        if (value != null && property != null)
        {
            entry.Property(property.Name).CurrentValue = value;
        }
    }
}
