using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class InventoryHistory
{
    public int InentoryId { get; set; }

    public int? ProductId { get; set; }

    public int? StoreId { get; set; }

    public string? UnitsInStock { get; set; }

    public int? PolineItemId { get; set; }

    public string? UnitsOrdered { get; set; }

    public DateTime? OrderDate { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
