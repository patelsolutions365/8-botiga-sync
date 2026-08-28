using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ProductPriceHistory
{
    public long Id { get; set; }

    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public decimal? OldCost { get; set; }

    public decimal? NewCost { get; set; }

    public bool CostChanged { get; set; }

    public decimal? OldPrice { get; set; }

    public decimal? NewPrice { get; set; }

    public bool PriceChanged { get; set; }

    public string ChangeType { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? Notes { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
