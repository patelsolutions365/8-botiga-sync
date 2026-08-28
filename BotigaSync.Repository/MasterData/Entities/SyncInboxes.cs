using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class SyncInboxes
{
    public long SyncInboxId { get; set; }

    public Guid EventId { get; set; }

    public int? StoreId { get; set; }

    public string EventType { get; set; } = null!;

    public DateTime ReceivedAt { get; set; }
}
