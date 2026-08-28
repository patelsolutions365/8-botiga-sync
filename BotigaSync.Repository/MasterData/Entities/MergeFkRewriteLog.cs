using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class MergeFkRewriteLog
{
    public int TenantId { get; set; }

    public DateTime CompletedAt { get; set; }

    public Guid GlobalId { get; set; }
}
