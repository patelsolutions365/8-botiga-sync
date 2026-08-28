using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Loyalty
{
    public int LoyaltyId { get; set; }

    public string? LoyaltyProgramName { get; set; }

    public string? LoyaltyProgramDesc { get; set; }

    public int? StoreId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
