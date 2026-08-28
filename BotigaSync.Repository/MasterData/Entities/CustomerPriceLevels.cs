using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class CustomerPriceLevels
{
    public int CustomerPriceLevelId { get; set; }

    public int CustomerId { get; set; }

    public decimal? DiscountPercent { get; set; }

    public int? ProductId { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
