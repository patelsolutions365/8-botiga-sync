using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class OnAccountTransactionDetails
{
    public long Id { get; set; }

    public long TransId { get; set; }

    public long InvoiceNumber { get; set; }

    public decimal Amount { get; set; }

    public decimal PrevInvBalance { get; set; }

    public int StoreId { get; set; }

    public int TargetStoreId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long Pid { get; set; }

    public int CustomerId { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
