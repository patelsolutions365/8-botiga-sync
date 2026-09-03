using BotigaSync.Contracts.Models;

namespace BotigaSync.Contracts.Services;

public interface ISyncEventService
{
    Task<SyncEventResponse> ProcessAsync(SyncEventEnvelope envelope, CancellationToken cancellationToken);
}

public interface ISyncEventValidator
{
    bool CanValidate(string eventType);
    void Validate(SyncEventEnvelope envelope);
}

/// <summary>
/// Cloud-to-local delivery: a store pulls at most one event at a time and
/// must acknowledge it before the next one is served, so order is never
/// skipped and nothing is handed out twice while unacknowledged.
/// </summary>
public interface IOutboxEventService
{
    Task<OutboxEventResponse?> PullNextAsync(int storeId, CancellationToken cancellationToken);
    Task<AckEventResponse> AcknowledgeAsync(AckEventRequest request, CancellationToken cancellationToken);
}
