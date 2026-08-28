using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class VendorPayout
{
    public int VendorPayoutId { get; set; }

    public int VendorId { get; set; }

    public int PaymentTypeId { get; set; }

    public decimal? Amount { get; set; }

    public string? Reason { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool IsSync { get; set; }

    public int? TerminalId { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual PaymentType PaymentType { get; set; } = null!;

    public virtual Terminal? Terminal { get; set; }

    public virtual Vendor Vendor { get; set; } = null!;
}
