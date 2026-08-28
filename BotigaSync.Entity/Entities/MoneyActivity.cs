using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class MoneyActivity
{
    public int MoneyActivityId { get; set; }

    public int? StoreId { get; set; }

    public int? TerminalId { get; set; }

    public long? InvoiceId { get; set; }

    public string? PaymentMethod { get; set; }

    public int? CashierId { get; set; }

    public long? SubInvoiceNumber { get; set; }

    public int? ReferenceNumber { get; set; }

    public decimal? Amount { get; set; }

    public bool IsRefundable { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ChequeNo { get; set; }

    public int TransactionType { get; set; }

    public string? CardBin { get; set; }

    public string? AuthCode { get; set; }

    public string? HostRefNum { get; set; }

    public string? TraceNumber { get; set; }

    public string? BatchNumber { get; set; }

    public string? ApproveAmount { get; set; }

    public string? CardBalance { get; set; }

    public string? Account { get; set; }

    public string? EntryMode { get; set; }

    public string? ExpiryDate { get; set; }

    public string? CardType { get; set; }

    public string? CardHolderName { get; set; }

    public string? RefNum { get; set; }

    public string? EcrRefNum { get; set; }

    public string? Timestamp { get; set; }

    public string? Sn { get; set; }

    public string? GlobalUid { get; set; }

    public string? EdcType { get; set; }

    public bool IsSync { get; set; }

    public decimal? AmtTendered { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
