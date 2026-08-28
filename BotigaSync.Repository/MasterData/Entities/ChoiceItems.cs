using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ChoiceItems
{
    public int ChoiceItemId { get; set; }

    public string? ProductCode { get; set; }

    public int? StoreId { get; set; }

    public int? ChoiceProductId { get; set; }

    public int? ProductId { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Qty { get; set; }

    public int? Index { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
