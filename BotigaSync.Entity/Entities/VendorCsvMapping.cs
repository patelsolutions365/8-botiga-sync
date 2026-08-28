using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class VendorCsvMapping
{
    public int VendorCsvMappingId { get; set; }

    public int? VendorId { get; set; }

    public string? MappingName { get; set; }

    public string? ColVendorName { get; set; }

    public string? ColInvoiceNumber { get; set; }

    public string? ColInvoiceDate { get; set; }

    public string? ColDueDate { get; set; }

    public string? ColProcessDate { get; set; }

    public string? ColInvoiceAmount { get; set; }

    public string? ColInvoiceItemCount { get; set; }

    public string? ColPonumber { get; set; }

    public string? ColVendorStoreNumber { get; set; }

    public string? ColRetailerStoreNumber { get; set; }

    public string? ColProductNumber { get; set; }

    public string? ColProductDescription { get; set; }

    public string? ColQuantity { get; set; }

    public string? ColCostPer { get; set; }

    public string? ColExtendedPrice { get; set; }

    public string? ColUnitOfMeasure { get; set; }

    public string? ColProductVolume { get; set; }

    public string? ColCaseUpc { get; set; }

    public string? ColCleanUpc { get; set; }

    public string? ColPackUpc { get; set; }

    public string? ColPacksPerCase { get; set; }

    public string? ColUnitsPerPack { get; set; }

    public string? ColProductClass { get; set; }

    public string? ColGlcode { get; set; }

    public string? ColDiscountAmount { get; set; }

    public string? ColTaxAmount { get; set; }

    public string? ColDeliveryAdjustment { get; set; }

    public string? ColDepositAdjustment { get; set; }

    public string? ColMiscAdjustment { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
