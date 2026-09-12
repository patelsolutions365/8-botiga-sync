using BotigaSync.Contracts.Models;

namespace BotigaSync.Contracts.Services;

/// <summary>
/// Bulk landing-zone ingestion for the staging-table backfill approach - dumps raw rows
/// straight into stg.[tableName] via SqlBulkCopy, with none of ISyncEventService's
/// per-row resolve/apply logic. Entirely separate code path from live sync: does not
/// touch ISyncEventService, and only ever writes to the stg schema, never dbo.
/// </summary>
public interface IBulkStagingService
{
    Task<BulkStagingResponse> InsertRowsAsync(string tableName, BulkStagingRequest request, CancellationToken cancellationToken);
}
