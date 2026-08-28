using System;
using System.Collections.Generic;

namespace BotigaSync.Repository.MasterData.Entities;

public partial class ReceiptSetup
{
    public int ReceiptSetupId { get; set; }

    public int? StoreId { get; set; }

    public int? ReceiptSize { get; set; }

    public int? PrintInvoices { get; set; }

    public int? ProfLogo { get; set; }

    public int? PrintModifiers { get; set; }

    public string? NoOfCopies { get; set; }

    public string? NoOfStoreCrreceipts { get; set; }

    public string? KitchenReceipt { get; set; }

    public string? NoOfExtraCopiesByCredit { get; set; }

    public string? NoOfExtraCopiesByDebit { get; set; }

    public string? NoOfExtraCopiesByEbt { get; set; }

    public string? NoOfExtraCopiesByGift { get; set; }

    public string? NoOfExtraCopiesByCash { get; set; }

    public bool? NoOfExtraCopiesBySupressExtra { get; set; }

    public bool? PromptToEmail { get; set; }

    public bool? OnHoldReceipts { get; set; }

    public bool? CompleteReceipts { get; set; }

    public bool? AccountReceipts { get; set; }

    public bool? SuppressExtra { get; set; }

    public bool? PrintNotesOnCc { get; set; }

    public bool? PrintDeptNotes { get; set; }

    public bool? PrintItemCount { get; set; }

    public bool? PrintSecondDesc { get; set; }

    public bool? ValidateChecks { get; set; }

    public bool? CombineLines { get; set; }

    public bool? PrintPaidStatus { get; set; }

    public bool? PrintCustomerNotes { get; set; }

    public bool? PrintSurchargeDisclaimer { get; set; }

    public bool? DisplayInventoryItem { get; set; }

    public bool? PrintKitItems { get; set; }

    public bool? PrintAmtSaved { get; set; }

    public bool? PrintAccBal { get; set; }

    public bool? PrintCash { get; set; }

    public bool? PrintCc { get; set; }

    public bool? PrintAll { get; set; }

    public bool? DisplayEquals { get; set; }

    public int? PrintCustomerInfo { get; set; }

    public bool? PrintToppings { get; set; }

    public string? NoOfDockets { get; set; }

    public string? CancelledCheckFee { get; set; }

    public bool? PrintOrderTypeToStay { get; set; }

    public bool? PrintOrderTypeToGo { get; set; }

    public bool? PrintOrderTypeDelivery { get; set; }

    public bool? PrintOrderTypeDriveThru { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool IsSync { get; set; }

    public long? LocalId { get; set; }

    public Guid GlobalId { get; set; }
}
