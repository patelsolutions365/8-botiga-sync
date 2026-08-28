using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class InvoiceTotals
{
    public long InvoiceNumber { get; set; }

    public int? StoreId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? Discount { get; set; }

    public decimal? ManualDiscount { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? TotalTax1 { get; set; }

    public decimal? TotalTax2 { get; set; }

    public decimal? TotalTax3 { get; set; }

    public decimal? TotalTax4 { get; set; }

    public decimal? TotalTax5 { get; set; }

    public decimal? TotalTax6 { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? AmtTendered { get; set; }

    public decimal? AmtChange { get; set; }

    public bool? ShipToUsed { get; set; }

    public bool? InvoiceNotesUsed { get; set; }

    public string? Status { get; set; }

    public int? CashierId { get; set; }

    public int? TerminalId { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? AcctBalanceDue { get; set; }

    public DateTime? AcctFullyPaidDate { get; set; }

    public decimal? Taxed1 { get; set; }

    public decimal? TaxedSales { get; set; }

    public decimal? NonTaxedSales { get; set; }

    public decimal? TaxExemptSales { get; set; }

    public decimal? CaAmount { get; set; }

    public decimal? ChAmount { get; set; }

    public decimal? CcAmount { get; set; }

    public decimal? OaAmount { get; set; }

    public decimal? GcAmount { get; set; }

    public decimal? FsAmount { get; set; }

    public decimal? DcAmount { get; set; }

    public decimal? MpAmount { get; set; }

    public decimal? MpDiscountAmount { get; set; }

    public decimal? LayAmount { get; set; }

    public decimal? TipAmount { get; set; }

    public decimal? OldBalance { get; set; }

    public int? NumPeopleParty { get; set; }

    public decimal? AcctBalanceBefore { get; set; }

    public string? ZipCode { get; set; }

    public string? InvType { get; set; }

    public decimal? AmtFschange { get; set; }

    public decimal? AmtFsamtTend { get; set; }

    public decimal? OaamountLimited { get; set; }

    public int CostCenterIndex { get; set; }

    public decimal? AmtCaSec { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? OrigOnHoldId { get; set; }

    public decimal? TotalFixedTax { get; set; }

    public decimal? TotalGcSold { get; set; }

    public bool? IsLayaway { get; set; }

    public decimal? AmtDeposit { get; set; }

    public decimal? TotalGcFree { get; set; }

    public decimal? TotalLiability { get; set; }

    public bool? MacromatixSyncStatus { get; set; }

    public long? ReferenceInvoiceNumber { get; set; }

    public string? CourseOrderingProgress { get; set; }

    public string? OnlineOrderId { get; set; }

    public string? OrderSource { get; set; }

    public decimal? OpAmount { get; set; }

    public decimal? AmtCaSecTendered { get; set; }

    public int? TaxCategory { get; set; }

    public decimal? DonationAmount { get; set; }

    public decimal? TotalUndiscountedSale { get; set; }

    public decimal? EbtcashbenefitAmount { get; set; }

    public int? SplitCheckType { get; set; }

    public int? CustAge { get; set; }

    public decimal? CpAmount { get; set; }

    public decimal? GiftCardPrice { get; set; }

    public decimal? GrandTotalWithGc { get; set; }

    public decimal? GiftCardDiscount { get; set; }

    public decimal? TotalPriceWithGiftCard { get; set; }

    public bool IsSync { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsAgeVerified { get; set; }

    public bool IsCheckId1 { get; set; }

    public bool IsCheckId2 { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual ICollection<RewardPointsTransactions> RewardPointsTransactions { get; set; } = new List<RewardPointsTransactions>();
}
