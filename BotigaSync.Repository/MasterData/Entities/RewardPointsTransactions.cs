using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class RewardPointsTransactions
{
    public long Id { get; set; }

    public int? CustomerId { get; set; }

    public decimal Points { get; set; }

    public int TransactionType { get; set; }

    public int? ProductId { get; set; }

    public long? InvoiceNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual Customers? Customer { get; set; }

    public virtual InvoiceTotals? InvoiceNumberNavigation { get; set; }

    public virtual Product? Product { get; set; }
}
