using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class FriendlyPrinterSetup
{
    public int FriendlyPrinterSetupId { get; set; }

    public int? StoreId { get; set; }

    public string? PrinterName { get; set; }

    public string? LocalPrinterName { get; set; }

    public string? PrinterType { get; set; }

    public bool? CutReceipt { get; set; }

    public bool? DisablePrinter { get; set; }

    public bool? PrintMasterReceipts { get; set; }

    public bool? PrintOrders { get; set; }

    public int? LinesToFeed { get; set; }

    public bool? PrintLogo { get; set; }

    public string? Image { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
