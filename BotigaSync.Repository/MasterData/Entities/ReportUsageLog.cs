using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ReportUsageLog
{
    public long Id { get; set; }

    public int ReportType { get; set; }

    public int ActionType { get; set; }

    public string? UserId { get; set; }

    public int? StoreId { get; set; }

    public string? TerminalId { get; set; }

    public DateTime ClickedAt { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
