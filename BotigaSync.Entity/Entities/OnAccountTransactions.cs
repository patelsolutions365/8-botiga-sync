using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class OnAccountTransactions
{
    public long OnAccountTransactionId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int CashierId { get; set; }

    public int CustomerId { get; set; }

    public string TransactionType { get; set; } = null!;

    public decimal PreviousCustBalance { get; set; }

    public decimal? PreviousInvBalance { get; set; }

    public decimal? TransactionAmount { get; set; }

    public decimal? OaAmount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? PaymentInfo { get; set; }

    public string? Description { get; set; }

    public int StoreId { get; set; }

    public long InvoiceId { get; set; }

    public int TerminalId { get; set; }

    public int? PaymentType { get; set; }

    public decimal? AmountRemaining { get; set; }

    public int? CancelTransaction { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
