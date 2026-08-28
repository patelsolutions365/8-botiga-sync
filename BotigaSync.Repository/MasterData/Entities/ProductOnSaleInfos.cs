using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ProductOnSaleInfos
{
    public int ProductOnSaleInfoId { get; set; }

    public int? ProductId { get; set; }

    public int? StoreId { get; set; }

    public DateTime? SaleStart { get; set; }

    public DateTime? SaleEnd { get; set; }

    public float? Percent { get; set; }

    public decimal? Price { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public int? DiscountTypeId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
