using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class DepartmentCsv
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? SubType { get; set; }

    public string? DeptId { get; set; }

    public int? StoreId { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
