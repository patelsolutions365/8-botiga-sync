using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class EmployeeNotes
{
    public int EmployeeNoteId { get; set; }

    public int? StoreId { get; set; }

    public int? TerminalId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? ClosedDate { get; set; }

    public int? ClosedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
