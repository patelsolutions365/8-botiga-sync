using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ProductCsv
{
    public int Id { get; set; }

    public string? ItemNum { get; set; }

    public string? ItemName { get; set; }

    public int? ItemType { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Price { get; set; }

    public decimal? InStock { get; set; }

    public string? DeptId { get; set; }

    public bool AllowReturns { get; set; }

    public bool CountThisItem { get; set; }

    public bool PrintOnReceipt { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
