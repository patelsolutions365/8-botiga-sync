using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class OrderDetails
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public string? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }

    public string? DiscountType { get; set; }

    public decimal? DiscountAmount { get; set; }

    public string? Description { get; set; }

    public string? TaxAmount { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
