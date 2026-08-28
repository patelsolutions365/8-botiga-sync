using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class SyncEntityMappings
{
    public long SyncEntityMappingId { get; set; }

    public int StoreId { get; set; }

    public string EntityType { get; set; } = null!;

    public long LocalId { get; set; }

    public long CloudId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime LastSyncedAt { get; set; }

    public bool IsActive { get; set; }
}
