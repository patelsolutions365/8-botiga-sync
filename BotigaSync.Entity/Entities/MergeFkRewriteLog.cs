using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class MergeFkRewriteLog
{
    public int TenantId { get; set; }

    public DateTime CompletedAt { get; set; }

    public Guid GlobalId { get; set; }
}
