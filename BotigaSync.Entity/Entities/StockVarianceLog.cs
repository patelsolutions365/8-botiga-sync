using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class StockVarianceLog
{
    public int StockVarianceLogId { get; set; }

    public int ProductId { get; set; }

    public int StoreId { get; set; }

    public decimal CurrentInstockQty { get; set; }

    public decimal CalculatedStockBefore { get; set; }

    public decimal Variance { get; set; }

    public decimal AdjustmentQty { get; set; }

    public string? AdjustmentType { get; set; }

    public int? InventoryTransactionId { get; set; }

    public string? Notes { get; set; }

    public DateTime FixedDate { get; set; }

    public int? FixedBy { get; set; }

    public string? FixedByName { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
