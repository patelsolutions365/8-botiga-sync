using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class Cctrans
{
    public int CctransId { get; set; }

    public int StoreId { get; set; }

    public int TerminalId { get; set; }

    public int? CustomTypeId { get; set; }

    public string? Type { get; set; }

    public decimal? Amount { get; set; }

    public long? InvoiceNumber { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Edctype { get; set; }

    public string? EntryMode { get; set; }

    public bool? IsSuccess { get; set; }

    public string? Message { get; set; }

    public string? SubType { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
