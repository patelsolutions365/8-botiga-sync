using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class LoyaltyItems
{
    public int LoyaltyItemId { get; set; }

    public int StoreId { get; set; }

    public string Description { get; set; } = null!;

    public int LoyaltyType { get; set; }

    public decimal Criteria { get; set; }

    public string ProductCode { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? Tax1 { get; set; }

    public decimal? Tax2 { get; set; }

    public decimal? Tax3 { get; set; }

    public decimal? Tax4 { get; set; }

    public decimal? Tax5 { get; set; }

    public decimal? Tax6 { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public decimal? ApplyOnQtyFc { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
