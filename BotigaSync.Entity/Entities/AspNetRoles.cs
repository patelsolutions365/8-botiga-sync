using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class AspNetRoles
{
    public string Id { get; set; } = null!;

    public decimal? DefaultWage { get; set; }

    public decimal? DefaultOvertimeWage { get; set; }

    public int? ShiftReportNoofCopies { get; set; }

    public bool? AccesstoPos { get; set; }

    public bool? RecordCashTips { get; set; }

    public bool? CashBank { get; set; }

    public bool? ReuireCashDeawerSelection { get; set; }

    public bool? ReuireCashCountScreenonClockout { get; set; }

    public bool? EnablewithDeliveryTracking { get; set; }

    public bool? Assignablebyadminonly { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public bool IsSync { get; set; }

    public virtual ICollection<AspNetRoleClaims> AspNetRoleClaims { get; set; } = new List<AspNetRoleClaims>();

    public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; } = new List<AspNetUserRoles>();
}
