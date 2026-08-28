using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class Shifts
{
    public long ShiftId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public int? TerminalId { get; set; }

    public int? StoreId { get; set; }

    public decimal? NetSaleTaxed { get; set; }

    public decimal? NetSalesNonTaxed { get; set; }

    public decimal? NetSalesTaxExempt { get; set; }

    public decimal? Tax1 { get; set; }

    public decimal? Tax2 { get; set; }

    public decimal? Tax3 { get; set; }

    public decimal? Tax4 { get; set; }

    public decimal? Tax5 { get; set; }

    public decimal? Tax6 { get; set; }

    public int? OpenCashierId { get; set; }

    public int? CloseCashierId { get; set; }

    public bool? IsClosed { get; set; }

    public decimal? OpenAmount { get; set; }

    public decimal? CloseAmount { get; set; }

    public decimal? OverShot { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
