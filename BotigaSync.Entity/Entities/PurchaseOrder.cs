using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class PurchaseOrder
{
    public int Poid { get; set; }

    public int? StoreId { get; set; }

    public int? VendorId { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? TotalCostReceived { get; set; }

    public string? Terms { get; set; }

    public string? ShipVia { get; set; }

    public string? ShipTo1 { get; set; }

    public string? ShipTo2 { get; set; }

    public string? ShipTo3 { get; set; }

    public string? ShipTo4 { get; set; }

    public string? ShipTo5 { get; set; }

    public string? Status { get; set; }

    public string? BillableDepartment { get; set; }

    public string? ShipToDestination { get; set; }

    public int OrderingMode { get; set; }

    public bool? IsFullyAuthorized { get; set; }

    public bool? IsPrintNote { get; set; }

    public DateTime? CancelDate { get; set; }

    public decimal? TotalCharges { get; set; }

    public bool? IsFullyPaid { get; set; }

    public int? Potype { get; set; }

    public string? OrderReason { get; set; }

    public string? Distributor { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public string? Note { get; set; }

    public string? Reference { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
