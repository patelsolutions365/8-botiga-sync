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

            var references = new List<(object Entity, SyncReference Reference)>();
            foreach (var record in envelope.Records)
            {
                var type = ResolveOutboundRecordType(record.EntityType);
                var referenceColumns = record.References
                    .Select(reference => reference.ForeignKey)
                    .ToHashSet(StringComparer.OrdinalIgnoreCase);
                var entity = await FindAsync(type.ClrType, record.GlobalId, cancellationToken);
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

                    // Most synced entities have a database-generated primary key on
                    // this side (cloud assigns its own identity value; GlobalId is
                    // what correlates the row back to the originating store, not the
                    // PK). A few (e.g. Employee - see its EmployeeId) are
                    // deliberately NOT database-generated, so the same key matches
                    // the originating store's own value. For those, the PK has to be
                    // copied from record.LocalId explicitly on insert - otherwise
                    // it's skipped below (PK properties are never taken from Data)
                    // and every new row would land at the CLR default (0), colliding
                    // with the next one. Employee's key is composite (StoreId,
                    // EmployeeId) - EmployeeId alone is only unique within one store,
                    // so StoreId (set above) is part of the key too; only the OTHER
                    // non-generated key property (EmployeeId) needs copying from
                    // LocalId here.
                    var newEntityPrimaryKey = type.FindPrimaryKey();
                    var pkProperty = newEntityPrimaryKey?.Properties.FirstOrDefault(p =>
                        p.ValueGenerated == ValueGenerated.Never
                        && !p.Name.Equals("StoreId", StringComparison.OrdinalIgnoreCase));
                    if (pkProperty != null && record.LocalId.HasValue)
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
                references.AddRange(record.References.Where(x => x.GlobalId.HasValue).Select(x => (entity, x)));
                }
                await master.SaveChangesAsync(cancellationToken);
                foreach (var (entity, reference) in references)
                {
                    var principalType = ResolveReferenceType(reference.PrincipalType);
                    var principal = await FindAsync(principalType.ClrType, reference.GlobalId!.Value, cancellationToken) ?? throw new InvalidOperationException($"Missing {reference.PrincipalType} for {reference.ForeignKey}.");
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

    private static void Set(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entry, string name, object? value) { if (entry.Metadata.FindProperty(name) == null) throw new InvalidOperationException($"Unknown property {name}."); entry.Property(name).CurrentValue = value; }
    private static void SetIfExists(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entry, string name, object? value) { if (value != null && entry.Metadata.FindProperty(name) != null) entry.Property(name).CurrentValue = value; }
}
