using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class TaxRate
{
    public int TaxRateId { get; set; }

    public string? TaxRateName { get; set; }

    public decimal? TaxRatePercent { get; set; }

    public bool? IsDefault { get; set; }

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
