using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class GroupCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public int? StoreId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual ICollection<Group> Group { get; set; } = new List<Group>();
}
