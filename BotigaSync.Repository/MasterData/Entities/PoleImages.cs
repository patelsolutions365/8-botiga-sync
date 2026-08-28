using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class PoleImages
{
    public int PoleImageId { get; set; }

    public string? Image { get; set; }

    public int StoreId { get; set; }

    public int TerminalId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool IsSync { get; set; }

    public string? FileType { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
