using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class LogPage
{
    public int LogPageId { get; set; }

    public string? PageName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
