using System.ComponentModel.DataAnnotations;

namespace BotigaSync.Entity.Entities;

/// <summary>
/// Maps the pre-existing dbo.SyncOutboxes table (not managed by EF Migrations
/// in this project - schema changes go through the DBA, not code-first).
/// Cloud-to-local events land here from outside this codebase; ordering for
/// a store's pull is the insertion order of SyncOutboxId.
/// </summary>
public class SyncOutbox
{
    [Key]
    public long SyncOutboxId { get; set; }
    public Guid EventId { get; set; }
    public string EventType { get; set; } = string.Empty;
    public string AggregateType { get; set; } = string.Empty;
    public Guid AggregateGlobalId { get; set; }
    public long? AggregateLocalId { get; set; }
    public int? StoreId { get; set; }
    public int? TerminalId { get; set; }
    public string Status { get; set; } = SyncOutboxStatus.Pending;
    public int RetryCount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? NextRetryAt { get; set; }
    public DateTime? ProcessedAt { get; set; }
    public string? LastError { get; set; }
    public string PayloadJson { get; set; } = string.Empty;
}

public static class SyncOutboxStatus
{
    public const string Pending = "Pending";
    public const string Delivered = "Delivered";
    public const string Processed = "Processed";
    public const string Failed = "Failed";
}
