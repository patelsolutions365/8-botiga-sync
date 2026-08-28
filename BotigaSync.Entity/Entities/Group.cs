using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Group
{
    public int GroupId { get; set; }

    public int? GroupCategoryId { get; set; }

    public string? ProductGroupName { get; set; }

    public decimal? ProductByDown { get; set; }

    public decimal? ProductExtraByDown { get; set; }

    public decimal? ProductCost { get; set; }

    public decimal? Productprice { get; set; }

    public decimal? Percentage { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsBeforeTax { get; set; }

    public int? Qty { get; set; }

    public decimal? ProductpriceYouCharge { get; set; }

    public bool IsSync { get; set; }

    public decimal? BonusPointGroup { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual GroupCategory? GroupCategory { get; set; }
}
