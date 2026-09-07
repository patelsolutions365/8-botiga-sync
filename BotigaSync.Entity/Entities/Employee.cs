using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? PrimaryStoreId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? DisplayName { get; set; }

    public string? Department { get; set; }

    public int? RoleId { get; set; }

    public bool Status { get; set; }

    public string? Image { get; set; }

    public double? HourlyWage { get; set; }

    public double? OvertimeWage { get; set; }

    public decimal? CurrentCash { get; set; }

    public string? CardSwipe { get; set; }

    public string? Customer { get; set; }

    public bool? DisableEmployee { get; set; }

    public bool? ClockINBeforeLogin { get; set; }

    public bool? EnableMobileInventory { get; set; }

    public bool? CCTips { get; set; }

    public bool? IsBreakTimeInclude { get; set; }

    public string? SSN { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
