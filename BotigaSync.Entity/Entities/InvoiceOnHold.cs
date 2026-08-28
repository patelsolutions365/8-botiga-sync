using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class InvoiceOnHold
{
    public int InvoiceOnHoldId { get; set; }

    public string OnHoldId { get; set; } = null!;

    public int CashierId { get; set; }

    public int StoreId { get; set; }

    public int Teminald { get; set; }

    public int Status { get; set; }

    public string? CustomerName { get; set; }

    public long InvoiceNumber { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
