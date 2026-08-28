using System.Text.Json;

namespace BotigaSync.Contracts.Models;

public sealed class SyncEventEnvelope
{
    public Guid EventId { get; set; }
    public string EventType { get; set; } = string.Empty;
    public string AggregateType { get; set; } = string.Empty;
    public Guid AggregateGlobalId { get; set; }
    public int? StoreId { get; set; }
    public int? TerminalId { get; set; }
    public DateTime OccurredAtUtc { get; set; }
    public List<SyncEventRecord> Records { get; set; } = [];
}

public sealed class SyncEventRecord
{
    public string EntityType { get; set; } = string.Empty;
    public string Operation { get; set; } = "Upsert";
    public Guid GlobalId { get; set; }
    public long? LocalId { get; set; }
    public Dictionary<string, JsonElement> Data { get; set; } = [];
    public List<SyncReference> References { get; set; } = [];
}

public sealed class SyncReference
{
    public string ForeignKey { get; set; } = string.Empty;
    public string PrincipalType { get; set; } = string.Empty;
    public Guid? GlobalId { get; set; }
}

public sealed class SyncEventResponse
{
    public bool Success { get; set; }
    public bool Duplicate { get; set; }
    public Guid EventId { get; set; }
    public int AppliedRecords { get; set; }
    public string? ErrorMessage { get; set; }
}
