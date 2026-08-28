using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ProductPriceLevel
{
    public int ProductPriceLevelId { get; set; }

    public int? ProductId { get; set; }

    public string? Level { get; set; }

    public decimal? Price { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
