using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ProductIngredients
{
    public int ProductIngredientId { get; set; }

    public int? StoreId { get; set; }

    public int? ProductId { get; set; }

    public int? IngredientId { get; set; }

    public decimal? Quantity { get; set; }

    public int? Measurement { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
