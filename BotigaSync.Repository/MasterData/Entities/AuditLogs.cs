using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class AuditLogs
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? Type { get; set; }

    public string? TableName { get; set; }

    public DateTime? DateTime { get; set; }

    public string? OldValues { get; set; }

    public string? NewValues { get; set; }

    public string? AffectedColumns { get; set; }

    public string? PrimaryKey { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
