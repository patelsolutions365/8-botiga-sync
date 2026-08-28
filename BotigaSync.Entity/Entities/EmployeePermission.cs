using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class EmployeePermission
{
    public int EmployeePermissionId { get; set; }

    public int? EmployeeId { get; set; }

    public string? Feature { get; set; }

    public bool IsRead { get; set; }

    public bool IsWrite { get; set; }

    public bool IsDelete { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
