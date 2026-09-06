using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class EmployeePermission
{
    public int EmployeePermissionId { get; set; }

    public int RoleId { get; set; }

    public string? Module { get; set; }

    public string? PermissionKey { get; set; }

    public string? PermissionValue { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
