using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class StoreDayEndDate
{
    public int StoreDayEndDateId { get; set; }

    public int StoreId { get; set; }

    public DateTime EndDateTime { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }

    public virtual Store Store { get; set; } = null!;
}
