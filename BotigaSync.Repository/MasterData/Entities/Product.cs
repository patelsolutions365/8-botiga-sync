using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string? CompanyName { get; set; }

    public int? StoreId { get; set; }

    public int? DepartmentId { get; set; }

    public int? CategoryId { get; set; }

    public int? GroupId { get; set; }

    public int ProductTypeId { get; set; }

    public int? ProductSkuid { get; set; }

    public string? Barcode { get; set; }

    public string? SerialNo { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Price { get; set; }

    public decimal? PriceWithTax { get; set; }

    public decimal? InstockQty { get; set; }

    public decimal? MixNmatchDiscount { get; set; }

    public decimal? ReOrderQty { get; set; }

    public int? ReOrderLevel { get; set; }

    public bool? IsDelete { get; set; }

    public string? Image { get; set; }

    public bool? AllowReturns { get; set; }

    public bool? ExcludeFromLoyalty { get; set; }

    public bool? IdProofRequired1 { get; set; }

    public bool? IdProofRequired2 { get; set; }

    public DateTime? LastSoldDate { get; set; }

    public bool? PromptQty { get; set; }

    public bool? PromptPrice { get; set; }

    public decimal? BonusPoints { get; set; }

    public string? Location { get; set; }

    public string? StockLocation { get; set; }

    public string? UnitSize { get; set; }

    public string? UnitType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsFavourite { get; set; }

    public bool? IsFoodStampable { get; set; }

    public bool? IsLoyaltyExclude { get; set; }

    public bool? IsCountItem { get; set; }

    public bool? IsPrintReceipt { get; set; }

    public int? CustomerLimitQty { get; set; }

    public int? DefaultLimitQty { get; set; }

    public int? TagId { get; set; }

    public int? VendorId { get; set; }

    public string? Note { get; set; }

    public bool? IsCustomerRequired { get; set; }

    public int? TotalSkustock { get; set; }

    public bool? IsStockManageBySku { get; set; }

    public bool? Inactive { get; set; }

    public int? PayInOutCategoryId { get; set; }

    public bool? IsDisable { get; set; }

    public bool? IsIntQty { get; set; }

    public bool IsSync { get; set; }

    public int? MasterProductId { get; set; }

    public decimal? PackSize { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<RewardPointsTransactions> RewardPointsTransactions { get; set; } = new List<RewardPointsTransactions>();
}
