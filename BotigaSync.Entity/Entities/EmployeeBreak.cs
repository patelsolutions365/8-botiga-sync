using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class EmployeeBreak
{
    public int EmployeeBreakId { get; set; }

    public int? EmployeeClockInOutId { get; set; }

    public int? StoreId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? BreakStartDateTime { get; set; }

    public DateTime? BreakEndDateTime { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual EmployeeClockinOut? EmployeeClockInOut { get; set; }
}
