using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Terminal
{
    public int TerminalId { get; set; }

    public int? StoreId { get; set; }

    public string? TerminalName { get; set; }

    public string? TerminalRole { get; set; }

    public bool? Status { get; set; }

    public long? PoleType { get; set; }

    public long? CashDrawerType { get; set; }

    public string? DefaultCashDrawerPort { get; set; }

    public bool? AmountPrompt { get; set; }

    public bool? StockPrompt { get; set; }

    public bool? CustomerPrompt { get; set; }

    public long? IdleLogOutMin { get; set; }

    public bool? AcceptCustOrders { get; set; }

    public long? ProcessingType { get; set; }

    public long? PaymentProcessorType { get; set; }

    public string? Ipaddress { get; set; }

    public string? ProcessingCompany { get; set; }

    public string? PortNo { get; set; }

    public long? TimeoutSec { get; set; }

    public bool? IsProcessDebitCards { get; set; }

    public string? MerchantNumber { get; set; }

    public string? Processor { get; set; }

    public string? SiteId { get; set; }

    public string? UnlockCode { get; set; }

    public bool? IsHideManualDebit { get; set; }

    public bool? IsHideCheck { get; set; }

    public bool? IsHideEbt { get; set; }

    public bool? IsHideGift { get; set; }

    public bool? QuickCash { get; set; }

    public bool? UserCashAlert { get; set; }

    public decimal? MinCashAlertLevel { get; set; }

    public decimal? MinCashLockupLevel { get; set; }

    public long? ReceiptSize { get; set; }

    public long? PrintInvoices { get; set; }

    public long? ProfLogo { get; set; }

    public long? PaymentTypeCredit { get; set; }

    public long? PaymentTypeDebit { get; set; }

    public long? PaymentTypeEbt { get; set; }

    public long? PaymentTypeGift { get; set; }

    public long? PaymentTypeCash { get; set; }

    public bool? SupressExtraSignCopy { get; set; }

    public bool? PromptEmailPo { get; set; }

    public bool? OnHoldReceipts { get; set; }

    public bool? CompleteReceipts { get; set; }

    public bool? ShortReceipt { get; set; }

    public bool? SpecialPricing { get; set; }

    public bool? ShowInventoryButton { get; set; }

    public bool? StockLevelsOnTs { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public decimal? CurrentCash { get; set; }

    public string? PrintSetupJson { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsShiftStarted { get; set; }

    public bool IsEbtoption { get; set; }

    public string? MacAddress { get; set; }

    public string PaymentProcess { get; set; } = null!;

    public bool IsSync { get; set; }

    public bool? IsUseDecimal { get; set; }

    public string? DailyDetailReportDefaultSelection { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual ICollection<VendorPayout> VendorPayout { get; set; } = new List<VendorPayout>();
}
