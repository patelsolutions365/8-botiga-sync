using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class InventoryPurchaseDetail
{
    public int InventoryPurchaseDetailId { get; set; }

    public int InventoryPurchaseId { get; set; }

    public int? ProductId { get; set; }

    public int? StoreId { get; set; }

    public bool IsMatched { get; set; }

    public string? VendorProductNumber { get; set; }

    public string? CaseUpc { get; set; }

    public string? CleanUpc { get; set; }

    public string? PackUpc { get; set; }

    public string? ProductDescription { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? ProductVolume { get; set; }

    public string? ProductClass { get; set; }

    public string? Glcode { get; set; }

    public string? VendorPartNumber { get; set; }

    public decimal QtyOrdered { get; set; }

    public decimal QtyReceived { get; set; }

    public decimal QtyApplied { get; set; }

    public decimal PacksPerCase { get; set; }

    public decimal UnitsPerPack { get; set; }

    public decimal DamagedQty { get; set; }

    public decimal CostPer { get; set; }

    public decimal PerCase { get; set; }

    public decimal CaseCost { get; set; }

    public decimal ExtendedPrice { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal DeliveryAdjustment { get; set; }

    public decimal DepositAdjustment { get; set; }

    public decimal MiscAdjustment { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
