using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ProductSku
{
    public int ProductSkuid { get; set; }

    public int? ProductId { get; set; }

    public string? Sku { get; set; }

    public string? Description { get; set; }

    public string? Barcode { get; set; }

    public decimal? InStockQty { get; set; }

    public string? AllowCountQty { get; set; }

    public bool? Status { get; set; }

    public decimal? CostPer { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
