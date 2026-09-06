using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class EmployeeRole
{
    public int RoleId { get; set; }

    public int? StoreId { get; set; }

    public string? RoleName { get; set; }

    public decimal? DefaultWage { get; set; }

    public decimal? DefaultOvertimeWage { get; set; }

    public int? ShiftReportNoofCopies { get; set; }

    public bool? AccesstoPOS { get; set; }

    public bool? RecordCashTips { get; set; }

    public bool? CashBank { get; set; }

    public bool? ReuireCashDeawerSelection { get; set; }

    public bool? ReuireCashCountScreenonClockout { get; set; }

    public bool? EnablewithDeliveryTracking { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
