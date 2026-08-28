using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ProductCouponRules
{
    public int InventoryCouponRuleId { get; set; }

    public int? StoreId { get; set; }

    public int? CouponId { get; set; }

    public int? RestrictionOnId { get; set; }

    public int? Id { get; set; }

    public int? RestrictionTypeId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
