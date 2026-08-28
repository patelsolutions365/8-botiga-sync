using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class PurchaseOrderDetails
{
    public int PodetailId { get; set; }

    public int? Poid { get; set; }

    public int? ProductId { get; set; }

    public int? LineItemNumber { get; set; }

    public decimal? CostPer { get; set; }

    public decimal? QtyOdered { get; set; }

    public decimal? QtyReceived { get; set; }

    public string? VendorPartNumber { get; set; }

    public decimal? PerCase { get; set; }

    public decimal? CaseCost { get; set; }

    public int? StoreId { get; set; }

    public int? DestinationStoreId { get; set; }

    public decimal? CurrentBatchQty { get; set; }

    public decimal? DamagedQty { get; set; }

    public string? Reason { get; set; }

    public bool? IsCommissionOverride { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public decimal CasesOrdered { get; set; }

    public bool IsSync { get; set; }

    public decimal? QtyApplied { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
