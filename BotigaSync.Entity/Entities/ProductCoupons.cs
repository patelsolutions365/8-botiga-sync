using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ProductCoupons
{
    public int ProductCouponId { get; set; }

    public int? StoreId { get; set; }

    public int? ProductId { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool? EnforceExp { get; set; }

    public bool? IncludeAllExcept { get; set; }

    public int? CouponPercentFlat { get; set; }

    public bool? CouponBonusOnly { get; set; }

    public bool? ApplyToParent { get; set; }

    public bool? SuppressBonus { get; set; }

    public decimal? MinimumAmountRestriction { get; set; }

    public int? NumOfDaysRestriction { get; set; }

    public bool? ApplyOnDiscountedItems { get; set; }

    public bool? ApplyOnSpecialPricing { get; set; }

    public decimal? CouponBonusMinimumQty { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ValidDateTime { get; set; }

    public int? CouponOptionId { get; set; }

    public decimal? QtyRestricted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
