using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ProductPriceCustomerLevel
{
    public int ProductPriceCustomerLevelId { get; set; }

    public int? ProductPriceLevelId { get; set; }

    public int? CustomerId { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
