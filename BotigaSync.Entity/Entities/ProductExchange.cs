using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ProductExchange
{
    public int ProductExchangeId { get; set; }

    public int OriginalInvoiceNumber { get; set; }

    public long? OriginalInvoiceItemId { get; set; }

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

    public int? ExchangeReasonId { get; set; }

    public string? ExchangeNotes { get; set; }

    public DateTime? ExchangeDate { get; set; }

    public int? StoreId { get; set; }

    public int? TerminalId { get; set; }

    public int? CashierId { get; set; }

    public int? CustomerId { get; set; }

    public string? Status { get; set; }

    public int? DefectiveInventoryTransactionId { get; set; }

    public int? ReplacementInventoryTransactionId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
