using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ReportConfiguration
{
    public int Id { get; set; }

    public int ReportType { get; set; }

    public int ActionType { get; set; }

    public int LimitPeriod { get; set; }

    public int LimitValue { get; set; }

    public DateTime LastUpdated { get; set; }

    public string? ModifiedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
