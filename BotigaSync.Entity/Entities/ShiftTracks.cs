using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ShiftTracks
{
    public long ShiftTrackId { get; set; }

    public long ShiftId { get; set; }

    public int TerminalId { get; set; }

    public int StoreId { get; set; }

    public DateTime? ShiftStart { get; set; }

    public DateTime? ShifEnd { get; set; }

    public decimal? CashDrawerDeposit { get; set; }

    public decimal? OpeningCash { get; set; }

    public decimal? CashSales { get; set; }

    public decimal? ExpectedCash { get; set; }

    public decimal? ActualCash { get; set; }

    public decimal? ShortAmount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public decimal? AverageTrnsaction { get; set; }

    public decimal? TotalCash { get; set; }

    public decimal? TotalCheck { get; set; }

    public decimal? TotalCreditDebit { get; set; }

    public decimal? TotalEbt { get; set; }

    public decimal? TotalOnAccount { get; set; }

    public decimal? TotalTransaction { get; set; }

    public bool IsSync { get; set; }

    public decimal? NetSalesCoupon { get; set; }

    public decimal? NetSalesDiscount { get; set; }

    public decimal? NetSalesRefund { get; set; }

    public decimal? NetSalesRegular { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
