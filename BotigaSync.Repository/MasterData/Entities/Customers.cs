using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class Customers
{
    public int CustomerId { get; set; }

    public string? CustomerCode { get; set; }

    public int? StoreId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? CompanyName { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }

    public string? ZipCode { get; set; }

    public string? State { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public bool? IsTaxExempt { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public decimal? BonusPointAchived { get; set; }

    public int? AccountType { get; set; }

    public string? Attn { get; set; }

    public bool? IsPoentryRequired { get; set; }

    public DateTime? OpenAccountDate { get; set; }

    public DateTime? CloseAccountDate { get; set; }

    public decimal? BalanceDue { get; set; }

    public decimal? CreditLimit { get; set; }

    public decimal? RestrictSpendingTo { get; set; }

    public int? Over { get; set; }

    public DateTime? DaysStarting { get; set; }

    public int? LoyaltyProgramId { get; set; }

    public bool? IsActive { get; set; }

    public string? Note { get; set; }

    public string? BillContact1 { get; set; }

    public string? BillContact2 { get; set; }

    public string? Term { get; set; }

    public string? ResaleNum { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual ICollection<RewardPointsTransactions> RewardPointsTransactions { get; set; } = new List<RewardPointsTransactions>();
}
