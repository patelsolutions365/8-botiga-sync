using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class LoginHistory
{
    public int LoginHistoryId { get; set; }

    public int? EmployeeId { get; set; }

    public string? LoginMethod { get; set; }

    public int? TerminalId { get; set; }

    public DateTime? LoginDatetime { get; set; }

    public DateTime? LogoutDatetime { get; set; }

    public int? StoreId { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Token { get; set; }

    public bool? IsActiveSession { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
