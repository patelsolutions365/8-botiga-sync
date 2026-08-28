using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class LogActivity
{
    public int LogActivityId { get; set; }

    public int? PageId { get; set; }

    public int? FieldId { get; set; }

    public decimal? OldValue { get; set; }

    public decimal? NewValue { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
