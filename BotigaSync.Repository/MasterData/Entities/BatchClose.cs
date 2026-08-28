using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class BatchClose
{
    public int BatchCloseId { get; set; }

    public int StoreId { get; set; }

    public int? TerminalId { get; set; }

    public string? BatchNumber { get; set; }

    public DateTime? ClosedDate { get; set; }

    public int? ClosedBy { get; set; }

    public string? ClosedByName { get; set; }

    public int? TransactionCount { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? DebitAmount { get; set; }

    public decimal? EbtAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? CreditCount { get; set; }

    public int? DebitCount { get; set; }

    public int? EbtCount { get; set; }

    public string? HostResponseCode { get; set; }

    public string? HostResponseMessage { get; set; }

    public string? HostBatchNumber { get; set; }

    public bool? IsSuccess { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Notes { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
