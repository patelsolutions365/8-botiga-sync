using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class EmployeeLoginMethod
{
    public int EmployeeLoginMethodId { get; set; }

    public int? EmployeeId { get; set; }

    public string? LoginMethodType { get; set; }

    public string? PasswordOrCardData { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
