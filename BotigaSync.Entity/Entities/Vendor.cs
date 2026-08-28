using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class Vendor
{
    public int VendorId { get; set; }

    public string? CompanyName { get; set; }

    public string? Website { get; set; }

    public bool? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? VendorNumber { get; set; }

    public decimal? Comission { get; set; }

    public string? TaxId { get; set; }

    public string? Terms { get; set; }

    public string? BillableDepartment { get; set; }

    public decimal? MinimumOrder { get; set; }

    public decimal? FlatRentRate { get; set; }

    public string? Einnumber { get; set; }

    public string? StreetAddress { get; set; }

    public string? ExtendedAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? TelephoneNumber { get; set; }

    public string? FaxNumber { get; set; }

    public string? Email { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual ICollection<VendorPayout> VendorPayout { get; set; } = new List<VendorPayout>();
}
