using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class PolineItems
{
    public int PolineItemId { get; set; }

    public int? Poid { get; set; }

    public int? ProductId { get; set; }

    public string? QtyOrder { get; set; }

    public string? QtyRecevied { get; set; }

    public string? QtyReturned { get; set; }

    public bool Status { get; set; }

    public decimal? CostPerUnit { get; set; }

    public decimal? TotalLineCost { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
