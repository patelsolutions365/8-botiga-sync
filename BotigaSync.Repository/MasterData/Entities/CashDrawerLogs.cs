using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class CashDrawerLogs
{
    public long Id { get; set; }

    public int TerminalId { get; set; }

    public int StoreId { get; set; }

    public int OpenBy { get; set; }

    public DateTime OpenDate { get; set; }

    public string? Reason { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
