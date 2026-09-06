using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? PrimaryStoreId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Department { get; set; }

    public int? RoleId { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
