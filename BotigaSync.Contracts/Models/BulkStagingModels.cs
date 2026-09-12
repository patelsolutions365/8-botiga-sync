using System.Text.Json;

namespace BotigaSync.Contracts.Models;

/// <summary>
/// One table's worth of raw rows, exactly as they read from the local store database -
/// same column names, same raw local PK/FK values, no resolution of any kind. Meant for
/// the staging-table backfill approach: dump first, fix references later with one big
/// SQL statement per table instead of resolving row by row.
/// </summary>
public sealed class BulkStagingRequest
{
    public int StoreId { get; set; }

    // One BatchId per call - lets a retried/duplicate request be recognized and skipped
    // instead of double-inserting the same rows, the same idea as SyncEventEnvelope.EventId
    // dedup on the existing sync path. Generate a fresh one per logical batch, not per row.
    public Guid BatchId { get; set; }
    public List<Dictionary<string, JsonElement>> Rows { get; set; } = new();
}

public sealed class BulkStagingResponse
{
    public bool Success { get; set; }
    public bool Duplicate { get; set; }
    public int RowsInserted { get; set; }
    public string? ErrorMessage { get; set; }
}
