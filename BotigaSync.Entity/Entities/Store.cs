using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Store
{
    public int StoreId { get; set; }

    public string? StoreName { get; set; }

    public string? Description { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Website { get; set; }

    public long? DepositType { get; set; }

    public decimal? DepositTypeValue { get; set; }

    public bool? AvgCost { get; set; }

    public bool? TrackIncomingSn { get; set; }

    public bool? PromptforOutOfDate { get; set; }

    public bool? BirthdayPrompt { get; set; }

    public bool? CheckExpiration { get; set; }

    public bool? RequireCustomer { get; set; }

    public bool? RequireDesc { get; set; }

    public string? LevelOneAge { get; set; }

    public string? LevelOnePrompt { get; set; }

    public bool? LevelOnePromptForMilitary { get; set; }

    public bool? LevelOneAllowBorn { get; set; }

    public DateTime? LevelOneAllowBornDesc { get; set; }

    public string? LevelTwoAge { get; set; }

    public string? LevelTwoPrompt { get; set; }

    public bool? LevelTwoPromptForMilitary { get; set; }

    public bool? LevelTwoAllowBorn { get; set; }

    public DateTime? LevelTwoAllowBornDesc { get; set; }

    public bool? IsCheckIdprompt { get; set; }

    public bool? UseMixNmatch { get; set; }

    public bool? CombineLines { get; set; }

    public bool? ExemptTax { get; set; }

    public bool? PromptReason { get; set; }

    public bool? SkuonInvoice { get; set; }

    public long? LineDiscPrompt { get; set; }

    public bool? LineItemDeletion { get; set; }

    public bool? LineItemDisc { get; set; }

    public bool? NoSale { get; set; }

    public decimal? LargePurchaseAmount { get; set; }

    public decimal? MaxCashAlertLevel { get; set; }

    public decimal? MaxCashLockupLevel { get; set; }

    public long? BarCodeNotFound { get; set; }

    public long? DefaultDepartment { get; set; }

    public long? DefaultVendor { get; set; }

    public string? DefaultDescription { get; set; }

    public long? PrintAmtSaved { get; set; }

    public long? PrintAccBal { get; set; }

    public long? PrintCustInfo { get; set; }

    public DateTime EndDateTime { get; set; }

    public bool? SalesTotals { get; set; }

    public bool? DepositBreakdown { get; set; }

    public bool? SalesBreakdown { get; set; }

    public bool? Eodreport { get; set; }

    public bool? FinSummaryReport { get; set; }

    public decimal? DefaultCashDrawerStart { get; set; }

    public bool? ClockoutReceipt { get; set; }

    public bool? BlindRecount { get; set; }

    public decimal? BlindRecountValue { get; set; }

    public long? EmployeeCashDrawers { get; set; }

    public long? SecurityMethod { get; set; }

    public long? ShiftAssignment { get; set; }

    public long? Eod { get; set; }

    public long? UseDecimals { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsHotButton { get; set; }

    public long PoleImageTimeInterval { get; set; }

    public bool ShowLblDesc { get; set; }

    public bool ShowLblPrice { get; set; }

    public bool ShowLblProductCode { get; set; }

    public bool IsSync { get; set; }

    public string? RegistrationCode { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual ICollection<StoreDayEndDate> StoreDayEndDate { get; set; } = new List<StoreDayEndDate>();
}
