using System;
using System.Collections.Generic;
using BotigaSync.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BotigaSync.Repository.MasterData;

public partial class MasterBotigaDataContext(DbContextOptions<MasterBotigaDataContext> options) : DbContext(options)
{
    public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }

    public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }

    public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<AuditLogs> AuditLogs { get; set; }

    public virtual DbSet<BatchClose> BatchClose { get; set; }

    public virtual DbSet<ButtonsConfig> ButtonsConfig { get; set; }

    public virtual DbSet<CashDrawerLogs> CashDrawerLogs { get; set; }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<CategoryCsv> CategoryCsv { get; set; }

    public virtual DbSet<Cctrans> Cctrans { get; set; }

    public virtual DbSet<ChoiceItems> ChoiceItems { get; set; }

    public virtual DbSet<CompanyInformation> CompanyInformation { get; set; }

    public virtual DbSet<CustomOrder> CustomOrder { get; set; }

    public virtual DbSet<CustomerAuthorized> CustomerAuthorized { get; set; }

    public virtual DbSet<CustomerLoyaltyProgram> CustomerLoyaltyProgram { get; set; }

    public virtual DbSet<CustomerPriceLevels> CustomerPriceLevels { get; set; }

    public virtual DbSet<CustomerShipTo> CustomerShipTo { get; set; }

    public virtual DbSet<CustomerSwipes> CustomerSwipes { get; set; }

    public virtual DbSet<Customers> Customers { get; set; }

    public virtual DbSet<DeletedCartItem> DeletedCartItem { get; set; }

    public virtual DbSet<Department> Department { get; set; }

    public virtual DbSet<DepartmentCsv> DepartmentCsv { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<EmployeeBreak> EmployeeBreak { get; set; }

    public virtual DbSet<EmployeeClockinOut> EmployeeClockinOut { get; set; }

    public virtual DbSet<EmployeeLoginMethod> EmployeeLoginMethod { get; set; }

    public virtual DbSet<EmployeeNotes> EmployeeNotes { get; set; }

    public virtual DbSet<EmployeePermission> EmployeePermission { get; set; }

    public virtual DbSet<EmployeeShiftSchedule> EmployeeShiftSchedule { get; set; }

    public virtual DbSet<ErrorLog> ErrorLog { get; set; }

    public virtual DbSet<FavouriteProduct> FavouriteProduct { get; set; }

    public virtual DbSet<FriendlyPrinterSetup> FriendlyPrinterSetup { get; set; }

    public virtual DbSet<FtpConnection> FtpConnection { get; set; }

    public virtual DbSet<FtpProcessedFile> FtpProcessedFile { get; set; }

    public virtual DbSet<GiftCardTransactions> GiftCardTransactions { get; set; }

    public virtual DbSet<GiftCards> GiftCards { get; set; }

    public virtual DbSet<Group> Group { get; set; }

    public virtual DbSet<GroupCategory> GroupCategory { get; set; }

    public virtual DbSet<GroupProduct> GroupProduct { get; set; }

    public virtual DbSet<HotButton> HotButton { get; set; }

    public virtual DbSet<ImportCsv> ImportCsv { get; set; }

    public virtual DbSet<ImportTaxCsv> ImportTaxCsv { get; set; }

    public virtual DbSet<InventoryHistory> InventoryHistory { get; set; }

    public virtual DbSet<InventoryPurchase> InventoryPurchase { get; set; }

    public virtual DbSet<InventoryPurchaseDetail> InventoryPurchaseDetail { get; set; }

    public virtual DbSet<InventoryTransaction> InventoryTransaction { get; set; }

    public virtual DbSet<InvoiceExceptions> InvoiceExceptions { get; set; }

    public virtual DbSet<InvoiceItems> InvoiceItems { get; set; }

    public virtual DbSet<InvoiceOnHold> InvoiceOnHold { get; set; }

    public virtual DbSet<InvoiceTotals> InvoiceTotals { get; set; }

    public virtual DbSet<Location> Location { get; set; }

    public virtual DbSet<LogActivity> LogActivity { get; set; }

    public virtual DbSet<LogFields> LogFields { get; set; }

    public virtual DbSet<LogPage> LogPage { get; set; }

    public virtual DbSet<LoginHistory> LoginHistory { get; set; }

    public virtual DbSet<Loyalty> Loyalty { get; set; }

    public virtual DbSet<LoyaltyItems> LoyaltyItems { get; set; }

    public virtual DbSet<MergeFkRewriteLog> MergeFkRewriteLog { get; set; }

    public virtual DbSet<MixNmatch> MixNmatch { get; set; }

    public virtual DbSet<MixNmatchLevel> MixNmatchLevel { get; set; }

    public virtual DbSet<MixNmatchProducts> MixNmatchProducts { get; set; }

    public virtual DbSet<MoneyActivity> MoneyActivity { get; set; }

    public virtual DbSet<OnAccountTransactionDetails> OnAccountTransactionDetails { get; set; }

    public virtual DbSet<OnAccountTransactions> OnAccountTransactions { get; set; }

    public virtual DbSet<OrderActions> OrderActions { get; set; }

    public virtual DbSet<OrderDetails> OrderDetails { get; set; }

    public virtual DbSet<Orders> Orders { get; set; }

    public virtual DbSet<PaymentType> PaymentType { get; set; }

    public virtual DbSet<PoleImages> PoleImages { get; set; }

    public virtual DbSet<PolineItems> PolineItems { get; set; }

    public virtual DbSet<PrinterSetup> PrinterSetup { get; set; }

    public virtual DbSet<PrinterType> PrinterType { get; set; }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<ProductCategory> ProductCategory { get; set; }

    public virtual DbSet<ProductCouponRules> ProductCouponRules { get; set; }

    public virtual DbSet<ProductCoupons> ProductCoupons { get; set; }

    public virtual DbSet<ProductCsv> ProductCsv { get; set; }

    public virtual DbSet<ProductExchange> ProductExchange { get; set; }

    public virtual DbSet<ProductIngredients> ProductIngredients { get; set; }

    public virtual DbSet<ProductNotes> ProductNotes { get; set; }

    public virtual DbSet<ProductOnSaleInfos> ProductOnSaleInfos { get; set; }

    public virtual DbSet<ProductPriceCustomerLevel> ProductPriceCustomerLevel { get; set; }

    public virtual DbSet<ProductPriceHistory> ProductPriceHistory { get; set; }

    public virtual DbSet<ProductPriceLevel> ProductPriceLevel { get; set; }

    public virtual DbSet<ProductSku> ProductSku { get; set; }

    public virtual DbSet<ProductTax> ProductTax { get; set; }

    public virtual DbSet<ProductVendor> ProductVendor { get; set; }

    public virtual DbSet<Properties> Properties { get; set; }

    public virtual DbSet<PropertyDetails> PropertyDetails { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }

    public virtual DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }

    public virtual DbSet<ReasonCode> ReasonCode { get; set; }

    public virtual DbSet<ReceiptSetup> ReceiptSetup { get; set; }

    public virtual DbSet<RefreshToken> RefreshToken { get; set; }

    public virtual DbSet<ReportConfiguration> ReportConfiguration { get; set; }

    public virtual DbSet<ReportUsageLog> ReportUsageLog { get; set; }

    public virtual DbSet<RewardPointsTransactions> RewardPointsTransactions { get; set; }

    public virtual DbSet<ShiftTracks> ShiftTracks { get; set; }

    public virtual DbSet<Shifts> Shifts { get; set; }

    public virtual DbSet<StockVarianceLog> StockVarianceLog { get; set; }

    public virtual DbSet<Store> Store { get; set; }

    public virtual DbSet<StoreDayEndDate> StoreDayEndDate { get; set; }

    public virtual DbSet<TaxRate> TaxRate { get; set; }

    public virtual DbSet<Terminal> Terminal { get; set; }

    public virtual DbSet<TerminalCashLogs> TerminalCashLogs { get; set; }

    public virtual DbSet<TouchScreenSetup> TouchScreenSetup { get; set; }

    public virtual DbSet<UserReportQuota> UserReportQuota { get; set; }

    public virtual DbSet<Vendor> Vendor { get; set; }

    public virtual DbSet<VendorContact> VendorContact { get; set; }

    public virtual DbSet<VendorCsvMapping> VendorCsvMapping { get; set; }

    public virtual DbSet<VendorPayout> VendorPayout { get; set; }

    public virtual DbSet<VwProductExchangeHistory> VwProductExchangeHistory { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRoleClaims>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoles>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.AccesstoPos).HasColumnName("AccesstoPOS");
            entity.Property(e => e.DefaultOvertimeWage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DefaultWage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUserClaims>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogins>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserRoles>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetUserRoles).HasForeignKey(d => d.RoleId);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserRoles).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserTokens>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUsers>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Cctips).HasColumnName("CCTips");
            entity.Property(e => e.ClockInbeforeLogin).HasColumnName("ClockINBeforeLogin");
            entity.Property(e => e.CurrentCash).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Ssn).HasColumnName("SSN");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AuditLogs>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "AuditLogs_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "AuditLogs_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<BatchClose>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "BatchClose_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "BatchClose_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => e.ClosedDate, "IX_BatchClose_ClosedDate");

            entity.HasIndex(e => e.StoreId, "IX_BatchClose_StoreId");

            entity.Property(e => e.BatchNumber).HasMaxLength(50);
            entity.Property(e => e.ClosedByName).HasMaxLength(100);
            entity.Property(e => e.ClosedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EbtAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.HostBatchNumber).HasMaxLength(100);
            entity.Property(e => e.HostResponseCode).HasMaxLength(50);
            entity.Property(e => e.HostResponseMessage).HasMaxLength(500);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ButtonsConfig>(entity =>
        {
            entity.HasKey(e => e.ButtonId);

            entity.HasIndex(e => e.GlobalId, "ButtonsConfig_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ButtonsConfig_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ActionType).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Height).HasMaxLength(50);
            entity.Property(e => e.Label).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Width).HasMaxLength(50);
            entity.Property(e => e.Xpos)
                .HasMaxLength(50)
                .HasColumnName("XPos");
            entity.Property(e => e.Ypos)
                .HasMaxLength(50)
                .HasColumnName("YPos");
        });

        modelBuilder.Entity<CashDrawerLogs>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "CashDrawerLogs_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CashDrawerLogs_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Category_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Category_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ImportRef).HasMaxLength(20);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CategoryCsv>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "CategoryCsv_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CategoryCsv_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CatId).HasColumnName("Cat_ID");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Cctrans>(entity =>
        {
            entity.ToTable("CCTrans");

            entity.HasIndex(e => e.GlobalId, "CCTrans_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CCTrans_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CctransId).HasColumnName("CCTransId");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Edctype)
                .HasMaxLength(20)
                .HasColumnName("EDCType");
            entity.Property(e => e.EntryMode).HasMaxLength(20);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.PaymentMethod).HasMaxLength(4);
            entity.Property(e => e.SubType).HasMaxLength(20);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<ChoiceItems>(entity =>
        {
            entity.HasKey(e => e.ChoiceItemId);

            entity.HasIndex(e => e.GlobalId, "ChoiceItems_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ChoiceItems_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CompanyInformation>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.HasIndex(e => e.GlobalId, "CompanyInformation_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CompanyInformation_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.CommissionPrecentageonpayouts).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionPrecentageonsales).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dailylimitforwinningpayouts).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(200);
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.StoreId).HasMaxLength(200);
            entity.Property(e => e.UpperLimitforwinningpayouts).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Website).HasMaxLength(200);
            entity.Property(e => e.ZipCode).HasMaxLength(200);
        });

        modelBuilder.Entity<CustomOrder>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "CustomOrder_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CustomOrder_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerAuthorized>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "CustomerAuthorized_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CustomerAuthorized_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<CustomerLoyaltyProgram>(entity =>
        {
            entity.HasKey(e => e.CustomerLoyaltyProgramId).HasName("PK__Customer__6E76F6DC03260E54");

            entity.HasIndex(e => e.GlobalId, "CustomerLoyaltyProgram_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CustomerLoyaltyProgram_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => new { e.CustomerId, e.IsActive }, "IX_CustomerLoyaltyProgram_Customer_Active");

            entity.HasIndex(e => new { e.CustomerId, e.LoyaltyProgramId }, "UX_CustomerLoyaltyProgram_Customer_Program").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerPriceLevels>(entity =>
        {
            entity.HasKey(e => e.CustomerPriceLevelId);

            entity.HasIndex(e => e.GlobalId, "CustomerPriceLevels_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CustomerPriceLevels_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerShipTo>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "CustomerShipTo_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CustomerShipTo_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.Country).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerSwipes>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "CustomerSwipes_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "CustomerSwipes_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Customers>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.HasIndex(e => e.GlobalId, "Customers_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Customers_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => new { e.FirstName, e.LastName, e.CustomerCode, e.Email, e.Phone1, e.IsActive }, "IX_Customers_Search");

            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.BalanceDue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BillContact1).HasMaxLength(50);
            entity.Property(e => e.BillContact2).HasMaxLength(50);
            entity.Property(e => e.BonusPointAchived).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.City).HasMaxLength(200);
            entity.Property(e => e.CloseAccountDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.County).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CustomerCode).HasMaxLength(200);
            entity.Property(e => e.DaysStarting).HasColumnType("datetime");
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.IsPoentryRequired).HasColumnName("IsPOEntryRequired");
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OpenAccountDate).HasColumnType("datetime");
            entity.Property(e => e.Phone1).HasMaxLength(20);
            entity.Property(e => e.Phone2).HasMaxLength(20);
            entity.Property(e => e.ResaleNum).HasMaxLength(50);
            entity.Property(e => e.RestrictSpendingTo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.State).HasMaxLength(200);
            entity.Property(e => e.Term).HasMaxLength(50);
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<DeletedCartItem>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "DeletedCartItem_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "DeletedCartItem_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => e.CashierId, "IX_DeletedCartItem_CashierId");

            entity.HasIndex(e => e.DeletedAt, "IX_DeletedCartItem_DeletedAt");

            entity.HasIndex(e => e.StoreId, "IX_DeletedCartItem_StoreId");

            entity.Property(e => e.CashierName).HasMaxLength(150);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PricePer).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(300);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Department_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Department_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => e.CategoryId, "IX_Department_CategoryId");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ImportRef).HasMaxLength(20);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Category).WithMany(p => p.Department).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<DepartmentCsv>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "DepartmentCsv_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "DepartmentCsv_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Employee_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Employee_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfJoining).HasColumnType("datetime");
            entity.Property(e => e.DateOfRegistration).HasColumnType("datetime");
            entity.Property(e => e.EmployeeCode).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(500);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LastName).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone1).HasMaxLength(20);
            entity.Property(e => e.Phone2).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(50);
        });

        modelBuilder.Entity<EmployeeBreak>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "EmployeeBreak_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "EmployeeBreak_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => e.EmployeeClockInOutId, "IX_EmployeeBreak_EmployeeClockInOutId");

            entity.Property(e => e.BreakEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.BreakStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.EmployeeClockInOut).WithMany(p => p.EmployeeBreak).HasForeignKey(d => d.EmployeeClockInOutId);
        });

        modelBuilder.Entity<EmployeeClockinOut>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "EmployeeClockinOut_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "EmployeeClockinOut_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ClockInDateTime).HasColumnType("datetime");
            entity.Property(e => e.ClockOutDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeleteBy).HasMaxLength(500);
            entity.Property(e => e.DeleteDateTime).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.IsDelete).HasColumnName("Is_Delete");
            entity.Property(e => e.OverTimeWage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RoleId).HasMaxLength(50);
            entity.Property(e => e.RoleName).HasMaxLength(20);
            entity.Property(e => e.Wage).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<EmployeeLoginMethod>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "EmployeeLoginMethod_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "EmployeeLoginMethod_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LoginMethodType).HasMaxLength(100);
            entity.Property(e => e.PasswordOrCardData).HasMaxLength(100);
        });

        modelBuilder.Entity<EmployeeNotes>(entity =>
        {
            entity.HasKey(e => e.EmployeeNoteId);

            entity.HasIndex(e => e.GlobalId, "EmployeeNotes_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "EmployeeNotes_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ClosedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeePermission>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "EmployeePermission_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "EmployeePermission_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.IsDelete).HasColumnName("Is_Delete");
            entity.Property(e => e.IsRead).HasColumnName("Is_Read");
            entity.Property(e => e.IsWrite).HasColumnName("Is_Write");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmployeeShiftSchedule>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "EmployeeShiftSchedule_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "EmployeeShiftSchedule_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ShiftInTime).HasColumnType("datetime");
            entity.Property(e => e.ShiftOutTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ErrorLog_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ErrorLog_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<FavouriteProduct>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "FavouriteProduct_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "FavouriteProduct_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FriendlyPrinterSetup>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "FriendlyPrinterSetup_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "FriendlyPrinterSetup_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FtpConnection>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "FtpConnection_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "FtpConnection_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedBy).HasMaxLength(450);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedBy).HasMaxLength(450);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<FtpProcessedFile>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "FtpProcessedFile_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "FtpProcessedFile_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => new { e.FtpConnectionId, e.RemoteFileName }, "IX_FtpProcessedFile_Connection_FileName");

            entity.Property(e => e.CreatedBy).HasMaxLength(450);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ErrorMessage).HasMaxLength(1000);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LocalPath).HasMaxLength(500);
            entity.Property(e => e.RemoteFileName).HasMaxLength(500);
            entity.Property(e => e.RemoteModified).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<GiftCardTransactions>(entity =>
        {
            entity.HasKey(e => e.GiftCardTransactionId);

            entity.HasIndex(e => e.GlobalId, "GiftCardTransactions_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "GiftCardTransactions_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Amt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SaleTax).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<GiftCards>(entity =>
        {
            entity.HasKey(e => e.GiftCardId);

            entity.HasIndex(e => e.GlobalId, "GiftCards_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "GiftCards_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => e.CustomerId, "IX_GiftCards_CustomerId");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CardCode).HasMaxLength(200);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.OpenDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Group_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Group_StoreId_LocalId_key").IsUnique();

            entity.HasIndex(e => e.GroupCategoryId, "IX_Group_GroupCategoryId");

            entity.Property(e => e.BonusPointGroup).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductByDown).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductExtraByDown).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductGroupName).HasMaxLength(200);
            entity.Property(e => e.Productprice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductpriceYouCharge).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.GroupCategory).WithMany(p => p.Group).HasForeignKey(d => d.GroupCategoryId);
        });

        modelBuilder.Entity<GroupCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.HasIndex(e => e.GlobalId, "GroupCategory_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "GroupCategory_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GroupProduct>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "GroupProduct_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "GroupProduct_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<HotButton>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "HotButton_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "HotButton_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImportCsv>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GlobalId, "ImportCsv_GlobalId_key").IsUnique();

            entity.Property(e => e.CatId)
                .HasMaxLength(100)
                .HasColumnName("Cat_ID");
            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.CheckId).HasColumnName("Check_ID");
            entity.Property(e => e.CheckId2).HasColumnName("Check_ID2");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CountThisItem).HasColumnName("Count_This_Item");
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.DeptId)
                .HasMaxLength(100)
                .HasColumnName("Dept_ID");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.InStock)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("In_Stock");
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.ItemNum).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PrintOnReceipt).HasColumnName("Print_On_Receipt");
            entity.Property(e => e.PromptPrice).HasColumnName("Prompt_Price");
            entity.Property(e => e.PromptQuantity).HasColumnName("Prompt_Quantity");
            entity.Property(e => e.ReorderLevel)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Reorder_Level");
            entity.Property(e => e.ReorderQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Reorder_Quantity");
            entity.Property(e => e.Skus).HasColumnName("SKUS");
            entity.Property(e => e.Taxes).HasMaxLength(100);
        });

        modelBuilder.Entity<ImportTaxCsv>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.GlobalId, "ImportTaxCsv_GlobalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Tax1Name)
                .HasMaxLength(50)
                .HasColumnName("Tax1_Name");
            entity.Property(e => e.Tax1Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tax1_Rate");
            entity.Property(e => e.Tax2Name)
                .HasMaxLength(50)
                .HasColumnName("Tax2_Name");
            entity.Property(e => e.Tax2Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tax2_Rate");
            entity.Property(e => e.Tax3Name)
                .HasMaxLength(50)
                .HasColumnName("Tax3_Name");
            entity.Property(e => e.Tax3Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tax3_Rate");
            entity.Property(e => e.Tax4Name)
                .HasMaxLength(50)
                .HasColumnName("Tax4_Name");
            entity.Property(e => e.Tax4Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tax4_Rate");
            entity.Property(e => e.Tax5Name)
                .HasMaxLength(50)
                .HasColumnName("Tax5_Name");
            entity.Property(e => e.Tax5Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tax5_Rate");
            entity.Property(e => e.Tax6Name)
                .HasMaxLength(50)
                .HasColumnName("Tax6_Name");
            entity.Property(e => e.Tax6Rate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tax6_Rate");
        });

        modelBuilder.Entity<InventoryHistory>(entity =>
        {
            entity.HasKey(e => e.InentoryId);

            entity.HasIndex(e => e.GlobalId, "InventoryHistory_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InventoryHistory_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.PolineItemId).HasColumnName("POlineItemId");
            entity.Property(e => e.UnitsInStock).HasMaxLength(50);
            entity.Property(e => e.UnitsOrdered).HasMaxLength(50);
        });

        modelBuilder.Entity<InventoryPurchase>(entity =>
        {
            entity.HasKey(e => e.InventoryPurchaseId).HasName("PK__Inventor__C0B4E91F9CF2CD30");

            entity.HasIndex(e => e.GlobalId, "InventoryPurchase_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InventoryPurchase_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FintechProcessDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(100)
                .HasColumnName("PONumber");
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(1);
            entity.Property(e => e.TotalCostOrdered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCostReceived).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalUnitsOrdered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalUnitsReceived).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VendorStoreNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<InventoryPurchaseDetail>(entity =>
        {
            entity.HasKey(e => e.InventoryPurchaseDetailId).HasName("PK__Inventor__7DB0AE747808A4A3");

            entity.HasIndex(e => e.GlobalId, "InventoryPurchaseDetail_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InventoryPurchaseDetail_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CaseCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CaseUpc)
                .HasMaxLength(50)
                .HasColumnName("CaseUPC");
            entity.Property(e => e.CleanUpc)
                .HasMaxLength(50)
                .HasColumnName("CleanUPC");
            entity.Property(e => e.CostPer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DamagedQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DepositAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExtendedPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Glcode)
                .HasMaxLength(50)
                .HasColumnName("GLCode");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.MiscAdjustment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.PackUpc)
                .HasMaxLength(50)
                .HasColumnName("PackUPC");
            entity.Property(e => e.PacksPerCase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PerCase)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductClass).HasMaxLength(100);
            entity.Property(e => e.ProductDescription).HasMaxLength(500);
            entity.Property(e => e.ProductVolume).HasMaxLength(50);
            entity.Property(e => e.QtyApplied).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.QtyOrdered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.QtyReceived).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitOfMeasure).HasMaxLength(20);
            entity.Property(e => e.UnitsPerPack)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VendorPartNumber).HasMaxLength(50);
            entity.Property(e => e.VendorProductNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<InventoryTransaction>(entity =>
        {
            entity.HasKey(e => e.InventoryTransctionId);

            entity.HasIndex(e => e.GlobalId, "InventoryTransaction_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InventoryTransaction_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CostPer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Ponumber).HasColumnName("PONumber");
            entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Transtype).HasMaxLength(10);
        });

        modelBuilder.Entity<InvoiceExceptions>(entity =>
        {
            entity.HasKey(e => e.InvoiceExceptionId);

            entity.HasIndex(e => e.GlobalId, "InvoiceExceptions_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InvoiceExceptions_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<InvoiceItems>(entity =>
        {
            entity.HasKey(e => e.InvoiceItemId);

            entity.HasIndex(e => e.GlobalId, "InvoiceItems_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InvoiceItems_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ActualPricePer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AppliedDiscount).HasMaxLength(100);
            entity.Property(e => e.BonusPoints).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CostPer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CouponAppliedQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.IsMixNmatch).HasColumnName("IsMixNMatch");
            entity.Property(e => e.LineDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LineManualDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LineManualDiscountPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LineTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LineTaxExemptedAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LineTotalBeforeDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LineTotalCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ManualDiscountSuffix).HasMaxLength(50);
            entity.Property(e => e.MnmRequiredQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PricePer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PricePerBeforeDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PricePerWithoutManualDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax1Per).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax2Per).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax3Per).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax4Per).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax5Per).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax6Per).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<InvoiceOnHold>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "InvoiceOnHold_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InvoiceOnHold_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<InvoiceTotals>(entity =>
        {
            entity.HasKey(e => e.InvoiceNumber);

            entity.HasIndex(e => new { e.CustomerId, e.Status }, "IX_InvoiceTotals_CustomerId_Status");

            entity.HasIndex(e => new { e.CustomerId, e.Status }, "IX_InvoiceTotals_CustomerId_Status_CreatedDate");

            entity.HasIndex(e => e.GlobalId, "InvoiceTotals_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "InvoiceTotals_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.AcctBalanceBefore).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AcctBalanceDue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AcctFullyPaidDate).HasColumnType("datetime");
            entity.Property(e => e.AmtCaSec).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmtCaSecTendered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmtChange).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmtDeposit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmtFsamtTend)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AmtFSAmtTend");
            entity.Property(e => e.AmtFschange)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AmtFSChange");
            entity.Property(e => e.AmtTendered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CaAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CcAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CourseOrderingProgress).HasMaxLength(100);
            entity.Property(e => e.CpAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DcAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DonationAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EbtcashbenefitAmount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EBTCashbenefitAmount");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FsAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GcAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GiftCardDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GiftCardPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GrandTotalWithGc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("GrandTotalWithGC");
            entity.Property(e => e.InvType).HasMaxLength(2);
            entity.Property(e => e.LayAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ManualDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MpAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MpDiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NonTaxedSales).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OaAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OaamountLimited)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OAAmountLimited");
            entity.Property(e => e.OldBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OnlineOrderId)
                .HasMaxLength(20)
                .HasColumnName("OnlineOrderID");
            entity.Property(e => e.OpAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OrderSource).HasMaxLength(50);
            entity.Property(e => e.OrigOnHoldId).HasMaxLength(20);
            entity.Property(e => e.PaymentMethod).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(1);
            entity.Property(e => e.TaxExemptSales).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Taxed1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxedSales).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TipAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalFixedTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalGcFree).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalGcSold).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalLiability).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPriceWithGiftCard).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalTax1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax2).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax3).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax4).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax5).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTax6).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalUndiscountedSale).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ZipCode).HasMaxLength(20);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Location_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Location_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LocationName).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LogActivity>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "LogActivity_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "LogActivity_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NewValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OldValue).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<LogFields>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "LogFields_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "LogFields_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FieldFriendlyName).HasMaxLength(200);
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LogPage>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "LogPage_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "LogPage_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PageName).HasMaxLength(200);
        });

        modelBuilder.Entity<LoginHistory>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "LoginHistory_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "LoginHistory_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LoginDatetime).HasColumnType("datetime");
            entity.Property(e => e.LoginMethod).HasMaxLength(100);
            entity.Property(e => e.LogoutDatetime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Loyalty>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Loyalty_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Loyalty_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LoyaltyProgramName).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoyaltyItems>(entity =>
        {
            entity.HasKey(e => e.LoyaltyItemId);

            entity.HasIndex(e => e.LoyaltyItemId, "IX_LoyaltyItems");

            entity.HasIndex(e => e.GlobalId, "LoyaltyItems_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "LoyaltyItems_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ApplyOnQtyFc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Criteria).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.Tax1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax2).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax3).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax4).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax5).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax6).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<MergeFkRewriteLog>(entity =>
        {
            entity.HasKey(e => e.TenantId).HasName("PK__merge_fk__2E9B47E13D2E3D83");

            entity.ToTable("merge_fk_rewrite_log");

            entity.HasIndex(e => e.GlobalId, "merge_fk_rewrite_log_GlobalId_key").IsUnique();

            entity.Property(e => e.TenantId).ValueGeneratedNever();
            entity.Property(e => e.CompletedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<MixNmatch>(entity =>
        {
            entity.ToTable("MixNMatch");

            entity.HasIndex(e => e.GlobalId, "MixNMatch_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "MixNMatch_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.MixNmatchId).HasColumnName("MixNMatchId");
            entity.Property(e => e.AmountToDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerLimit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PriceGroupId).HasMaxLength(100);
            entity.Property(e => e.QtyRequired).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<MixNmatchLevel>(entity =>
        {
            entity.ToTable("MixNMatchLevel");

            entity.HasIndex(e => e.GlobalId, "MixNMatchLevel_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "MixNMatchLevel_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.MixNmatchLevelId).HasColumnName("MixNMatchLevelId");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.MixNmatchId).HasColumnName("MixNMatchId");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<MixNmatchProducts>(entity =>
        {
            entity.HasKey(e => e.MixNmatchProductId);

            entity.ToTable("MixNMatchProducts");

            entity.HasIndex(e => e.GlobalId, "MixNMatchProducts_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "MixNMatchProducts_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.MixNmatchProductId).HasColumnName("MixNMatchProductId");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.MixNmatchId).HasColumnName("MixNMatchId");
        });

        modelBuilder.Entity<MoneyActivity>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "MoneyActivity_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "MoneyActivity_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Account).HasMaxLength(10);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmtTendered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApproveAmount).HasMaxLength(10);
            entity.Property(e => e.AuthCode).HasMaxLength(50);
            entity.Property(e => e.BatchNumber).HasMaxLength(50);
            entity.Property(e => e.CardBalance).HasMaxLength(10);
            entity.Property(e => e.CardBin).HasMaxLength(10);
            entity.Property(e => e.CardHolderName).HasMaxLength(50);
            entity.Property(e => e.CardType).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EcrRefNum).HasMaxLength(20);
            entity.Property(e => e.EdcType).HasMaxLength(20);
            entity.Property(e => e.EntryMode).HasMaxLength(10);
            entity.Property(e => e.ExpiryDate).HasMaxLength(10);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.GlobalUid).HasMaxLength(50);
            entity.Property(e => e.HostRefNum).HasMaxLength(50);
            entity.Property(e => e.PaymentMethod).HasMaxLength(4);
            entity.Property(e => e.RefNum).HasMaxLength(50);
            entity.Property(e => e.Sn).HasMaxLength(50);
            entity.Property(e => e.Timestamp).HasMaxLength(20);
            entity.Property(e => e.TraceNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<OnAccountTransactionDetails>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "OnAccountTransactionDetails_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "OnAccountTransactionDetails_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Pid).HasColumnName("PId");
            entity.Property(e => e.PrevInvBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TargetStoreId).HasColumnName("targetStoreId");
        });

        modelBuilder.Entity<OnAccountTransactions>(entity =>
        {
            entity.HasKey(e => e.OnAccountTransactionId);

            entity.HasIndex(e => e.GlobalId, "OnAccountTransactions_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "OnAccountTransactions_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.AmountRemaining).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.OaAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PaymentInfo).HasMaxLength(50);
            entity.Property(e => e.PaymentMethod).HasMaxLength(4);
            entity.Property(e => e.PreviousCustBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PreviousInvBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TransactionType).HasMaxLength(4);
        });

        modelBuilder.Entity<OrderActions>(entity =>
        {
            entity.HasKey(e => e.OrderActionId);

            entity.HasIndex(e => e.GlobalId, "OrderActions_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "OrderActions_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ActionType).HasMaxLength(100);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<OrderDetails>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId);

            entity.HasIndex(e => e.GlobalId, "OrderDetails_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "OrderDetails_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DiscountType).HasMaxLength(100);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Qty).HasMaxLength(50);
        });

        modelBuilder.Entity<Orders>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.HasIndex(e => e.GlobalId, "Orders_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Orders_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus).HasMaxLength(50);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "PaymentType_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "PaymentType_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<PoleImages>(entity =>
        {
            entity.HasKey(e => e.PoleImageId);

            entity.HasIndex(e => e.GlobalId, "PoleImages_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "PoleImages_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FileType).HasMaxLength(50);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<PolineItems>(entity =>
        {
            entity.HasKey(e => e.PolineItemId);

            entity.ToTable("POLineItems");

            entity.HasIndex(e => e.GlobalId, "POLineItems_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "POLineItems_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.PolineItemId).HasColumnName("POLineItemId");
            entity.Property(e => e.CostPerUnit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Poid).HasColumnName("POId");
            entity.Property(e => e.QtyOrder).HasMaxLength(50);
            entity.Property(e => e.QtyRecevied).HasMaxLength(50);
            entity.Property(e => e.QtyReturned).HasMaxLength(50);
            entity.Property(e => e.TotalLineCost).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<PrinterSetup>(entity =>
        {
            entity.HasKey(e => e.TerminalId);

            entity.HasIndex(e => e.GlobalId, "PrinterSetup_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "PrinterSetup_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PrinterName).HasMaxLength(200);
        });

        modelBuilder.Entity<PrinterType>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "PrinterType_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "PrinterType_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(200);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId, "IX_Product_DepartmentId");

            entity.HasIndex(e => e.ProductId, "IX_Product_Inventory_Covering").IsDescending();

            entity.HasIndex(e => e.GlobalId, "Product_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Product_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Barcode).HasMaxLength(50);
            entity.Property(e => e.BonusPoints).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.InstockQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LastSoldDate).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.MixNmatchDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MixNMatchDiscount");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PackSize).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceWithTax).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductDescription).HasMaxLength(500);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");
            entity.Property(e => e.ReOrderQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.StockLocation).HasMaxLength(200);
            entity.Property(e => e.TotalSkustock).HasColumnName("TotalSKUStock");
            entity.Property(e => e.UnitSize).HasMaxLength(50);
            entity.Property(e => e.UnitType).HasMaxLength(50);

            entity.HasOne(d => d.Department).WithMany(p => p.Product).HasForeignKey(d => d.DepartmentId);
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ProductCategory_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductCategory_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<ProductCouponRules>(entity =>
        {
            entity.HasKey(e => e.InventoryCouponRuleId);

            entity.HasIndex(e => e.GlobalId, "ProductCouponRules_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductCouponRules_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<ProductCoupons>(entity =>
        {
            entity.HasKey(e => e.ProductCouponId);

            entity.HasIndex(e => e.GlobalId, "ProductCoupons_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductCoupons_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CouponBonusMinimumQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.MinimumAmountRestriction).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.QtyRestricted).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ProductCsv>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ProductCsv_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductCsv_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CountThisItem).HasColumnName("Count_This_Item");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.InStock)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("In_Stock");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrintOnReceipt).HasColumnName("Print_On_Receipt");
        });

        modelBuilder.Entity<ProductExchange>(entity =>
        {
            entity.HasKey(e => e.ProductExchangeId).HasName("PK__ProductE__D0BEED686EE9C6B1");

            entity.HasIndex(e => e.DefectiveProductId, "IX_ProductExchange_DefectiveProductId");

            entity.HasIndex(e => e.ExchangeDate, "IX_ProductExchange_ExchangeDate");

            entity.HasIndex(e => e.OriginalInvoiceNumber, "IX_ProductExchange_OriginalInvoiceNumber");

            entity.HasIndex(e => e.ReplacementProductId, "IX_ProductExchange_ReplacementProductId");

            entity.HasIndex(e => e.StoreId, "IX_ProductExchange_StoreId");

            entity.HasIndex(e => e.GlobalId, "ProductExchange_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductExchange_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DefectiveProductName).HasMaxLength(200);
            entity.Property(e => e.DefectiveProductSku)
                .HasMaxLength(50)
                .HasColumnName("DefectiveProductSKU");
            entity.Property(e => e.DefectiveQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DefectiveUnitCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.ExchangeDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeNotes).HasMaxLength(500);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReplacementProductName).HasMaxLength(200);
            entity.Property(e => e.ReplacementProductSku)
                .HasMaxLength(50)
                .HasColumnName("ReplacementProductSKU");
            entity.Property(e => e.ReplacementQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReplacementUnitCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Status).HasMaxLength(1);
        });

        modelBuilder.Entity<ProductIngredients>(entity =>
        {
            entity.HasKey(e => e.ProductIngredientId);

            entity.HasIndex(e => e.GlobalId, "ProductIngredients_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductIngredients_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Quantity).HasColumnType("decimal(25, 8)");
        });

        modelBuilder.Entity<ProductNotes>(entity =>
        {
            entity.HasKey(e => e.ProductNoteId);

            entity.HasIndex(e => e.GlobalId, "ProductNotes_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductNotes_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<ProductOnSaleInfos>(entity =>
        {
            entity.HasKey(e => e.ProductOnSaleInfoId);

            entity.HasIndex(e => e.GlobalId, "ProductOnSaleInfos_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductOnSaleInfos_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ProductPriceCustomerLevel>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ProductPriceCustomerLevel_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductPriceCustomerLevel_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<ProductPriceHistory>(entity =>
        {
            entity.HasIndex(e => e.ChangeType, "IX_ProductPriceHistory_ChangeType");

            entity.HasIndex(e => e.CreatedBy, "IX_ProductPriceHistory_CreatedBy");

            entity.HasIndex(e => e.CreatedDate, "IX_ProductPriceHistory_CreatedDate").IsDescending();

            entity.HasIndex(e => e.ProductId, "IX_ProductPriceHistory_ProductId");

            entity.HasIndex(e => e.GlobalId, "ProductPriceHistory_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductPriceHistory_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ChangeType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.NewCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.OldCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
        });

        modelBuilder.Entity<ProductPriceLevel>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ProductPriceLevel_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductPriceLevel_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Level).HasMaxLength(10);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ProductSku>(entity =>
        {
            entity.ToTable("ProductSKU");

            entity.HasIndex(e => e.GlobalId, "ProductSKU_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductSKU_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ProductSkuid).HasColumnName("ProductSKUId");
            entity.Property(e => e.AllowCountQty).HasMaxLength(50);
            entity.Property(e => e.Barcode).HasMaxLength(200);
            entity.Property(e => e.CostPer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.InStockQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
        });

        modelBuilder.Entity<ProductTax>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ProductTax_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductTax_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<ProductVendor>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ProductVendor_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ProductVendor_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CaseCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CostPer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PerCase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VendorPartNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<Properties>(entity =>
        {
            entity.HasKey(e => e.PropertyId);

            entity.HasIndex(e => e.GlobalId, "Properties_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Properties_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<PropertyDetails>(entity =>
        {
            entity.HasKey(e => e.PropertyValueId);

            entity.HasIndex(e => e.GlobalId, "PropertyDetails_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "PropertyDetails_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.Poid);

            entity.HasIndex(e => e.GlobalId, "PurchaseOrder_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "PurchaseOrder_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Poid).HasColumnName("POId");
            entity.Property(e => e.BillableDepartment).HasMaxLength(50);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Distributor).HasMaxLength(100);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderReason).HasMaxLength(100);
            entity.Property(e => e.Potype).HasColumnName("POType");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.ShipTo1).HasMaxLength(100);
            entity.Property(e => e.ShipTo2).HasMaxLength(100);
            entity.Property(e => e.ShipTo3).HasMaxLength(100);
            entity.Property(e => e.ShipTo4).HasMaxLength(100);
            entity.Property(e => e.ShipTo5).HasMaxLength(100);
            entity.Property(e => e.ShipToDestination).HasMaxLength(50);
            entity.Property(e => e.ShipVia).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(1);
            entity.Property(e => e.TotalCharges).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCostReceived).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<PurchaseOrderDetails>(entity =>
        {
            entity.HasKey(e => e.PodetailId);

            entity.HasIndex(e => e.GlobalId, "PurchaseOrderDetails_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "PurchaseOrderDetails_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.PodetailId).HasColumnName("PODetailId");
            entity.Property(e => e.CaseCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CasesOrdered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CostPer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentBatchQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DamagedQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PerCase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Poid).HasColumnName("POId");
            entity.Property(e => e.QtyApplied).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.QtyOdered).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.QtyReceived).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Reason).HasMaxLength(100);
            entity.Property(e => e.VendorPartNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ReasonCode>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ReasonCode_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ReasonCode_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReceiptSetup>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "ReceiptSetup_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ReceiptSetup_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NoOfExtraCopiesByEbt).HasColumnName("NoOfExtraCopiesByEBT");
            entity.Property(e => e.NoOfStoreCrreceipts).HasColumnName("NoOfStoreCRReceipts");
            entity.Property(e => e.PrintCc).HasColumnName("PrintCC");
            entity.Property(e => e.PrintNotesOnCc).HasColumnName("PrintNotesOnCC");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.HasIndex(e => e.Token, "IX_RefreshToken_Token");

            entity.HasIndex(e => e.UserId, "IX_RefreshToken_UserId");

            entity.HasIndex(e => e.GlobalId, "RefreshToken_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "RefreshToken_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ExpiresAt).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Token).HasMaxLength(500);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<ReportConfiguration>(entity =>
        {
            entity.HasIndex(e => new { e.ReportType, e.ActionType }, "IX_ReportConfiguration_ReportType_ActionType").IsUnique();

            entity.HasIndex(e => e.GlobalId, "ReportConfiguration_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ReportConfiguration_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReportUsageLog>(entity =>
        {
            entity.HasIndex(e => e.ClickedAt, "IX_ReportUsageLog_ClickedAt");

            entity.HasIndex(e => new { e.UserId, e.ReportType, e.ActionType }, "IX_ReportUsageLog_UserId_ReportType_ActionType");

            entity.HasIndex(e => e.GlobalId, "ReportUsageLog_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ReportUsageLog_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ClickedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.TerminalId).HasMaxLength(100);
        });

        modelBuilder.Entity<RewardPointsTransactions>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_RewardPointsTransactions_CustomerId");

            entity.HasIndex(e => e.InvoiceNumber, "IX_RewardPointsTransactions_InvoiceNumber");

            entity.HasIndex(e => e.ProductId, "IX_RewardPointsTransactions_ProductId");

            entity.HasIndex(e => e.GlobalId, "RewardPointsTransactions_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "RewardPointsTransactions_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Points).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Customer).WithMany(p => p.RewardPointsTransactions).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.InvoiceNumberNavigation).WithMany(p => p.RewardPointsTransactions).HasForeignKey(d => d.InvoiceNumber);

            entity.HasOne(d => d.Product).WithMany(p => p.RewardPointsTransactions).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<ShiftTracks>(entity =>
        {
            entity.HasKey(e => e.ShiftTrackId);

            entity.HasIndex(e => e.GlobalId, "ShiftTracks_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "ShiftTracks_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ActualCash).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AverageTrnsaction).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CashDrawerDeposit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CashSales).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpectedCash).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetSalesCoupon).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetSalesDiscount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetSalesRefund).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetSalesRegular).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OpeningCash).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShifEnd).HasColumnType("datetime");
            entity.Property(e => e.ShiftStart).HasColumnType("datetime");
            entity.Property(e => e.ShortAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCash).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCheck).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalCreditDebit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalEbt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TotalEBT");
            entity.Property(e => e.TotalOnAccount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalTransaction).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Shifts>(entity =>
        {
            entity.HasKey(e => e.ShiftId);

            entity.HasIndex(e => e.GlobalId, "Shifts_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Shifts_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CloseAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.NetSaleTaxed).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetSalesNonTaxed).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetSalesTaxExempt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OpenAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OverShot).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Tax1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax2).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax3).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax4).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax5).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax6).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<StockVarianceLog>(entity =>
        {
            entity.HasIndex(e => e.ProductId, "IX_StockVarianceLog_ProductId");

            entity.HasIndex(e => new { e.StoreId, e.FixedDate }, "IX_StockVarianceLog_StoreId_FixedDate");

            entity.HasIndex(e => e.GlobalId, "StockVarianceLog_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "StockVarianceLog_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.AdjustmentQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AdjustmentType).HasMaxLength(50);
            entity.Property(e => e.CalculatedStockBefore).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CurrentInstockQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FixedByName).HasMaxLength(100);
            entity.Property(e => e.FixedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.Variance).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Store_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Store_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.BlindRecountValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultCashDrawerStart).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DepositTypeValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Eod).HasColumnName("EOD");
            entity.Property(e => e.Eodreport).HasColumnName("EODReport");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.IsCheckIdprompt).HasColumnName("IsCheckIDPrompt");
            entity.Property(e => e.LargePurchaseAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxCashAlertLevel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxCashLockupLevel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.SkuonInvoice).HasColumnName("SKUOnInvoice");
            entity.Property(e => e.StoreName).HasMaxLength(200);
            entity.Property(e => e.TrackIncomingSn).HasColumnName("TrackIncomingSN");
            entity.Property(e => e.UseMixNmatch).HasColumnName("UseMixNMatch");
            entity.Property(e => e.Website).HasMaxLength(200);
        });

        modelBuilder.Entity<StoreDayEndDate>(entity =>
        {
            entity.HasIndex(e => e.StoreId, "IX_StoreDayEndDate_StoreId");

            entity.HasIndex(e => e.GlobalId, "StoreDayEndDate_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "StoreDayEndDate_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.Store).WithMany(p => p.StoreDayEndDate)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TaxRate>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "TaxRate_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "TaxRate_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxRateName).HasMaxLength(500);
            entity.Property(e => e.TaxRatePercent).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Terminal>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Terminal_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Terminal_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentCash).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");
            entity.Property(e => e.IsEbtoption).HasColumnName("IsEBTOption");
            entity.Property(e => e.IsHideEbt).HasColumnName("IsHideEBT");
            entity.Property(e => e.MacAddress).HasMaxLength(100);
            entity.Property(e => e.MinCashAlertLevel).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MinCashLockupLevel).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentProcess)
                .HasMaxLength(10)
                .HasDefaultValue("");
            entity.Property(e => e.PaymentTypeEbt).HasColumnName("PaymentTypeEBT");
            entity.Property(e => e.PromptEmailPo).HasColumnName("PromptEmailPO");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.StockLevelsOnTs).HasColumnName("StockLevelsOnTS");
            entity.Property(e => e.TerminalName).HasMaxLength(200);
            entity.Property(e => e.TerminalRole).HasMaxLength(50);
        });

        modelBuilder.Entity<TerminalCashLogs>(entity =>
        {
            entity.HasKey(e => e.TeminalCashLogId);

            entity.HasIndex(e => e.GlobalId, "TerminalCashLogs_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "TerminalCashLogs_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<TouchScreenSetup>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "TouchScreenSetup_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "TouchScreenSetup_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.HiddenFromTs).HasColumnName("HiddenFromTS");
            entity.Property(e => e.HideRiquantityBox).HasColumnName("HideRIQuantityBox");
            entity.Property(e => e.HideRiquantityButton).HasColumnName("HideRIQuantityButton");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StocksLevelsOnTs).HasColumnName("StocksLevelsOnTS");
        });

        modelBuilder.Entity<UserReportQuota>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.ReportType }, "IX_UserReportQuota_UserId_ReportType").IsUnique();

            entity.HasIndex(e => e.GlobalId, "UserReportQuota_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "UserReportQuota_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedBy).HasMaxLength(450);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModifiedBy).HasMaxLength(450);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "Vendor_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "Vendor_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.BillableDepartment).HasMaxLength(200);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Comission).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CompanyName).HasMaxLength(200);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Einnumber)
                .HasMaxLength(200)
                .HasColumnName("EINNumber");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FlatRentRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MinimumOrder).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.TaxId).HasMaxLength(200);
            entity.Property(e => e.TelephoneNumber).HasMaxLength(50);
            entity.Property(e => e.Terms).HasMaxLength(200);
            entity.Property(e => e.VendorNumber).HasMaxLength(200);
            entity.Property(e => e.Website).HasMaxLength(200);
            entity.Property(e => e.Zip).HasMaxLength(100);
        });

        modelBuilder.Entity<VendorContact>(entity =>
        {
            entity.HasIndex(e => e.GlobalId, "VendorContact_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "VendorContact_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone1).HasMaxLength(20);
            entity.Property(e => e.Phone2).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(20);
            entity.Property(e => e.Website).HasMaxLength(100);
        });

        modelBuilder.Entity<VendorCsvMapping>(entity =>
        {
            entity.HasKey(e => e.VendorCsvMappingId).HasName("PK__VendorCs__4CFFE328A8E27671");

            entity.HasIndex(e => e.GlobalId, "VendorCsvMapping_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "VendorCsvMapping_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.ColCaseUpc)
                .HasMaxLength(100)
                .HasColumnName("ColCaseUPC");
            entity.Property(e => e.ColCleanUpc)
                .HasMaxLength(100)
                .HasColumnName("ColCleanUPC");
            entity.Property(e => e.ColCostPer).HasMaxLength(100);
            entity.Property(e => e.ColDeliveryAdjustment).HasMaxLength(100);
            entity.Property(e => e.ColDepositAdjustment).HasMaxLength(100);
            entity.Property(e => e.ColDiscountAmount).HasMaxLength(100);
            entity.Property(e => e.ColDueDate).HasMaxLength(100);
            entity.Property(e => e.ColExtendedPrice).HasMaxLength(100);
            entity.Property(e => e.ColGlcode)
                .HasMaxLength(100)
                .HasColumnName("ColGLCode");
            entity.Property(e => e.ColInvoiceAmount).HasMaxLength(100);
            entity.Property(e => e.ColInvoiceDate).HasMaxLength(100);
            entity.Property(e => e.ColInvoiceItemCount).HasMaxLength(100);
            entity.Property(e => e.ColInvoiceNumber).HasMaxLength(100);
            entity.Property(e => e.ColMiscAdjustment).HasMaxLength(100);
            entity.Property(e => e.ColPackUpc)
                .HasMaxLength(100)
                .HasColumnName("ColPackUPC");
            entity.Property(e => e.ColPacksPerCase).HasMaxLength(100);
            entity.Property(e => e.ColPonumber)
                .HasMaxLength(100)
                .HasColumnName("ColPONumber");
            entity.Property(e => e.ColProcessDate).HasMaxLength(100);
            entity.Property(e => e.ColProductClass).HasMaxLength(100);
            entity.Property(e => e.ColProductDescription).HasMaxLength(100);
            entity.Property(e => e.ColProductNumber).HasMaxLength(100);
            entity.Property(e => e.ColProductVolume).HasMaxLength(100);
            entity.Property(e => e.ColQuantity).HasMaxLength(100);
            entity.Property(e => e.ColRetailerStoreNumber).HasMaxLength(100);
            entity.Property(e => e.ColTaxAmount).HasMaxLength(100);
            entity.Property(e => e.ColUnitOfMeasure).HasMaxLength(100);
            entity.Property(e => e.ColUnitsPerPack).HasMaxLength(100);
            entity.Property(e => e.ColVendorName).HasMaxLength(100);
            entity.Property(e => e.ColVendorStoreNumber).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.MappingName).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VendorPayout>(entity =>
        {
            entity.HasIndex(e => e.PaymentTypeId, "IX_VendorPayout_PaymentTypeId");

            entity.HasIndex(e => e.TerminalId, "IX_VendorPayout_TerminalId");

            entity.HasIndex(e => e.VendorId, "IX_VendorPayout_VendorId");

            entity.HasIndex(e => e.GlobalId, "VendorPayout_GlobalId_key").IsUnique();

            entity.HasIndex(e => new { e.StoreId, e.LocalId }, "VendorPayout_StoreId_LocalId_key").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GlobalId).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Reason).HasMaxLength(255);

            entity.HasOne(d => d.PaymentType).WithMany(p => p.VendorPayout).HasForeignKey(d => d.PaymentTypeId);

            entity.HasOne(d => d.Terminal).WithMany(p => p.VendorPayout).HasForeignKey(d => d.TerminalId);

            entity.HasOne(d => d.Vendor).WithMany(p => p.VendorPayout).HasForeignKey(d => d.VendorId);
        });

        modelBuilder.Entity<VwProductExchangeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ProductExchangeHistory");

            entity.Property(e => e.CashierName).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(401);
            entity.Property(e => e.DefectiveProductName).HasMaxLength(200);
            entity.Property(e => e.DefectiveProductSku)
                .HasMaxLength(50)
                .HasColumnName("DefectiveProductSKU");
            entity.Property(e => e.DefectiveQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DefectiveUnitCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ExchangeDate).HasColumnType("datetime");
            entity.Property(e => e.ExchangeNotes).HasMaxLength(500);
            entity.Property(e => e.ReplacementProductName).HasMaxLength(200);
            entity.Property(e => e.ReplacementProductSku)
                .HasMaxLength(50)
                .HasColumnName("ReplacementProductSKU");
            entity.Property(e => e.ReplacementQuantity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReplacementUnitCost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Status).HasMaxLength(1);
            entity.Property(e => e.StatusLabel)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.StoreName).HasMaxLength(200);
            entity.Property(e => e.TerminalName).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
