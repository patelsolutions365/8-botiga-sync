using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ImportCsv
{
    public string? ItemNum { get; set; }

    public string? ItemName { get; set; }

    public int? ItemType { get; set; }

    public decimal? Cost { get; set; }

    public decimal? Price { get; set; }

    public decimal? InStock { get; set; }

    public bool? PrintOnReceipt { get; set; }

    public bool? CountThisItem { get; set; }

    public bool? AllowReturns { get; set; }

    public string? DeptId { get; set; }

    public string? DepartmentName { get; set; }

    public string? CatId { get; set; }

    public string? CategoryName { get; set; }

    public string? Skus { get; set; }

    public decimal? ReorderLevel { get; set; }

    public decimal? ReorderQuantity { get; set; }

    public bool? FoodStampable { get; set; }

    public bool? CheckId { get; set; }

    public bool? CheckId2 { get; set; }

    public bool? PromptPrice { get; set; }

    public bool? PromptQuantity { get; set; }

    public string? Location { get; set; }

    public string? Taxes { get; set; }

    public bool? Inactive { get; set; }

    public int? StoreId { get; set; }

    public Guid GlobalId { get; set; }
}
