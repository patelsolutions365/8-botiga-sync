using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ProductVendor
{
    public int ProductVendorId { get; set; }

    public int VendorId { get; set; }

    public int? ProductId { get; set; }

    public decimal? CostPer { get; set; }

    public decimal? CaseCost { get; set; }

    public decimal? PerCase { get; set; }

    public string? VendorPartNumber { get; set; }

    public int? Index { get; set; }

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
