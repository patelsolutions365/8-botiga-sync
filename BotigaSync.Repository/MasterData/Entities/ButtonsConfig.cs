using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ButtonsConfig
{
    public int ButtonId { get; set; }

    public int? TerminalId { get; set; }

    public string? Name { get; set; }

    public string? Label { get; set; }

    public string? Xpos { get; set; }

    public string? Ypos { get; set; }

    public string? Height { get; set; }

    public string? Width { get; set; }

    public string? ActionType { get; set; }

    public bool? IsSystemButton { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
