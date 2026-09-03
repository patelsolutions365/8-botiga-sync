using System.Text.Json;

namespace BotigaSync.Contracts.Models;

public sealed class OutboxEventResponse
{
    public Guid EventId { get; set; }
    public long SequenceNumber { get; set; }
    public string EventType { get; set; } = string.Empty;
    public string AggregateType { get; set; } = string.Empty;
    public Guid AggregateGlobalId { get; set; }
    public long? AggregateLocalId { get; set; }
    public int? StoreId { get; set; }
    public int? TerminalId { get; set; }
    public JsonElement Payload { get; set; }
    public DateTime CreatedAt { get; set; }
    public int RetryCount { get; set; }
}

public sealed class AckEventRequest
{
    public int StoreId { get; set; }
    public Guid EventId { get; set; }
}

public sealed class AckEventResponse
{
    public bool Success { get; set; }
    public bool AlreadyAcknowledged { get; set; }
    public Guid EventId { get; set; }
    public string? ErrorMessage { get; set; }
}
