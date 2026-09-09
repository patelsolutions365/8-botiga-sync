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
        // Vendor/VendorContact are Cloud -> Local only now - vendors are managed
        // centrally, not per-store, so a local edit should never push back up.
        Add("PurchaseOrderReceived", "PurchaseOrder", "PurchaseOrderDetail", "PolineItem");
        Add("Terminal", "Terminal");
        Add("Product", "Product");
        Add("CashMovement", "CashMovement");
        Add("LoginHistory", "LoginHistory");
        // Cash paid out to a vendor from the till - recorded at the store.
        Add("VendorPayout", "VendorPayout");
        // Printer hardware is set up on-site at the store, not pushed down from a
        // central admin dashboard.
        Add("PrinterSetup", "FriendlyPrinterSetup", "PrinterSetup", "PrinterType");
        // Employee identity/role/permissions are managed at the store - mirrored off
        // ApplicationUser/ApplicationRole+AspNetRoleClaims (see UserManagementRepository,
        // PermissionRepository in 1-botiga-api-instore). AspNetUsers/AspNetRoles/
        // AspNetRoleClaims themselves never sync.
        Add("EmployeeManagement", "Employee", "EmployeeRole", "EmployeePermission");
        // Customer loyalty enrollment happens at the store.
        Add("LoyaltyProgramEnrollment", "CustomerLoyaltyProgram");
        // Abandoned/removed cart lines - audit trail, happens at the store terminal.
        Add("CartItemDeleted", "DeletedCartItem");
        // Defective-item swap at the register - tied to a store, terminal, cashier.
        Add("ProductExchange", "ProductExchange");

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
