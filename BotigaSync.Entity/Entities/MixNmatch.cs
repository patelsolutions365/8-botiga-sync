using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class MixNmatch
{
    public int MixNmatchId { get; set; }

    public int? StoreId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public int? DepartmentId { get; set; }

    public string? PriceGroupId { get; set; }

    public string? Description { get; set; }

    public decimal? QtyRequired { get; set; }

    public decimal? AmountToDiscount { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? PriceGroupTypeId { get; set; }

    public decimal? CustomerLimit { get; set; }

    public int? CustomerDays { get; set; }

    public bool? IsActive { get; set; }

    public bool IsSync { get; set; }

    public int? ApplyType { get; set; }

    public bool? IsTaxCollect { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
