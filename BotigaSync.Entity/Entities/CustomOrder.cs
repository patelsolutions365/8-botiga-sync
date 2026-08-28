using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class CustomOrder
{
    public int CustomOrderId { get; set; }

    public int? StoreId { get; set; }

    public int? TerminalId { get; set; }

    public string Description { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
