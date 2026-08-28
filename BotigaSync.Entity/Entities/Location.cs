using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Location
{
    public int LocationId { get; set; }

    public string? LocationName { get; set; }

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
