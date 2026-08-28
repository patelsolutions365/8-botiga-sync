using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class CategoryCsv
{
    public int Id { get; set; }

    public string? CatId { get; set; }

    public string? Description { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
