using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ProductNotes
{
    public int ProductNoteId { get; set; }

    public int? ProductId { get; set; }

    public string? ProductNote { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsSync { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
