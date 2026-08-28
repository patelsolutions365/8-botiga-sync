using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class PropertyDetails
{
    public int PropertyValueId { get; set; }

    public int PropertyId { get; set; }

    public int? StoreId { get; set; }

    public string Description { get; set; } = null!;

    public int? PurchaseType { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
