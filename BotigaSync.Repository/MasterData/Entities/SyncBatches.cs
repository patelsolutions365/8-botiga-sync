using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class SyncBatches
{
    public Guid SyncBatchId { get; set; }

    public int StoreId { get; set; }

    public string DeviceId { get; set; } = null!;

    public string EntityType { get; set; } = null!;

    public string Operation { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime ReceivedAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public int TotalRecords { get; set; }

    public int SuccessRecords { get; set; }

    public int FailedRecords { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual ICollection<SyncRecordLogs> SyncRecordLogs { get; set; } = new List<SyncRecordLogs>();
}
