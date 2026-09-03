using System.Text.Json;
using BotigaSync.Contracts.Models;
using BotigaSync.Contracts.Services;
using BotigaSync.Entity.Entities;
using BotigaSync.Repository.MasterData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BotigaSync.RepositoryService.Services;

/// <summary>
/// Reads dbo.SyncOutboxes, a pre-existing table this service does not own the
/// schema of; something outside this codebase already writes rows into it.
/// </summary>
public sealed class OutboxEventService(
    MasterBotigaDataContext master,
    ILogger<OutboxEventService> logger) : IOutboxEventService
{
    public async Task<OutboxEventResponse?> PullNextAsync(int storeId, CancellationToken cancellationToken)
    {
        return await master.Database.CreateExecutionStrategy().ExecuteAsync(async () =>
        {
            await using var transaction = await master.Database.BeginTransactionAsync(cancellationToken);

            // Lowest SyncOutboxId not yet Processed is both "next in order"
            // and "currently in flight" - a store is only ever handed one event.
            var candidateId = await master.SyncOutboxes
                .Where(x => x.StoreId == storeId && x.Status != SyncOutboxStatus.Processed)
                .OrderBy(x => x.SyncOutboxId)
                .Select(x => (long?)x.SyncOutboxId)
                .FirstOrDefaultAsync(cancellationToken);

            if (candidateId == null)
            {
                await transaction.CommitAsync(cancellationToken);
                return null;
            }

            // Atomic claim: only flips Pending -> Delivered while it is still
            // Pending, so two overlapping pulls for the same store can't both
            // "win" a fresh event. If it's already Delivered (an earlier pull
            // that was never acked), this is a no-op redelivery of the same event.
            await master.SyncOutboxes
                .Where(x => x.SyncOutboxId == candidateId && x.Status == SyncOutboxStatus.Pending)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(x => x.Status, SyncOutboxStatus.Delivered)
                    .SetProperty(x => x.RetryCount, x => x.RetryCount + 1),
                    cancellationToken);

            var claimed = await master.SyncOutboxes.AsNoTracking()
                .SingleAsync(x => x.SyncOutboxId == candidateId, cancellationToken);

            await transaction.CommitAsync(cancellationToken);

            logger.LogInformation(
                "Delivered sync outbox event {EventId} (seq {SequenceNumber}) to store {StoreId}, attempt {RetryCount}.",
                claimed.EventId, claimed.SyncOutboxId, storeId, claimed.RetryCount);

            return ToResponse(claimed);
        });
    }

    public async Task<AckEventResponse> AcknowledgeAsync(AckEventRequest request, CancellationToken cancellationToken)
    {
        return await master.Database.CreateExecutionStrategy().ExecuteAsync(async () =>
        {
            await using var transaction = await master.Database.BeginTransactionAsync(cancellationToken);

            var entity = await master.SyncOutboxes.SingleOrDefaultAsync(
                x => x.StoreId == request.StoreId && x.EventId == request.EventId, cancellationToken);

            if (entity == null)
            {
                await transaction.CommitAsync(cancellationToken);
                return new AckEventResponse { Success = false, EventId = request.EventId, ErrorMessage = "Event not found for store." };
            }

            if (entity.Status == SyncOutboxStatus.Processed)
            {
                await transaction.CommitAsync(cancellationToken);
                return new AckEventResponse { Success = true, AlreadyAcknowledged = true, EventId = request.EventId };
            }

            // Order guard: refuse to ack out of turn so the cursor can never skip ahead.
            var hasEarlierOutstanding = await master.SyncOutboxes.AnyAsync(x =>
                x.StoreId == request.StoreId &&
                x.Status != SyncOutboxStatus.Processed &&
                x.SyncOutboxId < entity.SyncOutboxId,
                cancellationToken);

            if (hasEarlierOutstanding)
            {
                await transaction.CommitAsync(cancellationToken);
                return new AckEventResponse { Success = false, EventId = request.EventId, ErrorMessage = "An earlier event for this store is still outstanding." };
            }

            entity.Status = SyncOutboxStatus.Processed;
            entity.ProcessedAt = DateTime.UtcNow;
            await master.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);

            logger.LogInformation("Acknowledged sync outbox event {EventId} for store {StoreId}.", request.EventId, request.StoreId);

            return new AckEventResponse { Success = true, EventId = request.EventId };
        });
    }

    private static OutboxEventResponse ToResponse(SyncOutbox entity) => new()
    {
        EventId = entity.EventId,
        SequenceNumber = entity.SyncOutboxId,
        EventType = entity.EventType,
        AggregateType = entity.AggregateType,
        AggregateGlobalId = entity.AggregateGlobalId,
        AggregateLocalId = entity.AggregateLocalId,
        StoreId = entity.StoreId,
        TerminalId = entity.TerminalId,
        Payload = JsonDocument.Parse(entity.PayloadJson).RootElement.Clone(),
        CreatedAt = entity.CreatedAt,
        RetryCount = entity.RetryCount
    };
}
