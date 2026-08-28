using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class SyncRecordLogs
{
    public long SyncRecordLogId { get; set; }

    public Guid SyncBatchId { get; set; }

    public long LocalId { get; set; }

    public long? CloudId { get; set; }

    public string EntityType { get; set; } = null!;

    public string Operation { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? ErrorMessage { get; set; }

    public DateTime ProcessedAt { get; set; }

    public virtual SyncBatches SyncBatch { get; set; } = null!;
}
