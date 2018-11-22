using Amtrack.StockCheck.Data.Data;
using Microsoft.EntityFrameworkCore;


namespace Amtrack.StockCheck.Data
{
	public partial class AmtrackStockCheckContext : DbContext
	{
		public AmtrackStockCheckContext()
		{
		}

		public AmtrackStockCheckContext(DbContextOptions<AmtrackStockCheckContext> options)
			: base(options)
		{
		}

		public virtual DbSet<AccountManagers> AccountManagers { get; set; }
		public virtual DbSet<AccountManagerSwitch> AccountManagerSwitch { get; set; }
		public virtual DbSet<ActiveSkus> ActiveSkus { get; set; }
		public virtual DbSet<AdstockItemBranchAttributes> AdstockItemBranchAttributes { get; set; }
		public virtual DbSet<AudStAllocateStock> AudStAllocateStock { get; set; }
		public virtual DbSet<AudStGetOrderPickedQuantities> AudStGetOrderPickedQuantities { get; set; }
		public virtual DbSet<AudWmsDocumentFlags> AudWmsDocumentFlags { get; set; }
		public virtual DbSet<BasketMetaData> BasketMetaData { get; set; }
		public virtual DbSet<BrandingDiscountCodes> BrandingDiscountCodes { get; set; }
		public virtual DbSet<BrandingDiscountRules> BrandingDiscountRules { get; set; }
		public virtual DbSet<BrandingDiscounts> BrandingDiscounts { get; set; }
		public virtual DbSet<BrandingExceptions> BrandingExceptions { get; set; }
		public virtual DbSet<BrandingExcludeStock> BrandingExcludeStock { get; set; }
		public virtual DbSet<BrandingOptioncolourRestrictions> BrandingOptioncolourRestrictions { get; set; }
		public virtual DbSet<BrandingPositionDetail> BrandingPositionDetail { get; set; }
		public virtual DbSet<BrandingPositionOptions> BrandingPositionOptions { get; set; }
		public virtual DbSet<BrandingPositions> BrandingPositions { get; set; }
		public virtual DbSet<BrandingTracking> BrandingTracking { get; set; }
		public virtual DbSet<BsFailedMrntransactions> BsFailedMrntransactions { get; set; }
		public virtual DbSet<CategoryTypes> CategoryTypes { get; set; }
		public virtual DbSet<ContinuingProducts2017> ContinuingProducts2017 { get; set; }
		public virtual DbSet<ExWebCatalogue> ExWebCatalogue { get; set; }
		public virtual DbSet<ExWebCatalogueHierarchy> ExWebCatalogueHierarchy { get; set; }
		public virtual DbSet<ExWebCategories> ExWebCategories { get; set; }
		public virtual DbSet<HighValue> HighValue { get; set; }
		public virtual DbSet<IncomingEtacache> IncomingEtacache { get; set; }
		public virtual DbSet<InventoryAdditionalAttributes> InventoryAdditionalAttributes { get; set; }
		public virtual DbSet<InventoryBrandDepartmentInkAttributes> InventoryBrandDepartmentInkAttributes { get; set; }
		public virtual DbSet<InventoryClasification> InventoryClasification { get; set; }
		public virtual DbSet<InventoryColourAttributes> InventoryColourAttributes { get; set; }
		public virtual DbSet<InventoryPackagingDetail> InventoryPackagingDetail { get; set; }
		public virtual DbSet<InventoryPart> InventoryPart { get; set; }
		public virtual DbSet<InventoryPartsMaster> InventoryPartsMaster { get; set; }
		public virtual DbSet<InventorySet> InventorySet { get; set; }
		public virtual DbSet<InventorySizeAttributes> InventorySizeAttributes { get; set; }
		public virtual DbSet<InventorySupplement> InventorySupplement { get; set; }
		public virtual DbSet<ItemAdditionalInfo> ItemAdditionalInfo { get; set; }
		public virtual DbSet<KitProducts> KitProducts { get; set; }
		public virtual DbSet<NonConveyourable> NonConveyourable { get; set; }
		public virtual DbSet<PickingTracking> PickingTracking { get; set; }
		public virtual DbSet<ProductBranding> ProductBranding { get; set; }
		public virtual DbSet<Promotion> Promotion { get; set; }
		public virtual DbSet<PromotionItems> PromotionItems { get; set; }
		public virtual DbSet<PsAccountMasterSubLookup> PsAccountMasterSubLookup { get; set; }
		public virtual DbSet<RackSlotClassification> RackSlotClassification { get; set; }
		public virtual DbSet<RackSlotClassificationTracking> RackSlotClassificationTracking { get; set; }
		public virtual DbSet<RackSlotInfo> RackSlotInfo { get; set; }
		public virtual DbSet<SizeSwatch> SizeSwatch { get; set; }
		public virtual DbSet<SpecialApplicableProducts> SpecialApplicableProducts { get; set; }
		public virtual DbSet<SpecialFreeBrandingCodesLookUp> SpecialFreeBrandingCodesLookUp { get; set; }
		public virtual DbSet<Specials> Specials { get; set; }
		public virtual DbSet<SpecialsBrandingDetails> SpecialsBrandingDetails { get; set; }
		public virtual DbSet<SpecialsTypes> SpecialsTypes { get; set; }
		public virtual DbSet<StockBrands> StockBrands { get; set; }
		public virtual DbSet<StockCartonAttributes> StockCartonAttributes { get; set; }
		public virtual DbSet<StockCategoryAttributes> StockCategoryAttributes { get; set; }
		public virtual DbSet<StockEmbroideryPricing> StockEmbroideryPricing { get; set; }
		public virtual DbSet<StockInventoryTransactionTypes> StockInventoryTransactionTypes { get; set; }
		public virtual DbSet<StockItemAttributes> StockItemAttributes { get; set; }
		public virtual DbSet<StockItemAttributeTemplateOptionValues> StockItemAttributeTemplateOptionValues { get; set; }
		public virtual DbSet<StockItemAttributeTemplates> StockItemAttributeTemplates { get; set; }
		public virtual DbSet<StockItemBranchAttributes> StockItemBranchAttributes { get; set; }
		public virtual DbSet<StockItemBranchShippingMethods> StockItemBranchShippingMethods { get; set; }
		public virtual DbSet<StockItemBrandMatrix> StockItemBrandMatrix { get; set; }
		public virtual DbSet<StockItemCosts> StockItemCosts { get; set; }
		public virtual DbSet<StockItemGroupAttributes> StockItemGroupAttributes { get; set; }
		public virtual DbSet<StockItemGroupAttributeTemplates> StockItemGroupAttributeTemplates { get; set; }
		public virtual DbSet<StockItemGroups> StockItemGroups { get; set; }
		public virtual DbSet<StockItemInventoryTypes> StockItemInventoryTypes { get; set; }
		public virtual DbSet<StockItemLevel> StockItemLevel { get; set; }
		public virtual DbSet<StockItemLevelDetail> StockItemLevelDetail { get; set; }
		public virtual DbSet<StockItemLevelDetailType> StockItemLevelDetailType { get; set; }
		public virtual DbSet<StockItemLevelIncomingDetails> StockItemLevelIncomingDetails { get; set; }
		public virtual DbSet<StockItemLevelReserveDetails> StockItemLevelReserveDetails { get; set; }
		public virtual DbSet<StockItemLevelSource> StockItemLevelSource { get; set; }
		public virtual DbSet<StockItemLevelTransactions> StockItemLevelTransactions { get; set; }
		public virtual DbSet<StockItemMaster> StockItemMaster { get; set; }
		public virtual DbSet<StockItemPriceMatrix> StockItemPriceMatrix { get; set; }
		public virtual DbSet<StockItemPublication> StockItemPublication { get; set; }
		public virtual DbSet<StockItemPublicationTransactions> StockItemPublicationTransactions { get; set; }
		public virtual DbSet<StockItemShippingMethods> StockItemShippingMethods { get; set; }
		public virtual DbSet<StockItemTransactionResults> StockItemTransactionResults { get; set; }
		public virtual DbSet<StockItemUom> StockItemUom { get; set; }
		public virtual DbSet<StockItemUomtemplates> StockItemUomtemplates { get; set; }
		public virtual DbSet<StockItemUomvalues> StockItemUomvalues { get; set; }
		public virtual DbSet<StockItemValidation> StockItemValidation { get; set; }
		public virtual DbSet<StockItemValidationTransactions> StockItemValidationTransactions { get; set; }
		public virtual DbSet<StockPalletAudit> StockPalletAudit { get; set; }
		public virtual DbSet<StockPalletAudit1> StockPalletAudit1 { get; set; }
		public virtual DbSet<StockPallets> StockPallets { get; set; }
		public virtual DbSet<StockPallets2> StockPallets2 { get; set; }
		public virtual DbSet<StockPricelists> StockPricelists { get; set; }
		public virtual DbSet<StockRelatedProducts> StockRelatedProducts { get; set; }
		public virtual DbSet<StockSetComponents> StockSetComponents { get; set; }
		public virtual DbSet<StockSetContents> StockSetContents { get; set; }
		public virtual DbSet<StockSets> StockSets { get; set; }
		public virtual DbSet<StockSetStockcheck> StockSetStockcheck { get; set; }
		public virtual DbSet<StockStItemLoadCatalogueCh1> StockStItemLoadCatalogueCh1 { get; set; }
		public virtual DbSet<StockStockGpe> StockStockGpe { get; set; }
		public virtual DbSet<StockToDelete> StockToDelete { get; set; }
		public virtual DbSet<StockVirtualStockLookup> StockVirtualStockLookup { get; set; }
		public virtual DbSet<StockVolumetric> StockVolumetric { get; set; }
		public virtual DbSet<StockVolumetricBatches> StockVolumetricBatches { get; set; }
		public virtual DbSet<StockWmsChange> StockWmsChange { get; set; }
		public virtual DbSet<TempInclusiveBrandingOptions> TempInclusiveBrandingOptions { get; set; }
		public virtual DbSet<TStockAttributes> TStockAttributes { get; set; }
		public virtual DbSet<UtiMrndata> UtiMrndata { get; set; }
		public virtual DbSet<UtiMrndata1> UtiMrndata1 { get; set; }
		public virtual DbSet<UtiMrntransactions> UtiMrntransactions { get; set; }
		public virtual DbSet<UtiMrntransactions1> UtiMrntransactions1 { get; set; }

		// Unable to generate entity type for table 'dbo.UP_BrandingConversionBrandingCredits_NEW'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.BrandingPrices'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.expStock'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stock_StockCheck'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ColourSort'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.SizeSort'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.BrandingClothingLinesTypes'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.WidgetCH_Accounts'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.Stock_wms_BinLocations'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionBrandings'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionBrandingCredits'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stock_Prices'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.DailyStats_WarehouseStockLevels'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.temp_wizardImportBranding'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionData'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stock_StockItems_2'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.WidgetCH_JobCards'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._Sets'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.temp_wizarddims'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.DeleteMe_ItemPages'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._PageNumbersImport'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.auGiftsetStockLevel_Trigger'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.temp_ClothingAttributes'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stock_StockItems'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.temp_Attributes'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stStockLevel'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionBrandings_NEW'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.BrandingConversionBranding'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.calc_GiftSalesQuantityBySize'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.calc_ClothingSalesQuantityBySize'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionStockCredits_NEW'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stock_UnProcessedPurchaseOrders'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionData_NEW'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.BrandingConversionBrandingCredits'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionStock_NEW'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.BrandingConversionStock'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.BrandingConversionStockCredits'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionStockCredits'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UP_BrandingConversionStock'. Please see the warning messages.

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer("server=ACG-SERV-TST2\\ACTST5;database=Amtrack_StockCheck;uid=sa;pwd=F15HP@15T;Max Pool Size=300;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountManagers>(entity =>
			{
				entity.HasKey(e => e.Guid);

				entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

				entity.Property(e => e.AccountManagerCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Cell)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.DirectLine)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AccountManagerSwitch>(entity =>
			{
				entity.HasKey(e => e.CustomerCode);

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(6)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.CurrentSalesManCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.SalesManCode)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ActiveSkus>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("_ActiveSKUs");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<AdstockItemBranchAttributes>(entity =>
			{
				entity.ToTable("adstock_ItemBranchAttributes");

				entity.Property(e => e.Action)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.ActionDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.InboundTariffCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AudStAllocateStock>(entity =>
			{
				entity.ToTable("aud_stAllocateStock");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Originator)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Reference)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Reference2).IsUnicode(false);

				entity.Property(e => e.SourceCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AudStGetOrderPickedQuantities>(entity =>
			{
				entity.ToTable("aud_stGetOrderPickedQuantities");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Flags).HasDefaultValueSql("((0))");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.WmsDocumentNumber)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AudWmsDocumentFlags>(entity =>
			{
				entity.ToTable("aud_WmsDocumentFlags");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.WmsDocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BasketMetaData>(entity =>
			{
				entity.HasKey(e => e.LocationId);

				entity.Property(e => e.LocationId).ValueGeneratedNever();

				entity.Property(e => e.BasketCurrentLevelPc).HasColumnName("BasketCurrentLevelPC");

				entity.Property(e => e.BasketSplit)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.BasketStockItem)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.LocationName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BrandingDiscountCodes>(entity =>
			{
				entity.HasIndex(e => new { e.BrandingCode, e.ProductCode })
					.HasName("IX_BrandingDiscountCodes_BrandingCode_ProductCode")
					.IsUnique();

				entity.Property(e => e.BrandingCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Comment)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ProductCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BrandingDiscountRules>(entity =>
			{
				entity.HasIndex(e => new { e.BrandingCode, e.PositionNo, e.ItemCode })
					.HasName("IX_BrandingDiscountRules_BrandingCode_PositionNo_ItemCode")
					.IsUnique();

				entity.Property(e => e.BrandingCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.NewBrandingCode)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.ProjectCode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Scount).HasColumnName("SCount");
			});

			modelBuilder.Entity<BrandingDiscounts>(entity =>
			{
				entity.HasKey(e => e.PriceListName);

				entity.Property(e => e.PriceListName)
					.HasMaxLength(255)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<BrandingExceptions>(entity =>
			{
				entity.HasKey(e => new { e.ItemCode, e.BrandingGuid, e.Colours });

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BrandingExcludeStock>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(15)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<BrandingOptioncolourRestrictions>(entity =>
			{
				entity.Property(e => e.Colour)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.FkOptionId).HasColumnName("FK_OptionId");

				entity.HasOne(d => d.FkOption)
					.WithMany(p => p.BrandingOptioncolourRestrictions)
					.HasForeignKey(d => d.FkOptionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingOptioncolourRestrictions_BrandingPositionOptions");
			});

			modelBuilder.Entity<BrandingPositionDetail>(entity =>
			{
				entity.HasIndex(e => new { e.FkPositionId, e.BrandingCode })
					.HasName("IX_BrandingPositionDetail")
					.IsUnique();

				entity.Property(e => e.BrandingCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BrandingName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkPositionId).HasColumnName("FK_PositionId");

				entity.HasOne(d => d.FkPosition)
					.WithMany(p => p.BrandingPositionDetail)
					.HasForeignKey(d => d.FkPositionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingPositionDetail_BrandingPositions");
			});

			modelBuilder.Entity<BrandingPositionOptions>(entity =>
			{
				entity.Property(e => e.Comment)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkPositionId).HasColumnName("FK_PositionId");

				entity.Property(e => e.MaxBrandQuantity).HasDefaultValueSql("((-1))");

				entity.Property(e => e.MinBrandQuantity).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.FkPosition)
					.WithMany(p => p.BrandingPositionOptions)
					.HasForeignKey(d => d.FkPositionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingPositionOptions_BrandingPositions");
			});

			modelBuilder.Entity<BrandingPositions>(entity =>
			{
				entity.HasIndex(e => new { e.Code, e.ItemCode })
					.HasName("UK_ItemBrandingPosition")
					.IsUnique();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(1)
					.IsUnicode(false);

				entity.Property(e => e.Comment)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BrandingTracking>(entity =>
			{
				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BsFailedMrntransactions>(entity =>
			{
				entity.ToTable("bsFailedMRNTransactions");

				entity.Property(e => e.BoelineNumber).HasColumnName("BOELineNumber");

				entity.Property(e => e.Boenumber)
					.HasColumnName("BOENumber")
					.HasMaxLength(30)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Reason)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

				entity.Property(e => e.WorkType)
					.HasColumnName("WORK_TYPE")
					.HasMaxLength(25)
					.IsUnicode(false);

				entity.Property(e => e.WorkUnit)
					.HasColumnName("WORK_UNIT")
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CategoryTypes>(entity =>
			{
				entity.HasKey(e => e.CategoryCode);

				entity.Property(e => e.CategoryCode).ValueGeneratedNever();
			});

			modelBuilder.Entity<ContinuingProducts2017>(entity =>
			{
				entity.HasKey(e => e.BaseItemCode);

				entity.ToTable("_continuingProducts2017");

				entity.Property(e => e.BaseItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<ExWebCatalogue>(entity =>
			{
				entity.ToTable("exWebCatalogue");

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.CompanyCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.Description).HasColumnType("text");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(4000)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ExWebCatalogueHierarchy>(entity =>
			{
				entity.HasKey(e => new { e.FkProductId, e.FkCategoryId, e.CompanyCode });

				entity.ToTable("exWebCatalogueHierarchy");

				entity.Property(e => e.FkProductId).HasColumnName("FK_ProductId");

				entity.Property(e => e.FkCategoryId).HasColumnName("FK_CategoryId");

				entity.Property(e => e.CompanyCode)
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ExWebCategories>(entity =>
			{
				entity.ToTable("exWebCategories");

				entity.Property(e => e.CompanyCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.FkParentId).HasColumnName("FK_ParentId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<HighValue>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("_HighValue");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<IncomingEtacache>(entity =>
			{
				entity.HasKey(e => e.DocLineId);

				entity.ToTable("IncomingETACache");

				entity.Property(e => e.DocLineId).ValueGeneratedNever();

				entity.Property(e => e.Etacurrent)
					.HasColumnName("ETACurrent")
					.HasColumnType("date");

				entity.Property(e => e.Etanotification)
					.HasColumnName("ETANotification")
					.HasColumnType("date");

				entity.Property(e => e.Etaprevious)
					.HasColumnName("ETAPrevious")
					.HasColumnType("date");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Ponumber)
					.IsRequired()
					.HasColumnName("PONumber")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SubPonumber)
					.IsRequired()
					.HasColumnName("SubPONumber")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InventoryAdditionalAttributes>(entity =>
			{
				entity.HasKey(e => new { e.ItemCode, e.AttribureName, e.ProductAttributeSize });

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.AttribureName)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.ProductAttributeSize)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.AttributeValue)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.AttributeValueText).IsUnicode(false);

				entity.Property(e => e.SyncDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<InventoryBrandDepartmentInkAttributes>(entity =>
			{
				entity.HasKey(e => new { e.ItemCode, e.BrandingPosition, e.PrintDepartment });

				entity.Property(e => e.ItemCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.BrandingPosition)
					.HasMaxLength(1)
					.IsUnicode(false);

				entity.Property(e => e.CuringMethod)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Hardner)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Ink)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Material)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Primer)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Reduser)
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InventoryClasification>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(15)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<InventoryColourAttributes>(entity =>
			{
				entity.HasKey(e => e.ColourCode);

				entity.Property(e => e.ColourCode)
					.HasMaxLength(8)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.ColourDisplay)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.ColourHex)
					.HasColumnName("ColourHEX")
					.HasMaxLength(7)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InventoryPackagingDetail>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(15)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.CartonDimension)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("('N/a')");
			});

			modelBuilder.Entity<InventoryPart>(entity =>
			{
				entity.Property(e => e.FkMasterId).HasColumnName("FK_MasterId");

				entity.Property(e => e.FkSetId).HasColumnName("FK_SetId");

				entity.Property(e => e.Part)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkMaster)
					.WithMany(p => p.InventoryPart)
					.HasForeignKey(d => d.FkMasterId)
					.HasConstraintName("FK_InventoryPart_InventoryPartsMaster");

				entity.HasOne(d => d.FkSet)
					.WithMany(p => p.InventoryPart)
					.HasForeignKey(d => d.FkSetId)
					.HasConstraintName("FK_InventoryPart_InventorySet");
			});

			modelBuilder.Entity<InventoryPartsMaster>(entity =>
			{
				entity.Property(e => e.FkSetId).HasColumnName("FK_SetId");

				entity.Property(e => e.Lookup)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.PartBase)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.HasOne(d => d.FkSet)
					.WithMany(p => p.InventoryPartsMaster)
					.HasForeignKey(d => d.FkSetId)
					.HasConstraintName("FK_InventoryPartsMaster_InventorySet");
			});

			modelBuilder.Entity<InventorySet>(entity =>
			{
				entity.Property(e => e.Lookup)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InventorySizeAttributes>(entity =>
			{
				entity.HasKey(e => e.SizeCode);

				entity.Property(e => e.SizeCode)
					.HasMaxLength(8)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.SizeDisplay)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InventorySupplement>(entity =>
			{
				entity.Property(e => e.FkMasterId).HasColumnName("FK_MasterId");

				entity.Property(e => e.FkSetId).HasColumnName("FK_SetId");

				entity.Property(e => e.Supplement)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.HasOne(d => d.FkMaster)
					.WithMany(p => p.InventorySupplement)
					.HasForeignKey(d => d.FkMasterId)
					.HasConstraintName("FK_InventorySupplement_InventoryPartsMaster");

				entity.HasOne(d => d.FkSet)
					.WithMany(p => p.InventorySupplement)
					.HasForeignKey(d => d.FkSetId)
					.HasConstraintName("FK_InventorySupplement_InventorySet");
			});

			modelBuilder.Entity<ItemAdditionalInfo>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(15)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.DetailComments).IsUnicode(false);
			});

			modelBuilder.Entity<KitProducts>(entity =>
			{
				entity.HasKey(e => new { e.MasterCode, e.ItemCode, e.ColourCode });

				entity.Property(e => e.MasterCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.ColourCode)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<NonConveyourable>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("_NonConveyourable");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<PickingTracking>(entity =>
			{
				entity.Property(e => e.AdjustReason)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.AdtionDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Qc).HasColumnName("QC");

				entity.Property(e => e.WarehouseCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ProductBranding>(entity =>
			{
				entity.HasKey(e => new { e.ProductCode, e.BrandingGuid, e.Sequence });

				entity.Property(e => e.ProductCode)
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Promotion>(entity =>
			{
				entity.HasIndex(e => e.Name)
					.HasName("IX_Promotions")
					.IsUnique();

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Path)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ValidFrom).HasColumnType("datetime");

				entity.Property(e => e.ValidTo).HasColumnType("datetime");
			});

			modelBuilder.Entity<PromotionItems>(entity =>
			{
				entity.HasKey(e => new { e.PromotionId, e.ItemCode });

				entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(15)
					.IsUnicode(false);
			});

			modelBuilder.Entity<PsAccountMasterSubLookup>(entity =>
			{
				entity.HasKey(e => new { e.ParentAccountNumber, e.ChildAccountNumber });

				entity.ToTable("PS_AccountMasterSubLookup");

				entity.Property(e => e.ParentAccountNumber)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.ChildAccountNumber)
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<RackSlotClassification>(entity =>
			{
				entity.HasIndex(e => new { e.Type, e.UnitsPerLocation, e.MezzLevel, e.ItemCode })
					.HasName("IX_RackSlotClassification_ItemCode");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Hi).HasColumnName("HI");

				entity.Property(e => e.IsChecked).HasColumnName("isChecked");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Ti).HasColumnName("TI");

				entity.Property(e => e.WeightKgperLocation).HasColumnName("WeightKGPerLocation");
			});

			modelBuilder.Entity<RackSlotClassificationTracking>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkRackSlotClassificationId).HasColumnName("FK_RackSlotClassificationId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.NewBoxesPerLocation).HasColumnName("New_BoxesPerLocation");

				entity.Property(e => e.NewCartonQty).HasColumnName("New_CartonQty");

				entity.Property(e => e.NewHi).HasColumnName("New_HI");

				entity.Property(e => e.NewMezzLevel).HasColumnName("New_MezzLevel");

				entity.Property(e => e.NewTi).HasColumnName("New_TI");

				entity.Property(e => e.NewType).HasColumnName("New_Type");

				entity.Property(e => e.NewUnitsPerLocation).HasColumnName("New_UnitsPerLocation");

				entity.Property(e => e.NewWeightKgperLocation).HasColumnName("New_WeightKGPerLocation");

				entity.Property(e => e.OldBoxesPerLocation).HasColumnName("Old_BoxesPerLocation");

				entity.Property(e => e.OldCartonQty).HasColumnName("Old_CartonQty");

				entity.Property(e => e.OldHi).HasColumnName("Old_HI");

				entity.Property(e => e.OldMezzLevel).HasColumnName("Old_MezzLevel");

				entity.Property(e => e.OldTi).HasColumnName("Old_TI");

				entity.Property(e => e.OldType).HasColumnName("Old_Type");

				entity.Property(e => e.OldUnitsPerLocation).HasColumnName("Old_UnitsPerLocation");

				entity.Property(e => e.OldWeightKgperLocation).HasColumnName("Old_WeightKGPerLocation");
			});

			modelBuilder.Entity<RackSlotInfo>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PalletHeightCm).HasColumnName("PalletHeight_cm");

				entity.Property(e => e.ProdHeightCm).HasColumnName("ProdHeight_cm");

				entity.Property(e => e.SlotDepthCm).HasColumnName("SlotDepth_cm");

				entity.Property(e => e.SlotHeightCm).HasColumnName("SlotHeight_cm");

				entity.Property(e => e.SlotWidthCm).HasColumnName("SlotWidth_cm");
			});

			modelBuilder.Entity<SizeSwatch>(entity =>
			{
				entity.HasKey(e => e.Code);

				entity.Property(e => e.Code)
					.HasMaxLength(50)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.CorrectCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<SpecialApplicableProducts>(entity =>
			{
				entity.HasIndex(e => new { e.ItemCode, e.ColorCode, e.FkSpecialId })
					.HasName("IX_SpecialApplicableProducts")
					.IsUnique();

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.ColorCode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkSpecialId).HasColumnName("FK_SpecialId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.HasOne(d => d.FkSpecial)
					.WithMany(p => p.SpecialApplicableProducts)
					.HasForeignKey(d => d.FkSpecialId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SpecialApplicableProducts_Specials");
			});

			modelBuilder.Entity<SpecialFreeBrandingCodesLookUp>(entity =>
			{
				entity.HasIndex(e => new { e.BrandingCode, e.Position, e.Flags })
					.HasName("IX_SpecialFreeBrandingCodesLookUp_1")
					.IsUnique();

				entity.Property(e => e.BrandingCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ReplacementCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Specials>(entity =>
			{
				entity.HasIndex(e => e.Name)
					.HasName("IX_Specials")
					.IsUnique();

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ValidFrom).HasColumnType("datetime");

				entity.Property(e => e.ValidTo).HasColumnType("datetime");

				entity.HasOne(d => d.TypeNavigation)
					.WithMany(p => p.Specials)
					.HasForeignKey(d => d.Type)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Specials_SpecialsTypes");
			});

			modelBuilder.Entity<SpecialsBrandingDetails>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.BrandingMethod)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.BrandingReplacementCode)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkSpecialId).HasColumnName("FK_SpecialId");

				entity.HasOne(d => d.FkSpecial)
					.WithMany(p => p.SpecialsBrandingDetails)
					.HasForeignKey(d => d.FkSpecialId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SpecialsBrandingDetails_Specials");
			});

			modelBuilder.Entity<SpecialsTypes>(entity =>
			{
				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockBrands>(entity =>
			{
				entity.ToTable("stock_Brands");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockCartonAttributes>(entity =>
			{
				entity.HasKey(e => new { e.BaseItemCode, e.ItemCode });

				entity.ToTable("stock_CartonAttributes");

				entity.Property(e => e.BaseItemCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.CartonDimensions)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DimDepth).HasColumnName("dimDepth");

				entity.Property(e => e.DimHeight).HasColumnName("dimHeight");

				entity.Property(e => e.DimWidth).HasColumnName("dimWidth");
			});

			modelBuilder.Entity<StockCategoryAttributes>(entity =>
			{
				entity.HasKey(e => e.CategoryCode);

				entity.ToTable("stock_CategoryAttributes");

				entity.Property(e => e.CategoryCode)
					.HasMaxLength(3)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.DisplayColour)
					.HasMaxLength(6)
					.IsUnicode(false);

				entity.Property(e => e.Type)
					.HasMaxLength(5)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockEmbroideryPricing>(entity =>
			{
				entity.ToTable("stock_EmbroideryPricing");

				entity.Property(e => e.FkPriceListId).HasColumnName("FK_PriceListId");

				entity.Property(e => e.PriceCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.HasOne(d => d.FkPriceList)
					.WithMany(p => p.StockEmbroideryPricing)
					.HasForeignKey(d => d.FkPriceListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_EmbroideryPricing_stock_Pricelists");
			});

			modelBuilder.Entity<StockInventoryTransactionTypes>(entity =>
			{
				entity.ToTable("stock_InventoryTransactionTypes");

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemAttributes>(entity =>
			{
				entity.ToTable("stock_ItemAttributes");

				entity.HasIndex(e => new { e.FkAttributeTemplateId, e.BoolValue, e.FkItemId })
					.HasName("ix_stock_ItemAttributes_FK_ItemId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkAttributeTemplateId).HasColumnName("FK_AttributeTemplateId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.StringValue)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.TextValue).HasColumnType("text");

				entity.HasOne(d => d.FkAttributeTemplate)
					.WithMany(p => p.StockItemAttributes)
					.HasForeignKey(d => d.FkAttributeTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemAttributes_stock_ItemAttributeTemplates");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemAttributes)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemAttributes_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemAttributeTemplateOptionValues>(entity =>
			{
				entity.ToTable("stock_ItemAttributeTemplateOptionValues");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Display)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.FkTemplateId).HasColumnName("FK_TemplateId");

				entity.Property(e => e.Value)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkTemplate)
					.WithMany(p => p.StockItemAttributeTemplateOptionValues)
					.HasForeignKey(d => d.FkTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemAttributeTemplateOptionValues_stock_ItemAttributeTemplates");
			});

			modelBuilder.Entity<StockItemAttributeTemplates>(entity =>
			{
				entity.ToTable("stock_ItemAttributeTemplates");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DataType)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.IsCatalogue).HasColumnName("isCatalogue");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Section)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemBranchAttributes>(entity =>
			{
				entity.ToTable("stock_ItemBranchAttributes");

				entity.HasIndex(e => new { e.InboundTariffCode, e.FkBranchId, e.FkItemId })
					.HasName("IX_ItemBranchAttributes_Branch_Item");

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.InboundTariffCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemBranchAttributes)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemBranchAttributes_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemBranchShippingMethods>(entity =>
			{
				entity.ToTable("stock_ItemBranchShippingMethods");

				entity.HasIndex(e => new { e.FkBranchId, e.Flags, e.FkShippingMethodId, e.FkItemId })
					.HasName("ix_stock_ItemBranchShippingMethods_FK_ShippingMethodId_FK_ItemId_includes");

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.FkShippingMethodId).HasColumnName("FK_ShippingMethodId");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemBranchShippingMethods)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemBranchShippingMethods_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemBrandMatrix>(entity =>
			{
				entity.HasKey(e => new { e.FkItemId, e.FkBrandId });

				entity.ToTable("stock_ItemBrandMatrix");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.FkBrandId).HasColumnName("FK_BrandId");

				entity.HasOne(d => d.FkBrand)
					.WithMany(p => p.StockItemBrandMatrix)
					.HasForeignKey(d => d.FkBrandId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemBrandMatrix_stock_Brands");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemBrandMatrix)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemBrandMatrix_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemCosts>(entity =>
			{
				entity.ToTable("stock_ItemCosts");

				entity.HasIndex(e => new { e.AverageCost, e.LatestCost, e.FkItemId, e.CompanyCode })
					.HasName("IX_ItemCosts_Item_CompanyCode");

				entity.Property(e => e.CompanyCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemCosts)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemCosts_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemGroupAttributes>(entity =>
			{
				entity.ToTable("stock_ItemGroupAttributes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkAttributeTemplateId).HasColumnName("FK_AttributeTemplateId");

				entity.Property(e => e.FkItemGroupId).HasColumnName("FK_ItemGroupId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.StringValue)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.TextValue).HasColumnType("text");

				entity.HasOne(d => d.FkAttributeTemplate)
					.WithMany(p => p.StockItemGroupAttributes)
					.HasForeignKey(d => d.FkAttributeTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemGroupAttributes_stock_ItemGroupAttributeTemplates");

				entity.HasOne(d => d.FkItemGroup)
					.WithMany(p => p.StockItemGroupAttributes)
					.HasForeignKey(d => d.FkItemGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemGroupAttributes_stock_ItemGroups");
			});

			modelBuilder.Entity<StockItemGroupAttributeTemplates>(entity =>
			{
				entity.ToTable("stock_ItemGroupAttributeTemplates");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DataType)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Section)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemGroups>(entity =>
			{
				entity.ToTable("stock_ItemGroups");

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(4)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemInventoryTypes>(entity =>
			{
				entity.ToTable("stock_ItemInventoryTypes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemLevel>(entity =>
			{
				entity.ToTable("stock_ItemLevel");

				entity.HasIndex(e => e.FkItemId)
					.HasName("ix_stock_ItemLevel_FK_ItemId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemLevel)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevel_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemLevelDetail>(entity =>
			{
				entity.ToTable("stock_ItemLevelDetail");

				entity.HasIndex(e => new { e.FkLevelId, e.FkItemLevelDetailType, e.FkItemLevelSourceId })
					.HasName("ix_stock_ItemLevelDetail_FK_LevelId_FK_ItemLevelDetailType_FK_ItemLevelSourceId");

				entity.HasIndex(e => new { e.FkLevelId, e.FkItemLevelSourceId, e.FkItemLevelDetailType })
					.HasName("IX_stock_ItemLevelDetail")
					.IsUnique();

				entity.HasIndex(e => new { e.FkLevelId, e.FkItemLevelDetailType, e.Suspense, e.FkItemLevelSourceId })
					.HasName("ix_stock_ItemLevelDetail_FK_ItemLevelSourceId_includes");

				entity.HasIndex(e => new { e.FkLevelId, e.FkItemLevelSourceId, e.OnHand, e.FkItemLevelDetailType })
					.HasName("ix_stock_ItemLevelDetail_FK_ItemLevelDetailType_includes");

				entity.Property(e => e.FkItemLevelDetailType).HasColumnName("FK_ItemLevelDetailType");

				entity.Property(e => e.FkItemLevelSourceId).HasColumnName("FK_ItemLevelSourceId");

				entity.Property(e => e.FkLevelId).HasColumnName("FK_LevelId");

				entity.HasOne(d => d.FkItemLevelDetailTypeNavigation)
					.WithMany(p => p.StockItemLevelDetail)
					.HasForeignKey(d => d.FkItemLevelDetailType)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelDetail_stock_ItemLevelDetailType");

				entity.HasOne(d => d.FkItemLevelSource)
					.WithMany(p => p.StockItemLevelDetail)
					.HasForeignKey(d => d.FkItemLevelSourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelDetail_stock_ItemLevelSource");

				entity.HasOne(d => d.FkLevel)
					.WithMany(p => p.StockItemLevelDetail)
					.HasForeignKey(d => d.FkLevelId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelDetails_stock_ItemLevel");
			});

			modelBuilder.Entity<StockItemLevelDetailType>(entity =>
			{
				entity.ToTable("stock_ItemLevelDetailType");

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Wmslookup)
					.HasColumnName("WMSLookup")
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemLevelIncomingDetails>(entity =>
			{
				entity.ToTable("stock_ItemLevelIncomingDetails");

				entity.HasIndex(e => new { e.Created, e.Quantity, e.Eta, e.Reference, e.Reference2, e.FkItemLevelId })
					.HasName("ix_stock_ItemLevelIncomingDetails_FK_ItemLevelId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Eta)
					.HasColumnName("ETA")
					.HasColumnType("date");

				entity.Property(e => e.FkItemLevelId).HasColumnName("FK_ItemLevelId");

				entity.Property(e => e.FkItemLevelSourceId).HasColumnName("FK_ItemLevelSourceId");

				entity.Property(e => e.Reference)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Reference2).HasColumnType("varchar(max)");

				entity.HasOne(d => d.FkItemLevel)
					.WithMany(p => p.StockItemLevelIncomingDetails)
					.HasForeignKey(d => d.FkItemLevelId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelIncomingDetails_stock_ItemLevel");

				entity.HasOne(d => d.FkItemLevelSource)
					.WithMany(p => p.StockItemLevelIncomingDetails)
					.HasForeignKey(d => d.FkItemLevelSourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelIncomingDetails_stock_ItemLevelSource");
			});

			modelBuilder.Entity<StockItemLevelReserveDetails>(entity =>
			{
				entity.ToTable("stock_ItemLevelReserveDetails");

				entity.HasIndex(e => e.Reference)
					.HasName("ix_stock_ItemLevelReserveDetails_Reference");

				entity.HasIndex(e => new { e.FkItemLevelSourceId, e.Reference, e.Quantity, e.Flags, e.FkItemLevelId })
					.HasName("ix_stock_ItemLevelReserveDetails_FK_ItemLevelId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkItemLevelId).HasColumnName("FK_ItemLevelId");

				entity.Property(e => e.FkItemLevelSourceId).HasColumnName("FK_ItemLevelSourceId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.Reference)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Reference2).IsUnicode(false);

				entity.HasOne(d => d.FkItemLevel)
					.WithMany(p => p.StockItemLevelReserveDetails)
					.HasForeignKey(d => d.FkItemLevelId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelReserveDetails_stock_ItemLevel");

				entity.HasOne(d => d.FkItemLevelSource)
					.WithMany(p => p.StockItemLevelReserveDetails)
					.HasForeignKey(d => d.FkItemLevelSourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelReserveDetails_stock_ItemLevelSource");
			});

			modelBuilder.Entity<StockItemLevelSource>(entity =>
			{
				entity.ToTable("stock_ItemLevelSource");

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemLevelTransactions>(entity =>
			{
				entity.ToTable("stock_ItemLevelTransactions");

				entity.HasIndex(e => new { e.Id, e.FkLevelDetailId })
					.HasName("ix_stock_ItemLevelTransactions_FK_LevelDetailId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkLevelDetailId).HasColumnName("FK_LevelDetailId");

				entity.Property(e => e.FkTransactionTypeId).HasColumnName("FK_TransactionTypeId");

				entity.Property(e => e.Originator)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Reference)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Reference2).IsUnicode(false);

				entity.HasOne(d => d.FkLevelDetail)
					.WithMany(p => p.StockItemLevelTransactions)
					.HasForeignKey(d => d.FkLevelDetailId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelTransactions_stock_ItemLevelDetail");

				entity.HasOne(d => d.FkTransactionType)
					.WithMany(p => p.StockItemLevelTransactions)
					.HasForeignKey(d => d.FkTransactionTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemLevelTransactions_stock_InventoryTransactionTypes");
			});

			modelBuilder.Entity<StockItemMaster>(entity =>
			{
				entity.ToTable("stock_ItemMaster");

				entity.HasIndex(e => e.BaseItemCode)
					.HasName("ix_stock_ItemMaster_BaseItemCode");

				entity.HasIndex(e => e.FkParentItemId)
					.HasName("ix_stock_ItemMaster_FK_ParentItemId");

				entity.HasIndex(e => new { e.Id, e.Flags, e.ItemCode })
					.HasName("ix_stock_ItemMaster_ItemCode_includes");

				entity.HasIndex(e => new { e.Id, e.Created, e.Modified, e.ItemCode, e.BaseItemCode, e.Description, e.Colour, e.Size, e.InventoryType, e.Flags, e.FkGroupId })
					.HasName("IX_ItemMAster_INCLUES_FK_GroupId");

				entity.Property(e => e.BaseItemCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Colour)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.FkGroupId).HasColumnName("FK_GroupId");

				entity.Property(e => e.FkParentItemId).HasColumnName("FK_ParentItemId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.Size)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.HasOne(d => d.FkGroup)
					.WithMany(p => p.StockItemMaster)
					.HasForeignKey(d => d.FkGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemMaster_stock_ItemGroups");

				entity.HasOne(d => d.InventoryTypeNavigation)
					.WithMany(p => p.StockItemMaster)
					.HasForeignKey(d => d.InventoryType)
					.HasConstraintName("FK_stock_ItemMaster_stock_ItemInventoryTypes");
			});

			modelBuilder.Entity<StockItemPriceMatrix>(entity =>
			{
				entity.ToTable("stock_ItemPriceMatrix");

				entity.HasIndex(e => new { e.FkPricelistId, e.Price, e.FkItemId })
					.HasName("IX_ItemPriceMatrix_ItemId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.FkPricelistId).HasColumnName("FK_PricelistId");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemPriceMatrix)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemPriceMatrix_stock_ItemMaster");

				entity.HasOne(d => d.FkPricelist)
					.WithMany(p => p.StockItemPriceMatrix)
					.HasForeignKey(d => d.FkPricelistId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemPriceMatrix_stock_Pricelists");
			});

			modelBuilder.Entity<StockItemPublication>(entity =>
			{
				entity.ToTable("stock_ItemPublication");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkDetailLevelSourceId).HasColumnName("FK_DetailLevelSourceId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.HasOne(d => d.FkDetailLevelSource)
					.WithMany(p => p.StockItemPublication)
					.HasForeignKey(d => d.FkDetailLevelSourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemPublication_stock_ItemLevelSource");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemPublication)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemPublication_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemPublicationTransactions>(entity =>
			{
				entity.ToTable("stock_ItemPublicationTransactions");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkPublicationId).HasColumnName("FK_PublicationId");

				entity.Property(e => e.ResultMessage).IsUnicode(false);

				entity.HasOne(d => d.FkPublication)
					.WithMany(p => p.StockItemPublicationTransactions)
					.HasForeignKey(d => d.FkPublicationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemPublicationTransactions_stock_ItemPublication");

				entity.HasOne(d => d.ResultNavigation)
					.WithMany(p => p.StockItemPublicationTransactions)
					.HasForeignKey(d => d.Result)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemPublicationTransactions_stock_ItemTransactionResults");
			});

			modelBuilder.Entity<StockItemShippingMethods>(entity =>
			{
				entity.ToTable("stock_ItemShippingMethods");

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemTransactionResults>(entity =>
			{
				entity.ToTable("stock_ItemTransactionResults");

				entity.HasIndex(e => e.Code)
					.HasName("IX_stock_ItemTransactionResults")
					.IsUnique();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemUom>(entity =>
			{
				entity.ToTable("stock_ItemUOM");

				entity.HasIndex(e => e.FkItemId)
					.HasName("ix_stock_ItemUOM_FK_ItemId");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemUom)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemUOM_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemUomtemplates>(entity =>
			{
				entity.ToTable("stock_ItemUOMTemplates");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockItemUomvalues>(entity =>
			{
				entity.ToTable("stock_ItemUOMValues");

				entity.HasIndex(e => new { e.FkItemUomid, e.Quantity, e.DimWidth, e.DimHeight, e.DimLength, e.Weight, e.FkItemUomtemplateId })
					.HasName("ix_stock_ItemUOMValues_FK_ItemUOMTemplateId_includes");

				entity.HasIndex(e => new { e.Id, e.FkItemUomtemplateId, e.Quantity, e.DimWidth, e.DimHeight, e.DimLength, e.Weight, e.FkItemUomid })
					.HasName("ix_stock_ItemUOMValues_FK_ItemUOMId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DimHeight).HasColumnName("dim_Height");

				entity.Property(e => e.DimLength).HasColumnName("dim_Length");

				entity.Property(e => e.DimWidth).HasColumnName("dim_Width");

				entity.Property(e => e.FkItemUomid).HasColumnName("FK_ItemUOMId");

				entity.Property(e => e.FkItemUomtemplateId).HasColumnName("FK_ItemUOMTemplateId");

				entity.Property(e => e.FkParentUomid).HasColumnName("FK_ParentUOMId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.UnitsDims)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.UnitsWeight)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.HasOne(d => d.FkItemUom)
					.WithMany(p => p.StockItemUomvalues)
					.HasForeignKey(d => d.FkItemUomid)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemUOMValues_stock_ItemUOM");

				entity.HasOne(d => d.FkItemUomtemplate)
					.WithMany(p => p.StockItemUomvalues)
					.HasForeignKey(d => d.FkItemUomtemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemUOMValues_stock_ItemUOMTemplates");

				entity.HasOne(d => d.FkParentUom)
					.WithMany(p => p.InverseFkParentUom)
					.HasForeignKey(d => d.FkParentUomid)
					.HasConstraintName("FK_stock_ItemUOMValues_stock_ItemUOMValues");
			});

			modelBuilder.Entity<StockItemValidation>(entity =>
			{
				entity.ToTable("stock_ItemValidation");

				entity.HasIndex(e => new { e.FkItemId, e.FkDetailLevelSourceId })
					.HasName("ix_stock_ItemValidation_FK_ItemId_FK_DetailLevelSourceId");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkDetailLevelSourceId).HasColumnName("FK_DetailLevelSourceId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.HasOne(d => d.FkDetailLevelSource)
					.WithMany(p => p.StockItemValidation)
					.HasForeignKey(d => d.FkDetailLevelSourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemValidation_stock_ItemLevelSource");

				entity.HasOne(d => d.FkItem)
					.WithMany(p => p.StockItemValidation)
					.HasForeignKey(d => d.FkItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemValidation_stock_ItemMaster");
			});

			modelBuilder.Entity<StockItemValidationTransactions>(entity =>
			{
				entity.ToTable("stock_ItemValidationTransactions");

				entity.HasIndex(e => new { e.FkValidationId, e.Flags })
					.HasName("ix_stock_ItemValidationTransactions_FK_ValidationId_Flags");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkValidationId).HasColumnName("FK_ValidationId");

				entity.Property(e => e.ResultMessage).IsUnicode(false);

				entity.HasOne(d => d.FkValidation)
					.WithMany(p => p.StockItemValidationTransactions)
					.HasForeignKey(d => d.FkValidationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemValidationTransactions_stock_ItemValidation");

				entity.HasOne(d => d.ResultNavigation)
					.WithMany(p => p.StockItemValidationTransactions)
					.HasForeignKey(d => d.Result)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_ItemValidationTransactions_stock_ItemTransactionResults");
			});

			modelBuilder.Entity<StockPalletAudit>(entity =>
			{
				entity.ToTable("_stock_pallet_audit");

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.AdjustDocumentNumber)
					.IsRequired()
					.HasColumnName("adjust_DocumentNumber")
					.HasMaxLength(255);

				entity.Property(e => e.AdjustInLocatonLevel).HasColumnName("adjust_InLocatonLevel");

				entity.Property(e => e.AdjustInQclevel).HasColumnName("adjust_InQCLevel");

				entity.Property(e => e.AdjustInTransitFrom).HasColumnName("adjust_InTransitFrom");

				entity.Property(e => e.AdjustInTransitTo).HasColumnName("adjust_InTransitTo");

				entity.Property(e => e.AdjustInWarehouseLevel).HasColumnName("adjust_InWarehouseLevel");

				entity.Property(e => e.AdjustPicking).HasColumnName("adjust_Picking");

				entity.Property(e => e.AdjustToBePlacedLevel).HasColumnName("adjust_ToBePlacedLevel");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.StoreCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockPalletAudit1>(entity =>
			{
				entity.ToTable("stock_pallet_audit");

				entity.Property(e => e.AdjustDocumentNumber)
					.IsRequired()
					.HasColumnName("adjust_DocumentNumber")
					.HasMaxLength(255);

				entity.Property(e => e.AdjustInLocatonLevel).HasColumnName("adjust_InLocatonLevel");

				entity.Property(e => e.AdjustInQclevel).HasColumnName("adjust_InQCLevel");

				entity.Property(e => e.AdjustInTransitFrom).HasColumnName("adjust_InTransitFrom");

				entity.Property(e => e.AdjustInTransitTo).HasColumnName("adjust_InTransitTo");

				entity.Property(e => e.AdjustInWarehouseLevel).HasColumnName("adjust_InWarehouseLevel");

				entity.Property(e => e.AdjustPicking).HasColumnName("adjust_Picking");

				entity.Property(e => e.AdjustToBePlacedLevel).HasColumnName("adjust_ToBePlacedLevel");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.StoreCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockPallets>(entity =>
			{
				entity.HasKey(e => new { e.ItemCode, e.StoreCode });

				entity.ToTable("stock_pallets");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.StoreCode)
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.InQclevel).HasColumnName("InQCLevel");
			});

			modelBuilder.Entity<StockPallets2>(entity =>
			{
				entity.HasKey(e => new { e.ItemCode, e.StoreCode });

				entity.ToTable("stock_pallets_2");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(15)
					.IsUnicode(false);

				entity.Property(e => e.StoreCode)
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockPricelists>(entity =>
			{
				entity.ToTable("stock_Pricelists");

				entity.HasIndex(e => new { e.CompanyCode, e.PastelLookup })
					.HasName("IX_stock_Pricelists")
					.IsUnique();

				entity.Property(e => e.CompanyCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CurrencyCode)
					.IsRequired()
					.HasMaxLength(10);

				entity.Property(e => e.CurrencyName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.CurrencySymbol)
					.IsRequired()
					.HasMaxLength(5);

				entity.Property(e => e.DisplayFormat)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("(' # ##0.00')");

				entity.Property(e => e.DisplayName)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.PastelLookup)
					.IsRequired()
					.HasMaxLength(30)
					.IsUnicode(false);

				entity.Property(e => e.XfxHostId).HasColumnName("XFX_HostId");
			});

			modelBuilder.Entity<StockRelatedProducts>(entity =>
			{
				entity.HasKey(e => new { e.ItemCode, e.RelatedItemCode });

				entity.ToTable("stock_RelatedProducts");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.RelatedItemCode)
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockSetComponents>(entity =>
			{
				entity.ToTable("stock_SetComponents");

				entity.Property(e => e.AutoAdditionItemCode)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.BaseCode)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.FkSetId).HasColumnName("FK_SetId");

				entity.Property(e => e.Prefix)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkSet)
					.WithMany(p => p.StockSetComponents)
					.HasForeignKey(d => d.FkSetId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_SetComponents_stock_Sets");
			});

			modelBuilder.Entity<StockSetContents>(entity =>
			{
				entity.ToTable("stock_SetContents");

				entity.HasIndex(e => new { e.FkSetId, e.ItemCode })
					.HasName("ix_stock_SetContents_ItemCode_includes");

				entity.HasIndex(e => new { e.ItemCode, e.Flags, e.FkSetId })
					.HasName("IX_SetContents_INCLUDE");

				entity.Property(e => e.BaseItemCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Colour)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkSetId).HasColumnName("FK_SetId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Size)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkSet)
					.WithMany(p => p.StockSetContents)
					.HasForeignKey(d => d.FkSetId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_SetContents_stock_Sets");
			});

			modelBuilder.Entity<StockSets>(entity =>
			{
				entity.ToTable("stock_Sets");

				entity.Property(e => e.BaseCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Colour)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.InvoiceCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.InvoiceDiscountCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Size)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockSetStockcheck>(entity =>
			{
				entity.HasKey(e => e.GiftSetItemCode);

				entity.ToTable("stock_set_stockcheck");

				entity.Property(e => e.GiftSetItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.Bo).HasColumnName("BO");

				entity.Property(e => e.Eta)
					.HasColumnName("ETA")
					.HasColumnType("datetime");

				entity.Property(e => e.Ic).HasColumnName("IC");

				entity.Property(e => e.Jhb).HasColumnName("JHB");
			});

			modelBuilder.Entity<StockStItemLoadCatalogueCh1>(entity =>
			{
				entity.HasKey(e => e.FkItemId);

				entity.ToTable("stock_stItemLoadCatalogue_ch1");

				entity.Property(e => e.FkItemId)
					.HasColumnName("FK_ItemId")
					.ValueGeneratedNever();

				entity.Property(e => e.CatalogueAlpcategory)
					.HasColumnName("Catalogue:ALPCategory")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CatalogueOnPromotion).HasColumnName("Catalogue:OnPromotion");

				entity.Property(e => e.InvoicingSampleShopQuantityException).HasColumnName("Invoicing:SampleShopQuantityException");

				entity.Property(e => e.InvoicingVisible).HasColumnName("Invoicing:Visible");

				entity.Property(e => e.QuotesVisible).HasColumnName("Quotes:Visible");

				entity.Property(e => e.WarehouseDangerousGoods).HasColumnName("Warehouse:DangerousGoods");

				entity.Property(e => e.WarehouseHighValue).HasColumnName("Warehouse:HighValue");

				entity.Property(e => e.WarehouseWarehouseItem).HasColumnName("Warehouse:WarehouseItem");
			});

			modelBuilder.Entity<StockStockGpe>(entity =>
			{
				entity.ToTable("stock_StockGPE");

				entity.Property(e => e.FkPrintDepartmentId).HasColumnName("Fk_PrintDepartmentId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockToDelete>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<StockVirtualStockLookup>(entity =>
			{
				entity.ToTable("stock_VirtualStockLookup");

				entity.HasIndex(e => new { e.VirtualRangeCode, e.ColourCode })
					.HasName("IX_stock_VirtualStockLookup")
					.IsUnique();

				entity.Property(e => e.ColourCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.PhysicalRangeCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.PrintDepartment)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PrintSteps)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.VirtualRangeCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockVolumetric>(entity =>
			{
				entity.ToTable("stock_Volumetric");

				entity.Property(e => e.BaseItemCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.DUnit)
					.IsRequired()
					.HasColumnName("d_Unit")
					.HasMaxLength(2)
					.IsUnicode(false);

				entity.Property(e => e.DWeight).HasColumnName("d_Weight");

				entity.Property(e => e.FkBatchId).HasColumnName("FK_BatchId");

				entity.Property(e => e.MHeight).HasColumnName("m_Height");

				entity.Property(e => e.MLength).HasColumnName("m_Length");

				entity.Property(e => e.MWidth).HasColumnName("m_Width");

				entity.Property(e => e.Size)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.VUnit)
					.IsRequired()
					.HasColumnName("v_Unit")
					.HasMaxLength(2)
					.IsUnicode(false);

				entity.Property(e => e.VVolume).HasColumnName("v_Volume");

				entity.Property(e => e.VWeight).HasColumnName("v_Weight");

				entity.Property(e => e.WUnit)
					.IsRequired()
					.HasColumnName("w_Unit")
					.HasMaxLength(2)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBatch)
					.WithMany(p => p.StockVolumetric)
					.HasForeignKey(d => d.FkBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_stock_Volumetric_stock_VolumetricBatches");
			});

			modelBuilder.Entity<StockVolumetricBatches>(entity =>
			{
				entity.ToTable("stock_VolumetricBatches");

				entity.Property(e => e.BatchNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<StockWmsChange>(entity =>
			{
				entity.HasKey(e => new { e.ItemCode, e.StoreCode });

				entity.ToTable("stock_wms_change");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(15)
					.IsUnicode(false);

				entity.Property(e => e.StoreCode)
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<TempInclusiveBrandingOptions>(entity =>
			{
				entity.HasKey(e => e.ItemMasterId);

				entity.ToTable("temp_InclusiveBrandingOptions");

				entity.Property(e => e.ItemMasterId).ValueGeneratedNever();

				entity.Property(e => e.BaseCode)
					.IsRequired()
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.Property(e => e.Boss).HasColumnName("BOSS");

				entity.Property(e => e.Emb).HasColumnName("EMB");

				entity.Property(e => e.Lg).HasColumnName("LG");

				entity.Property(e => e.Sp).HasColumnName("SP");
			});

			modelBuilder.Entity<TStockAttributes>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("tStockAttributes");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.BaseItemCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.CartonDimenstions)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CartonWeight)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CataloguePageNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Cbl)
					.HasColumnName("CBL")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.D)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.H)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.HalfBottom)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.HalfChest)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.QuantityPerCarton)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Size)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.SleeveLength)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.W)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<UtiMrndata>(entity =>
			{
				entity.ToTable("UTI_MRNData");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.Property(e => e.Mrn)
					.IsRequired()
					.HasColumnName("MRN")
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.Property(e => e.Ponumber)
					.HasColumnName("PONumber")
					.HasMaxLength(64)
					.IsUnicode(false);
			});

			modelBuilder.Entity<UtiMrndata1>(entity =>
			{
				entity.ToTable("_UTI_MRNData");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.Property(e => e.Mrn)
					.IsRequired()
					.HasColumnName("MRN")
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.Property(e => e.Ponumber)
					.HasColumnName("PONumber")
					.HasMaxLength(64)
					.IsUnicode(false);
			});

			modelBuilder.Entity<UtiMrntransactions>(entity =>
			{
				entity.ToTable("UTI_MRNTransactions");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.MrnId).HasColumnName("MRN_Id");

				entity.Property(e => e.Reason)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.Mrn)
					.WithMany(p => p.UtiMrntransactions)
					.HasForeignKey(d => d.MrnId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UTI_MRNTransactions_UTI_MRNId");
			});

			modelBuilder.Entity<UtiMrntransactions1>(entity =>
			{
				entity.ToTable("_UTI_MRNTransactions");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.MrnId).HasColumnName("MRN_Id");

				entity.Property(e => e.Reason)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.Mrn)
					.WithMany(p => p.UtiMrntransactions1)
					.HasForeignKey(d => d.MrnId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK__UTI_MRNTransactions_UTI_MRNId");
			});
		}
	}
}
