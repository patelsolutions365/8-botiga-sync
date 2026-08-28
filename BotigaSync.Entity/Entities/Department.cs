using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? DepartmentSellTime { get; set; }

    public int? CategoryId { get; set; }

    public bool? IsActive { get; set; }

    public int? StoreId { get; set; }

    public string? ImportRef { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Product> Product { get; set; } = new List<Product>();
}
