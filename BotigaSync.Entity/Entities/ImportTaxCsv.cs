using System;
using System.Collections.Generic;

namespace BotigaSync.Entity.Entities;

public partial class ImportTaxCsv
{
    public string? Tax1Name { get; set; }

    public decimal? Tax1Rate { get; set; }

    public string? Tax2Name { get; set; }

    public decimal? Tax2Rate { get; set; }

    public string? Tax3Name { get; set; }

    public decimal? Tax3Rate { get; set; }

    public string? Tax4Name { get; set; }

    public decimal? Tax4Rate { get; set; }

    public string? Tax5Name { get; set; }

    public decimal? Tax5Rate { get; set; }

    public string? Tax6Name { get; set; }

    public decimal? Tax6Rate { get; set; }

    public int? StoreId { get; set; }

    public Guid GlobalId { get; set; }
}
