using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class MixNmatchLevel
{
    public int MixNmatchLevelId { get; set; }

    public int? MixNmatchId { get; set; }

    public int? StoreId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Qty { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
