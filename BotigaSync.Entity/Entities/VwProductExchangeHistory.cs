using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class VwProductExchangeHistory
{
    public int ProductExchangeId { get; set; }

    public int OriginalInvoiceNumber { get; set; }

    public DateTime? ExchangeDate { get; set; }

    public int DefectiveProductId { get; set; }

    public string? DefectiveProductName { get; set; }

    public string? DefectiveProductSku { get; set; }

    public decimal DefectiveQuantity { get; set; }

    public decimal? DefectiveUnitCost { get; set; }

    public int ReplacementProductId { get; set; }

    public string? ReplacementProductName { get; set; }

    public string? ReplacementProductSku { get; set; }

    public decimal ReplacementQuantity { get; set; }

    public decimal? ReplacementUnitCost { get; set; }

    public string? ExchangeReason { get; set; }

    public string? ExchangeNotes { get; set; }

    public string? Status { get; set; }

    public string StatusLabel { get; set; } = null!;

    public string? StoreName { get; set; }

    public string? TerminalName { get; set; }

    public string? CashierName { get; set; }

    public string CustomerName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }
}
