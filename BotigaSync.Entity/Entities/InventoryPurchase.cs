using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class InventoryPurchase
{
    public int InventoryPurchaseId { get; set; }

    public int? StoreId { get; set; }

    public int? VendorId { get; set; }

    public string? Status { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Ponumber { get; set; }

    public string? VendorStoreNumber { get; set; }

    public string? Note { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? FintechProcessDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public int TotalItems { get; set; }

    public decimal TotalUnitsOrdered { get; set; }

    public decimal TotalUnitsReceived { get; set; }

    public decimal TotalCostOrdered { get; set; }

    public decimal TotalCostReceived { get; set; }

    public bool? IsActive { get; set; }

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
