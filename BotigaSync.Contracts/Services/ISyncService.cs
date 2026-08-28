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
