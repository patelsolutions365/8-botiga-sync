using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class InvoiceItems
{
    public long InvoiceItemId { get; set; }

    public long InvoiceId { get; set; }

    public int? LineNumber { get; set; }

    public int? ProductTypeId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCode { get; set; }

    public decimal? Qty { get; set; }

    public decimal? CostPer { get; set; }

    public decimal? ActualPricePer { get; set; }

    public decimal? PricePer { get; set; }

    public decimal? PricePerBeforeDiscount { get; set; }

    public decimal Tax1Per { get; set; }

    public decimal Tax2Per { get; set; }

    public decimal Tax3Per { get; set; }

    public decimal Tax4Per { get; set; }

    public decimal Tax5Per { get; set; }

    public decimal Tax6Per { get; set; }

    public decimal? LineDiscount { get; set; }

    public decimal? LineManualDiscount { get; set; }

    public int? StoreId { get; set; }

    public int? TerminalId { get; set; }

    public bool? IsMixNmatch { get; set; }

    public decimal? BonusPoints { get; set; }

    public decimal? MnmRequiredQty { get; set; }

    public decimal? CouponAppliedQty { get; set; }

    public bool? IsReturned { get; set; }

    public long RefInvoiceItemId { get; set; }

    public bool IsAllowReturn { get; set; }

    public bool? IsPrintReceipt { get; set; }

    public int? Tax1Id { get; set; }

    public int? Tax2Id { get; set; }

    public int? Tax3Id { get; set; }

    public int? Tax4Id { get; set; }

    public int? Tax5Id { get; set; }

    public int? Tax6Id { get; set; }

    public bool IsSync { get; set; }

    public string? AppliedDiscount { get; set; }

    public decimal LineManualDiscountPercent { get; set; }

    public decimal? LineTax { get; set; }

    public decimal LineTaxExemptedAmount { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? LineTotalBeforeDiscount { get; set; }

    public decimal? LineTotalCost { get; set; }

    public decimal PricePerWithoutManualDiscount { get; set; }

    public string? ManualDiscountSuffix { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
