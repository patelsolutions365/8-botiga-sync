using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class OrderActions
{
    public int OrderActionId { get; set; }

    public string? ActionType { get; set; }

    public string? ActionDetail { get; set; }

    public int? OrderId { get; set; }

    public int? EmployeeId { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
