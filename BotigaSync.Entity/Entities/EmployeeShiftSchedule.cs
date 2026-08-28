using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class EmployeeShiftSchedule
{
    public int EmployeeShiftScheduleId { get; set; }

    public int? EmployeeId { get; set; }

    public int? ShiftId { get; set; }

    public int? StoreId { get; set; }

    public DateTime? ShiftInTime { get; set; }

    public DateTime? ShiftOutTime { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
