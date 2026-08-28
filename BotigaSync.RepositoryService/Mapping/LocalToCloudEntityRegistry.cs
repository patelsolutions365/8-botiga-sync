namespace BotigaSync.RepositoryService.Mapping;

public sealed record LocalToCloudEntity(string LocalEntityType, string Category);

/// <summary>
/// Local-to-Cloud contract. A shared table is not automatically outbound: only
/// records owned by an in-store POS workflow belong in this registry.
/// </summary>
public static class LocalToCloudEntityRegistry
{
    private static readonly IReadOnlyDictionary<string, LocalToCloudEntity> Entities =
        CreateEntities();

    public static bool TryResolve(string localEntityType, out LocalToCloudEntity entity)
    {
        return Entities.TryGetValue(localEntityType, out entity!);
    }

    private static IReadOnlyDictionary<string, LocalToCloudEntity> CreateEntities()
    {
        var entities = new Dictionary<string, LocalToCloudEntity>(StringComparer.OrdinalIgnoreCase);

        Add("SaleCompleted", "InvoiceTotal", "InvoiceItem", "CCTrans", "GiftCardTransaction", "OnAccountTransaction", "OnAccountTransactionDetail", "MoneyActivity", "InventoryTransaction");
        Add("SaleVoidedOrOnHold", "InvoiceOnHold", "InvoiceException", "CustomOrder");
        Add("CustomerChanged", "Customer", "CustomerShipTo", "CustomerAuthorized", "CustomerSwipe", "CustomerPriceLevel");
        Add("LoyaltyActivityRecorded", "Loyalty", "LoyaltyItem", "RewardPointsTransaction");
        Add("GiftCardActivityRecorded", "GiftCard");
        Add("ShiftEvent", "Shift", "ShiftTrack", "EmployeeClockinOut", "EmployeeBreak");
        Add("CashDrawerEvent", "CashDrawerLog", "TerminalCashLog");
        Add("StockAdjusted", "InventoryHistory");
        Add("PurchaseOrderReceived", "PurchaseOrder", "PurchaseOrderDetail", "PolineItem", "Vendor", "VendorContact");
        Add("Terminal", "Terminal");
        Add("Product", "Product");
        Add("CashMovement", "CashMovement");
        Add("LoginHistory", "LoginHistory");

        return entities;

        void Add(string category, params string[] entityTypes)
        {
            foreach (var entityType in entityTypes)
            {
                entities.Add(entityType, new LocalToCloudEntity(entityType, category));
            }
        }
    }
}
