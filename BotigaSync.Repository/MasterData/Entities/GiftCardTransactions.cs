using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class GiftCardTransactions
{
    public long GiftCardTransactionId { get; set; }

    public long GiftCardId { get; set; }

    public int StoreId { get; set; }

    public int TransactionType { get; set; }

    public decimal Amt { get; set; }

    public long InvoiceNumber { get; set; }

    public int ProcessingType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public decimal SalePrice { get; set; }

    public decimal SaleTax { get; set; }

    public int? CustomerId { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
