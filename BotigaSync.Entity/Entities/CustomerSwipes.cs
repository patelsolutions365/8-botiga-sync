using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class CustomerSwipes
{
    public int Id { get; set; }

    public string? SwipeId { get; set; }

    public int? CustomerId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
