using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class EmployeeClockinOut
{
    public int EmployeeClockInOutId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? ClockInDateTime { get; set; }

    public DateTime? ClockOutDateTime { get; set; }

    public string? Type { get; set; }

    public bool IsDelete { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDateTime { get; set; }

    public int? StoreId { get; set; }

    public int? TerminalId { get; set; }

    public decimal OverTimeWage { get; set; }

    public string? RoleId { get; set; }

    public string? RoleName { get; set; }

    public decimal Wage { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual ICollection<EmployeeBreak> EmployeeBreak { get; set; } = new List<EmployeeBreak>();
}
