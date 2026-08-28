using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class TouchScreenSetup
{
    public int TouchScreenSetupId { get; set; }

    public int? StoreId { get; set; }

    public bool? UseDecimals { get; set; }

    public bool? HideRiquantityBox { get; set; }

    public bool? HideRiquantityButton { get; set; }

    public bool? ShowInventoryButton { get; set; }

    public bool? ShowRestaurantSacnBox { get; set; }

    public bool? AlwaysShowCustInfo { get; set; }

    public bool? StocksLevelsOnTs { get; set; }

    public bool? HiddenFromTs { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
