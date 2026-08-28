using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class DeletedCartItem
{
    public long DeletedCartItemId { get; set; }

    public int StoreId { get; set; }

    public int TerminalId { get; set; }

    public int CashierId { get; set; }

    public string? CashierName { get; set; }

    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCode { get; set; }

    public int LineNumber { get; set; }

    public decimal Qty { get; set; }

    public decimal PricePer { get; set; }

    public decimal LineTotal { get; set; }

    public DateTime DeletedAt { get; set; }

    public long? InvoiceId { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
