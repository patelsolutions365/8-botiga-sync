using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class InventoryTransaction
{
    public int InventoryTransctionId { get; set; }

    public int ProductId { get; set; }

    public int? StoreId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? CostPer { get; set; }

    public int? VendorId { get; set; }

    public string? Transtype { get; set; }

    public string? Destination { get; set; }

    public string? Description { get; set; }

    public int? Ponumber { get; set; }

    public int? DeliveryNumber { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ProductSkuid { get; set; }

    public bool IsSync { get; set; }

    public long? InvoiceNumber { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
