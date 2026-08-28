using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ErrorLog
{
    public int ErrorLogId { get; set; }

    public string ScreenName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
