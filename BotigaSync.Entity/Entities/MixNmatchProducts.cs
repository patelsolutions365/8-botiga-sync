using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class MixNmatchProducts
{
    public int MixNmatchProductId { get; set; }

    public int? StoreId { get; set; }

    public int? MixNmatchId { get; set; }

    public int? ProductId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
