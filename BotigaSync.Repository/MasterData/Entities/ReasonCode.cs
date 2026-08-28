using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ReasonCode
{
    public int ReasonCodeId { get; set; }

    public int? StoreId { get; set; }

    public int ReasonCodeType { get; set; }

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
