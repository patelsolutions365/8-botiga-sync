using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class Properties
{
    public int PropertyId { get; set; }

    public int? StoreId { get; set; }

    public string Description { get; set; } = null!;

    public bool? AllowCustomer { get; set; }

    public bool? AllowInventory { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
