using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class InvoiceExceptions
{
    public long InvoiceExceptionId { get; set; }

    public long InvoiceNumber { get; set; }

    public int StoreId { get; set; }

    public int TerminalId { get; set; }

    public int CashierId { get; set; }

    public int ExceptionType { get; set; }

    public int ProductId { get; set; }

    public decimal Amount { get; set; }

    public decimal Quantity { get; set; }

    public int ReasonCode { get; set; }

    public int LineNum { get; set; }

    public string? EmpName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
