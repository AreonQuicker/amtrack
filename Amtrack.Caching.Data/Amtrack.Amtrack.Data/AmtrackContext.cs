using Amtrack.Amtrack.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Amtrack.Amtrack.Data
{
	public partial class AmtrackContext : DbContext
	{
		public AmtrackContext()
		{
		}

		public AmtrackContext(DbContextOptions<AmtrackContext> options)
			: base(options)
		{
		}

		public DbSet<Account> Account { get; set; }
		public DbSet<AccountAttachment> AccountAttachment { get; set; }
		public DbSet<AccountAttachments> AccountAttachments { get; set; }
		public DbSet<AccountContactNotifications> AccountContactNotifications { get; set; }
		public DbSet<AccountContacts> AccountContacts { get; set; }
		public DbSet<AccountCreditLimit> AccountCreditLimit { get; set; }
		public DbSet<AccountCreditLimitGroups> AccountCreditLimitGroups { get; set; }
		public DbSet<AccountCustomers> AccountCustomers { get; set; }
		public DbSet<AccountManagerAccountsRepresentative> AccountManagerAccountsRepresentative { get; set; }
		public DbSet<AccountManagerLayoutArtists> AccountManagerLayoutArtists { get; set; }
		public DbSet<AccountNotes> AccountNotes { get; set; }
		public DbSet<AccountNotifications> AccountNotifications { get; set; }
		public DbSet<AccountOrders> AccountOrders { get; set; }
		public DbSet<AccountQuotes> AccountQuotes { get; set; }
		public DbSet<AccountRename> AccountRename { get; set; }
		public DbSet<AccountSwitch> AccountSwitch { get; set; }
		public DbSet<AdtAccount> AdtAccount { get; set; }
		public DbSet<AlpmultiplierOverride> AlpmultiplierOverride { get; set; }
		public DbSet<ApiSessionActivities> ApiSessionActivities { get; set; }
		public DbSet<ApiSessions> ApiSessions { get; set; }
		public DbSet<ApplicationUpdate> ApplicationUpdate { get; set; }
		public DbSet<ApprovedJobCardUsers> ApprovedJobCardUsers { get; set; }
		public DbSet<AudOrderQuery> AudOrderQuery { get; set; }
		public DbSet<AudOrderQueryLines> AudOrderQueryLines { get; set; }
		public DbSet<Barcode> Barcode { get; set; }
		public DbSet<Batch> Batch { get; set; }
		public DbSet<BatchedBaskets> BatchedBaskets { get; set; }
		public DbSet<BatchedBatch> BatchedBatch { get; set; }
		public DbSet<BatchedJobCards> BatchedJobCards { get; set; }
		public DbSet<BatchedOrders> BatchedOrders { get; set; }
		public DbSet<BatchedParcels> BatchedParcels { get; set; }
		public DbSet<BatchedShipments> BatchedShipments { get; set; }
		public DbSet<BatchedStock> BatchedStock { get; set; }
		public DbSet<BatchStockContent> BatchStockContent { get; set; }
		public DbSet<BatchTracking> BatchTracking { get; set; }
		public DbSet<BrandCuring> BrandCuring { get; set; }
		public DbSet<BrandDepartments> BrandDepartments { get; set; }
		public DbSet<BrandGroupCuring> BrandGroupCuring { get; set; }
		public DbSet<BrandGroupItem> BrandGroupItem { get; set; }
		public DbSet<BrandGroupQuantities> BrandGroupQuantities { get; set; }
		public DbSet<BrandingConversionAccountSwitch> BrandingConversionAccountSwitch { get; set; }
		public DbSet<BrandingInstructions> BrandingInstructions { get; set; }
		public DbSet<BrandItemCuring> BrandItemCuring { get; set; }
		public DbSet<BrandItemGroup> BrandItemGroup { get; set; }
		public DbSet<BrandItemQuantities> BrandItemQuantities { get; set; }
		public DbSet<BrandItems> BrandItems { get; set; }
		public DbSet<BrandItemTypeQuantities> BrandItemTypeQuantities { get; set; }
		public DbSet<BrandItemTypes> BrandItemTypes { get; set; }
		public DbSet<BrandQuantities> BrandQuantities { get; set; }
		public DbSet<CheckInReportData> CheckInReportData { get; set; }
		public DbSet<ClBatchContents> ClBatchContents { get; set; }
		public DbSet<CmtProcess> CmtProcess { get; set; }
		public DbSet<ContactWebInfo> ContactWebInfo { get; set; }
		public DbSet<CreditLimitGroups> CreditLimitGroups { get; set; }
		public DbSet<CreditNote> CreditNote { get; set; }
		public DbSet<CreditNoteAccount> CreditNoteAccount { get; set; }
		public DbSet<CreditNoteAttachment> CreditNoteAttachment { get; set; }
		public DbSet<CreditNoteAttachments> CreditNoteAttachments { get; set; }
		public DbSet<CreditNoteAuthorizer> CreditNoteAuthorizer { get; set; }
		public DbSet<CreditNoteCreditNoteRequest> CreditNoteCreditNoteRequest { get; set; }
		public DbSet<CreditNoteDetail> CreditNoteDetail { get; set; }
		public DbSet<CreditNoteOrder> CreditNoteOrder { get; set; }
		public DbSet<CreditNotePackaging> CreditNotePackaging { get; set; }
		public DbSet<CreditNoteRequest> CreditNoteRequest { get; set; }
		public DbSet<CreditNoteRequestDetail> CreditNoteRequestDetail { get; set; }
		public DbSet<CreditNoteRequester> CreditNoteRequester { get; set; }
		public DbSet<CreditNoteRequestEx> CreditNoteRequestEx { get; set; }
		public DbSet<CreditNoteRequestNotes> CreditNoteRequestNotes { get; set; }
		public DbSet<CreditNoteRequestOrder> CreditNoteRequestOrder { get; set; }
		public DbSet<CreditNoteRequestPaymentApprovedNotes> CreditNoteRequestPaymentApprovedNotes { get; set; }
		public DbSet<CreditNoteRequestTracking> CreditNoteRequestTracking { get; set; }
		public DbSet<CreditNoteShelvedStock> CreditNoteShelvedStock { get; set; }
		public DbSet<CreditNoteTracking> CreditNoteTracking { get; set; }
		public DbSet<CreditReceipt> CreditReceipt { get; set; }
		public DbSet<CreditReturnReceipt> CreditReturnReceipt { get; set; }
		public DbSet<CsStockTake> CsStockTake { get; set; }
		public DbSet<CsStockTakeParcel> CsStockTakeParcel { get; set; }
		public DbSet<CsStockTakeResolved> CsStockTakeResolved { get; set; }
		public DbSet<CsStockTakeShelf> CsStockTakeShelf { get; set; }
		public DbSet<CsStockTakeSnapshot> CsStockTakeSnapshot { get; set; }
		public DbSet<Customer> Customer { get; set; }
		public DbSet<CustomerQuotes> CustomerQuotes { get; set; }
		public DbSet<CustomerTeirs> CustomerTeirs { get; set; }
		public DbSet<DeletedParcel> DeletedParcel { get; set; }
		public DbSet<DeletedParcelBatches> DeletedParcelBatches { get; set; }
		public DbSet<DeletedParcelTrackings> DeletedParcelTrackings { get; set; }
		public DbSet<DeliveryRequest> DeliveryRequest { get; set; }
		public DbSet<DeliveryRequestContents> DeliveryRequestContents { get; set; }
		public DbSet<DeliveryRequestTracking> DeliveryRequestTracking { get; set; }
		public DbSet<DualJobCardLink> DualJobCardLink { get; set; }
		public DbSet<EmailLog> EmailLog { get; set; }
		public DbSet<EmbroideryQuoteRequest> EmbroideryQuoteRequest { get; set; }
		public DbSet<EmbroideryQuoteRequestAttachment> EmbroideryQuoteRequestAttachment { get; set; }
		public DbSet<EmbroideryQuoteRequestDetails> EmbroideryQuoteRequestDetails { get; set; }
		public DbSet<EmbroideryQuoteRequestNotes> EmbroideryQuoteRequestNotes { get; set; }
		public DbSet<EmbroideryQuoteRequestPositionDetail> EmbroideryQuoteRequestPositionDetail { get; set; }
		public DbSet<EmbroideryQuoteRequestTracking> EmbroideryQuoteRequestTracking { get; set; }
		public DbSet<ExUser> ExUser { get; set; }
		public DbSet<FaultyGoodsRequests> FaultyGoodsRequests { get; set; }
		public DbSet<GenericTrackings> GenericTrackings { get; set; }
		public DbSet<Inventory> Inventory { get; set; }
		public DbSet<InventoryStock> InventoryStock { get; set; }
		public DbSet<InvoiceAttachment> InvoiceAttachment { get; set; }
		public DbSet<InvoiceAttachments> InvoiceAttachments { get; set; }
		public DbSet<JobCard> JobCard { get; set; }
		public DbSet<JobCardAccountContacts> JobCardAccountContacts { get; set; }
		public DbSet<JobCardAttachment> JobCardAttachment { get; set; }
		public DbSet<JobCardAttachments> JobCardAttachments { get; set; }
		public DbSet<JobcardBrandingInstructionVersions> JobcardBrandingInstructionVersions { get; set; }
		public DbSet<JobCardCustomerNotes> JobCardCustomerNotes { get; set; }
		public DbSet<JobCardDates> JobCardDates { get; set; }
		public DbSet<JobCardEmbroideryQuoteRequest> JobCardEmbroideryQuoteRequest { get; set; }
		public DbSet<JobCardEx> JobCardEx { get; set; }
		public DbSet<JobCardEx2> JobCardEx2 { get; set; }
		public DbSet<JobCardLayouts> JobCardLayouts { get; set; }
		public DbSet<JobCardLeadtimeTracking> JobCardLeadtimeTracking { get; set; }
		public DbSet<JobCardNotes> JobCardNotes { get; set; }
		public DbSet<JobCardPackaging> JobCardPackaging { get; set; }
		public DbSet<JobCardPacker> JobCardPacker { get; set; }
		public DbSet<JobCardPackingNotes> JobCardPackingNotes { get; set; }
		public DbSet<JobCardPrintingProcess> JobCardPrintingProcess { get; set; }
		public DbSet<JobCardQuery> JobCardQuery { get; set; }
		public DbSet<JobCardQueue> JobCardQueue { get; set; }
		public DbSet<JobCardRelations> JobCardRelations { get; set; }
		public DbSet<JobCardsForPrintLines> JobCardsForPrintLines { get; set; }
		public DbSet<JobCardSpecialInstructions> JobCardSpecialInstructions { get; set; }
		public DbSet<JobCardStatusIndex> JobCardStatusIndex { get; set; }
		public DbSet<JobCardSurplus> JobCardSurplus { get; set; }
		public DbSet<JobCardTeamLeader> JobCardTeamLeader { get; set; }
		public DbSet<JobcardTimesheetRecords> JobcardTimesheetRecords { get; set; }
		public DbSet<JobCardTracking> JobCardTracking { get; set; }
		public DbSet<Layout> Layout { get; set; }
		public DbSet<LayoutArtistBusyWith> LayoutArtistBusyWith { get; set; }
		public DbSet<LayoutArtists> LayoutArtists { get; set; }
		public DbSet<LayoutOptions> LayoutOptions { get; set; }
		public DbSet<LayoutReject> LayoutReject { get; set; }
		public DbSet<LayoutTracking> LayoutTracking { get; set; }
		public DbSet<LayoutUpdateData> LayoutUpdateData { get; set; }
		public DbSet<LdItemsAtGlx> LdItemsAtGlx { get; set; }
		public DbSet<LdmAdjustment> LdmAdjustment { get; set; }
		public DbSet<LdmAdjustmentTrackings> LdmAdjustmentTrackings { get; set; }
		public DbSet<LdmDepartments> LdmDepartments { get; set; }
		public DbSet<LdmGroupItems> LdmGroupItems { get; set; }
		public DbSet<LdmGroupLeadtimes> LdmGroupLeadtimes { get; set; }
		public DbSet<LdmGroups> LdmGroups { get; set; }
		public DbSet<LdmPackingRules> LdmPackingRules { get; set; }
		public DbSet<LdmPackingRuleValues> LdmPackingRuleValues { get; set; }
		public DbSet<LdmPersonalization> LdmPersonalization { get; set; }
		public DbSet<LdmStitchCounts> LdmStitchCounts { get; set; }
		public DbSet<LeadTimes> LeadTimes { get; set; }
		public DbSet<LeadTimesJobCard> LeadTimesJobCard { get; set; }
		public DbSet<Level> Level { get; set; }
		public DbSet<Line> Line { get; set; }
		public DbSet<LineJobCards> LineJobCards { get; set; }
		public DbSet<LinkedBatches> LinkedBatches { get; set; }
		public DbSet<LinkedReturnStock> LinkedReturnStock { get; set; }
		public DbSet<LinkLineJobCards> LinkLineJobCards { get; set; }
		public DbSet<Location> Location { get; set; }
		public DbSet<LocationHierarchy> LocationHierarchy { get; set; }
		public DbSet<LocationItems> LocationItems { get; set; }
		public DbSet<LocationJobCards> LocationJobCards { get; set; }
		public DbSet<LocationSorting> LocationSorting { get; set; }
		public DbSet<LocationTracking> LocationTracking { get; set; }
		public DbSet<LogBranchScanning> LogBranchScanning { get; set; }
		public DbSet<Lookup> Lookup { get; set; }
		public DbSet<LookupDocTypes> LookupDocTypes { get; set; }
		public DbSet<LookupSort> LookupSort { get; set; }
		public DbSet<LqAllocation> LqAllocation { get; set; }
		public DbSet<LqLayoutDocuments> LqLayoutDocuments { get; set; }
		public DbSet<LqLookupQueueTrackingTypes> LqLookupQueueTrackingTypes { get; set; }
		public DbSet<LqQueue> LqQueue { get; set; }
		public DbSet<LqQueueAccess> LqQueueAccess { get; set; }
		public DbSet<LqQueueNotes> LqQueueNotes { get; set; }
		public DbSet<LqQueueTracking> LqQueueTracking { get; set; }
		public DbSet<LqQueueTypes> LqQueueTypes { get; set; }
		public DbSet<LqQueueTypeValues> LqQueueTypeValues { get; set; }
		public DbSet<LqSettings> LqSettings { get; set; }
		public DbSet<LqShifts> LqShifts { get; set; }
		public DbSet<Machines> Machines { get; set; }
		public DbSet<Note> Note { get; set; }
		public DbSet<Notes> Notes { get; set; }
		public DbSet<Notification> Notification { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<OrderCustomerNotes> OrderCustomerNotes { get; set; }
		public DbSet<OrderDetail> OrderDetail { get; set; }
		public DbSet<OrderNotes> OrderNotes { get; set; }
		public DbSet<OrderQuery> OrderQuery { get; set; }
		public DbSet<OrderQueryLines> OrderQueryLines { get; set; }
		public DbSet<OrderRemoved> OrderRemoved { get; set; }
		public DbSet<OrderStrikes> OrderStrikes { get; set; }
		public DbSet<OrderTracking> OrderTracking { get; set; }
		public DbSet<Packaging> Packaging { get; set; }
		public DbSet<PackingInstructions> PackingInstructions { get; set; }
		public DbSet<Parcel> Parcel { get; set; }
		public DbSet<ParcelLocations> ParcelLocations { get; set; }
		public DbSet<ParcelStatusEnum> ParcelStatusEnum { get; set; }
		public DbSet<ParcelTracking> ParcelTracking { get; set; }
		public DbSet<PartialCollectionDetail> PartialCollectionDetail { get; set; }
		public DbSet<PastelWarehouse> PastelWarehouse { get; set; }
		public DbSet<Payment> Payment { get; set; }
		public DbSet<PaymentInformation> PaymentInformation { get; set; }
		public DbSet<Permission> Permission { get; set; }
		public DbSet<PermissionMatrix> PermissionMatrix { get; set; }
		public DbSet<PhysicalStockCountNotification> PhysicalStockCountNotification { get; set; }
		public DbSet<PhysicalStockCountRecipients> PhysicalStockCountRecipients { get; set; }
		public DbSet<PhysicalStockCounts> PhysicalStockCounts { get; set; }
		public DbSet<PhysicalStockCountVariances> PhysicalStockCountVariances { get; set; }
		public DbSet<Price> Price { get; set; }
		public DbSet<Pricelist> Pricelist { get; set; }
		public DbSet<PricePricelist> PricePricelist { get; set; }
		public DbSet<PriceRegime> PriceRegime { get; set; }
		public DbSet<PrintAttributes> PrintAttributes { get; set; }
		public DbSet<PrintAttributeValues> PrintAttributeValues { get; set; }
		public DbSet<PrintDepartment> PrintDepartment { get; set; }
		public DbSet<PrintDepartmentLeaders> PrintDepartmentLeaders { get; set; }
		public DbSet<PrintDepartmentQueues> PrintDepartmentQueues { get; set; }
		public DbSet<PrintDepartmentUsers> PrintDepartmentUsers { get; set; }
		public DbSet<PrinterQueueAccess> PrinterQueueAccess { get; set; }
		public DbSet<PrinterQueues> PrinterQueues { get; set; }
		public DbSet<PrinterSessions> PrinterSessions { get; set; }
		public DbSet<PrintingDepartmentProcesses> PrintingDepartmentProcesses { get; set; }
		public DbSet<PrintJobs> PrintJobs { get; set; }
		public DbSet<PrintProcess> PrintProcess { get; set; }
		public DbSet<ProductionQctask> ProductionQctask { get; set; }
		public DbSet<ProductionStore> ProductionStore { get; set; }
		public DbSet<Province> Province { get; set; }
		public DbSet<QueryNotifications> QueryNotifications { get; set; }
		public DbSet<QueryReasonCodes> QueryReasonCodes { get; set; }
		public DbSet<Queues> Queues { get; set; }
		public DbSet<Quote> Quote { get; set; }
		public DbSet<QuoteItem> QuoteItem { get; set; }
		public DbSet<QuoteItems> QuoteItems { get; set; }
		public DbSet<ReportMailers> ReportMailers { get; set; }
		public DbSet<ReportMailerSchedule> ReportMailerSchedule { get; set; }
		public DbSet<ReportOverride> ReportOverride { get; set; }
		public DbSet<Resource> Resource { get; set; }
		public DbSet<ResourcePermissions> ResourcePermissions { get; set; }
		public DbSet<RestoreData> RestoreData { get; set; }
		public DbSet<ReturnedBatchDetail> ReturnedBatchDetail { get; set; }
		public DbSet<ReturnedLine> ReturnedLine { get; set; }
		public DbSet<RushAccounts> RushAccounts { get; set; }
		public DbSet<RushStaging> RushStaging { get; set; }
		public DbSet<SalesRepresentatives> SalesRepresentatives { get; set; }
		public DbSet<SecurityLevels> SecurityLevels { get; set; }
		public DbSet<Setting> Setting { get; set; }
		public DbSet<ShAccountShippingInfoes> ShAccountShippingInfoes { get; set; }
		public DbSet<Shelves> Shelves { get; set; }
		public DbSet<SpecialInstuctions> SpecialInstuctions { get; set; }
		public DbSet<StatsFinancial> StatsFinancial { get; set; }
		public DbSet<StInventoryCategorySales> StInventoryCategorySales { get; set; }
		public DbSet<StkimportedSnapshot> StkimportedSnapshot { get; set; }
		public DbSet<StkimpotedSnapshotData> StkimpotedSnapshotData { get; set; }
		public DbSet<StksnapshotDifferenceData> StksnapshotDifferenceData { get; set; }
		public DbSet<Stock> Stock { get; set; }
		public DbSet<StockCheckTracking> StockCheckTracking { get; set; }
		public DbSet<StockFlags> StockFlags { get; set; }
		public DbSet<StockGroupTypes> StockGroupTypes { get; set; }
		public DbSet<StockPrice> StockPrice { get; set; }
		public DbSet<StockTakeEntries> StockTakeEntries { get; set; }
		public DbSet<StockWarehouse> StockWarehouse { get; set; }
		public DbSet<StSales> StSales { get; set; }
		public DbSet<StTopCustomerSpend> StTopCustomerSpend { get; set; }
		public DbSet<StTurnover> StTurnover { get; set; }
		public DbSet<StTurnoverRegional> StTurnoverRegional { get; set; }
		public DbSet<StWarehouseStockLevels> StWarehouseStockLevels { get; set; }
		public DbSet<SuburbCity> SuburbCity { get; set; }
		public DbSet<SystemRequest> SystemRequest { get; set; }
		public DbSet<SystemRequestAttachment> SystemRequestAttachment { get; set; }
		public DbSet<SystemRequestNote> SystemRequestNote { get; set; }
		public DbSet<SystemRequestTracking> SystemRequestTracking { get; set; }
		public DbSet<TempAplookup> TempAplookup { get; set; }
		public DbSet<Terminal> Terminal { get; set; }
		public DbSet<TerminalLocations> TerminalLocations { get; set; }
		public DbSet<TerminalTracking> TerminalTracking { get; set; }
		public DbSet<Tracking> Tracking { get; set; }
		public DbSet<TrueAccountManagers> TrueAccountManagers { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<UserTracking> UserTracking { get; set; }
		public DbSet<Warehouse> Warehouse { get; set; }
		public DbSet<WarehouseInventory> WarehouseInventory { get; set; }
		public DbSet<Waybill> Waybill { get; set; }
		public DbSet<Wc15ParcelBatchInfo> Wc15ParcelBatchInfo { get; set; }
		public DbSet<Wc15ReceivedSampleBatches> Wc15ReceivedSampleBatches { get; set; }

		// Unable to generate entity type for table 'dbo.cache_ScreenDataWarehouse001'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stat_LayoutAssistantApplicationLoading'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stat_LayoutAssistantLineDrawings'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.stat_LayoutAssistantTemplate'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.WaybillDetail'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.DeletedDateOnReports'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TempStatus'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.UserPermissions'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.JobCardNotification'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._tempALP'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._CustomerTeirs'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.StockTake'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._ACCNUMBERUPDATE'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ReportMailerLog'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.temp_teirs'. Please see the warning messages.

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{

				optionsBuilder.UseSqlServer("server=10.37.0.36,1443;database=amtrack;uid=support;pwd=F15HP@15T;Max Pool Size=300;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Account>(entity =>
			{
				entity.HasIndex(e => new { e.Id, e.Phone, e.Fax, e.Mobile, e.Email, e.PhysicalAddress, e.Status, e.Type, e.VatNumber, e.BranchCode, e.DeferVatnumber, e.Number })
					.HasName("ix_Account_number_includes");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AccManager)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BranchCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.ContactPerson)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.DeferVatnumber)
					.HasColumnName("DeferVATNumber")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.HasColumnName("email")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Fax)
					.HasColumnName("fax")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.IsBlockingEmails).HasColumnName("isBlockingEmails");

				entity.Property(e => e.IsBlockingSms).HasColumnName("isBlockingSMS");

				entity.Property(e => e.Mobile)
					.HasColumnName("mobile")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Phone)
					.HasColumnName("phone")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PhysicalAddress)
					.HasColumnName("physicalAddress")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PhysicalCode)
					.HasColumnName("physicalCode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PostalAddress)
					.HasColumnName("postalAddress")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PostalCode)
					.HasColumnName("postalCode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SendToAccManager).HasColumnName("sendToAccManager");

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.Type).HasColumnName("type");

				entity.Property(e => e.VatNumber)
					.HasColumnName("vatNumber")
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Website)
					.HasColumnName("website")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AccountAttachment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Filename)
					.HasColumnName("filename")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.RelativePath)
					.HasColumnName("relativePath")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type)
					.IsRequired()
					.HasColumnName("type")
					.HasMaxLength(55)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AccountAttachments>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_AccountAttachments")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.AccountAttachments)
					.HasForeignKey<AccountAttachments>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAttachments_Attachment");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.AccountAttachments)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAttachments_Account");
			});

			modelBuilder.Entity<AccountContactNotifications>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.AccountContactNotifications)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactNotifications_Notification");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.AccountContactNotifications)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactNotifications_Contact");
			});

			modelBuilder.Entity<AccountContacts>(entity =>
			{
				entity.HasIndex(e => new { e.Id, e.Name, e.Email, e.AccountId })
					.HasName("IX_AccountContacts_accountId");

				entity.Property(e => e.AccountId).HasColumnName("accountId");

				entity.Property(e => e.Birthday).HasColumnType("datetime");

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.Account)
					.WithMany(p => p.AccountContacts)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContacts_Account");
			});

			modelBuilder.Entity<AccountCreditLimit>(entity =>
			{
				entity.HasKey(e => e.AccountFk);

				entity.Property(e => e.AccountFk)
					.HasColumnName("Account_FK")
					.ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ExpireDate).HasColumnType("datetime");

				entity.HasOne(d => d.AccountFkNavigation)
					.WithOne(p => p.AccountCreditLimit)
					.HasForeignKey<AccountCreditLimit>(d => d.AccountFk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountCreditLimit_Account1");
			});

			modelBuilder.Entity<AccountCreditLimitGroups>(entity =>
			{
				entity.HasKey(e => e.AccountId);

				entity.Property(e => e.AccountId).ValueGeneratedNever();

				entity.HasOne(d => d.Account)
					.WithOne(p => p.AccountCreditLimitGroups)
					.HasForeignKey<AccountCreditLimitGroups>(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountCreditLimitGroups_Account");

				entity.HasOne(d => d.CreditLimit)
					.WithMany(p => p.AccountCreditLimitGroups)
					.HasForeignKey(d => d.CreditLimitId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountCreditLimitGroups_CreditLimitGroups");
			});

			modelBuilder.Entity<AccountCustomers>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_AccountCustomers")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.AccountCustomers)
					.HasForeignKey<AccountCustomers>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountCustomers_AccountOfCustomer");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.AccountCustomers)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountCustomers_Customers");
			});

			modelBuilder.Entity<AccountManagerAccountsRepresentative>(entity =>
			{
				entity.HasKey(e => e.AccountManagerId);

				entity.Property(e => e.AccountManagerId)
					.HasColumnName("AccountManagerID")
					.ValueGeneratedNever();

				entity.HasOne(d => d.AccountManager)
					.WithOne(p => p.AccountManagerAccountsRepresentativeAccountManager)
					.HasForeignKey<AccountManagerAccountsRepresentative>(d => d.AccountManagerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountManagerAccountsRepresentative_User");

				entity.HasOne(d => d.AccountsUser)
					.WithMany(p => p.AccountManagerAccountsRepresentativeAccountsUser)
					.HasForeignKey(d => d.AccountsUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountManagerAccountsRepresentative_User1");
			});

			modelBuilder.Entity<AccountManagerLayoutArtists>(entity =>
			{
				entity.HasKey(e => new { e.AccountManagerId, e.PrintDepartmentId });

				entity.Property(e => e.AccountManagerId).HasColumnName("AccountManagerID");

				entity.Property(e => e.PrintDepartmentId).HasColumnName("PrintDepartmentID");

				entity.Property(e => e.LayoutArtistId).HasColumnName("LayoutArtistID");

				entity.HasOne(d => d.AccountManager)
					.WithMany(p => p.AccountManagerLayoutArtistsAccountManager)
					.HasForeignKey(d => d.AccountManagerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountManagerLayoutArtists_User");

				entity.HasOne(d => d.LayoutArtist)
					.WithMany(p => p.AccountManagerLayoutArtistsLayoutArtist)
					.HasForeignKey(d => d.LayoutArtistId)
					.HasConstraintName("FK_AccountManagerLayoutArtists_User1");

				entity.HasOne(d => d.PrintDepartment)
					.WithMany(p => p.AccountManagerLayoutArtists)
					.HasForeignKey(d => d.PrintDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountManagerLayoutArtists_PrintDepartment");
			});

			modelBuilder.Entity<AccountNotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_AccountNotes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.AccountNotes)
					.HasForeignKey<AccountNotes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountNotes_Account");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.AccountNotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountNotes_NotesForAccount");
			});

			modelBuilder.Entity<AccountNotifications>(entity =>
			{
				entity.HasIndex(e => e.Code)
					.HasName("UQ__AccountN__357D4CF9A974AD23")
					.IsUnique();

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasColumnName("code")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Displayname)
					.IsRequired()
					.HasColumnName("displayname")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");
			});

			modelBuilder.Entity<AccountOrders>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_AccountOrders")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.AccountOrders)
					.HasForeignKey<AccountOrders>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountOrders_AccountForOrder");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.AccountOrders)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountOrders_OrdersForAccount");
			});

			modelBuilder.Entity<AccountQuotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_AccountQuotes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.AccountQuotes)
					.HasForeignKey<AccountQuotes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountQuotes_Quote");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.AccountQuotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountQuotes_Account");
			});

			modelBuilder.Entity<AccountRename>(entity =>
			{
				entity.HasKey(e => new { e.OldNumber, e.NewNumber });

				entity.ToTable("_AccountRename");

				entity.Property(e => e.OldNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.NewNumber)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AccountSwitch>(entity =>
			{
				entity.HasKey(e => new { e.CustomerCode, e.UserId });

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.UserId).HasColumnName("UserID");
			});

			modelBuilder.Entity<AdtAccount>(entity =>
			{
				entity.HasKey(e => e.Aid);

				entity.ToTable("adt_Account");

				entity.Property(e => e.Aid).HasColumnName("aid");

				entity.Property(e => e.AccManager)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Action).HasColumnName("action");

				entity.Property(e => e.Actiondate)
					.HasColumnName("actiondate")
					.HasColumnType("datetime");

				entity.Property(e => e.ContactPerson)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.HasColumnName("email")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Fax)
					.HasColumnName("fax")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.IsBlockingEmails).HasColumnName("isBlockingEmails");

				entity.Property(e => e.IsBlockingSms).HasColumnName("isBlockingSMS");

				entity.Property(e => e.Mobile)
					.HasColumnName("mobile")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Phone)
					.HasColumnName("phone")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PhysicalAddress)
					.HasColumnName("physicalAddress")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PhysicalCode)
					.HasColumnName("physicalCode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PostalAddress)
					.HasColumnName("postalAddress")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PostalCode)
					.HasColumnName("postalCode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SendToAccManager).HasColumnName("sendToAccManager");

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.Type).HasColumnName("type");

				entity.Property(e => e.Website)
					.HasColumnName("website")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AlpmultiplierOverride>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("ALPMultiplierOverride");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(50)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.ValidFrom).HasColumnType("date");

				entity.Property(e => e.ValidTo).HasColumnType("date");
			});

			modelBuilder.Entity<ApiSessionActivities>(entity =>
			{
				entity.ToTable("api_SessionActivities");

				entity.Property(e => e.Action)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Controller)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkSessionId).HasColumnName("FK_SessionId");

				entity.HasOne(d => d.FkSession)
					.WithMany(p => p.ApiSessionActivities)
					.HasForeignKey(d => d.FkSessionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_api_SessionActivities_api_Sessions");
			});

			modelBuilder.Entity<ApiSessions>(entity =>
			{
				entity.ToTable("api_Sessions");

				entity.HasIndex(e => e.SessionId)
					.HasName("IX_api_SessionsId");

				entity.Property(e => e.AccountName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.AccountNumber)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CustomerEmail)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CustomerName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Expire).HasColumnType("datetime");

				entity.Property(e => e.RemoteHost)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.XfxAccountId).HasColumnName("XFX_AccountId");

				entity.Property(e => e.XfxCustomerId).HasColumnName("XFX_CustomerId");

				entity.Property(e => e.XfxPriceGroupId).HasColumnName("XFX_PriceGroupId");
			});

			modelBuilder.Entity<ApplicationUpdate>(entity =>
			{
				entity.HasKey(e => new { e.ApplicationKey, e.VersionKey });

				entity.Property(e => e.Hash)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ApprovedJobCardUsers>(entity =>
			{
				entity.HasIndex(e => e.ReferenceNumber)
					.HasName("ix_ApprovedJobCardUsers_ReferenceNumber");

				entity.HasIndex(e => new { e.JobCardId, e.Status, e.Created })
					.HasName("IX_ApprovedJobCardUsers_Created");

				entity.Property(e => e.BirthDay)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(200)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(200)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.ReferenceNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AudOrderQuery>(entity =>
			{
				entity.HasKey(e => e.Aid);

				entity.ToTable("aud_OrderQuery");

				entity.Property(e => e.Aid).HasColumnName("aid");

				entity.Property(e => e.Actiondate)
					.HasColumnName("actiondate")
					.HasColumnType("datetime");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkReasonId).HasColumnName("FK_ReasonId");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.OrderId).HasColumnName("OrderID");

				entity.Property(e => e.QueryData)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.ResolvedData).IsUnicode(false);

				entity.Property(e => e.ResolvedOn).HasColumnType("datetime");
			});

			modelBuilder.Entity<AudOrderQueryLines>(entity =>
			{
				entity.HasKey(e => e.Aid);

				entity.ToTable("aud_OrderQueryLines");

				entity.Property(e => e.Aid).HasColumnName("aid");

				entity.Property(e => e.Actiondate)
					.HasColumnName("actiondate")
					.HasColumnType("datetime");

				entity.Property(e => e.FkDocumentNumber)
					.HasColumnName("FK_DocumentNumber")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkQueryId).HasColumnName("FK_Query_Id");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Barcode>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Barcode1)
					.IsRequired()
					.HasColumnName("barcode")
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Random).HasColumnName("random");

				entity.Property(e => e.Used).HasColumnName("used");
			});

			modelBuilder.Entity<Batch>(entity =>
			{
				entity.HasIndex(e => e.Number);

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.BranchCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.DueDate).HasColumnType("datetime");

				entity.Property(e => e.FromBranchCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<BatchedBaskets>(entity =>
			{
				entity.HasKey(e => new { e.FkBatch, e.FkBasket });

				entity.Property(e => e.FkBatch).HasColumnName("FK_Batch");

				entity.Property(e => e.FkBasket).HasColumnName("FK_Basket");

				entity.HasOne(d => d.FkBatchNavigation)
					.WithMany(p => p.BatchedBaskets)
					.HasForeignKey(d => d.FkBatch)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedBaskets_Batch");
			});

			modelBuilder.Entity<BatchedBatch>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.BatchedBatchFkNavigation)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedBatch_Batch1");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.BatchedBatchPkNavigation)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedBatch_Batch");
			});

			modelBuilder.Entity<BatchedJobCards>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.BatchedJobCards)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedJobCards_BatchesOfJobCards");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.BatchedJobCards)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedJobCards_JobCardsInBatch");
			});

			modelBuilder.Entity<BatchedOrders>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.BatchedOrders)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedOrders_BatchesOfOrders");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.BatchedOrders)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedOrders_OrdersInBatches");
			});

			modelBuilder.Entity<BatchedParcels>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.BatchedParcels)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedParcels_Parcel");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.BatchedParcels)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedParcels_Batch");
			});

			modelBuilder.Entity<BatchedShipments>(entity =>
			{
				entity.HasKey(e => new { e.FkBatchId, e.FkShipmentId });

				entity.Property(e => e.FkBatchId).HasColumnName("FK_BatchId");

				entity.Property(e => e.FkShipmentId).HasColumnName("FK_ShipmentId");

				entity.HasOne(d => d.FkBatch)
					.WithMany(p => p.BatchedShipments)
					.HasForeignKey(d => d.FkBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedShipments_Batch");
			});

			modelBuilder.Entity<BatchedStock>(entity =>
			{
				entity.HasIndex(e => e.FkBatchId)
					.HasName("NonClusteredIndex-20180515-112301");

				entity.Property(e => e.FkBatchId).HasColumnName("FK_BatchId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBatch)
					.WithMany(p => p.BatchedStock)
					.HasForeignKey(d => d.FkBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchedStock_Batch");
			});

			modelBuilder.Entity<BatchStockContent>(entity =>
			{
				entity.Property(e => e.FkBatchId).HasColumnName("FK_BatchId");

				entity.Property(e => e.FkOrderId).HasColumnName("FK_OrderId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BatchTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.BatchTracking)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchTracking_Tracking");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.BatchTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BatchTracking_Batch");
			});

			modelBuilder.Entity<BrandCuring>(entity =>
			{
				entity.HasKey(e => e.CuringId);

				entity.ToTable("Brand_Curing");

				entity.Property(e => e.CuringId).ValueGeneratedNever();
			});

			modelBuilder.Entity<BrandDepartments>(entity =>
			{
				entity.HasKey(e => e.DepartmentId);

				entity.ToTable("Brand_Departments");

				entity.Property(e => e.DepartmentId).ValueGeneratedNever();

				entity.Property(e => e.Name).IsRequired();
			});

			modelBuilder.Entity<BrandGroupCuring>(entity =>
			{
				entity.HasKey(e => e.GroupCurintId);

				entity.ToTable("Brand_Group_Curing");

				entity.Property(e => e.GroupCurintId).ValueGeneratedNever();

				entity.Property(e => e.BrandCuringCuringId).HasColumnName("Brand_Curing_CuringId");

				entity.Property(e => e.BrandItemGroupGroupId).HasColumnName("Brand_ItemGroup_GroupId");

				entity.Property(e => e.BrandMethodDepartmentId).HasColumnName("Brand_MethodDepartmentId");

				entity.HasOne(d => d.BrandCuringCuring)
					.WithMany(p => p.BrandGroupCuring)
					.HasForeignKey(d => d.BrandCuringCuringId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_CuringBrand_Group_Curing");

				entity.HasOne(d => d.BrandItemGroupGroup)
					.WithMany(p => p.BrandGroupCuring)
					.HasForeignKey(d => d.BrandItemGroupGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemGroupBrand_Group_Curing");

				entity.HasOne(d => d.BrandMethodDepartment)
					.WithMany(p => p.BrandGroupCuring)
					.HasForeignKey(d => d.BrandMethodDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_MethodBrand_Group_Curing");
			});

			modelBuilder.Entity<BrandGroupItem>(entity =>
			{
				entity.HasKey(e => e.GroupItemId);

				entity.ToTable("Brand_GroupItem");

				entity.Property(e => e.GroupItemId).ValueGeneratedNever();

				entity.Property(e => e.BaseCode)
					.IsRequired()
					.HasMaxLength(15);

				entity.Property(e => e.BrandItemGroupGroupId).HasColumnName("Brand_ItemGroupGroupId");

				entity.HasOne(d => d.BrandItemGroupGroup)
					.WithMany(p => p.BrandGroupItem)
					.HasForeignKey(d => d.BrandItemGroupGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemGroupBrand_GroupItem");
			});

			modelBuilder.Entity<BrandGroupQuantities>(entity =>
			{
				entity.HasKey(e => e.GroupQuantityId);

				entity.ToTable("Brand_GroupQuantities");

				entity.Property(e => e.GroupQuantityId).ValueGeneratedNever();

				entity.Property(e => e.BrandItemGroupGroupId).HasColumnName("Brand_ItemGroupGroupId");

				entity.Property(e => e.BrandMethodDepartmentId).HasColumnName("Brand_MethodDepartmentId");

				entity.Property(e => e.BrandQuantityQuantityId).HasColumnName("Brand_Quantity_QuantityId");

				entity.HasOne(d => d.BrandItemGroupGroup)
					.WithMany(p => p.BrandGroupQuantities)
					.HasForeignKey(d => d.BrandItemGroupGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemGroupBrand_GroupQuantities");

				entity.HasOne(d => d.BrandMethodDepartment)
					.WithMany(p => p.BrandGroupQuantities)
					.HasForeignKey(d => d.BrandMethodDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_MethodBrand_GroupQuantities");

				entity.HasOne(d => d.BrandQuantityQuantity)
					.WithMany(p => p.BrandGroupQuantities)
					.HasForeignKey(d => d.BrandQuantityQuantityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_GroupQuantitiesBrand_Quantity");
			});

			modelBuilder.Entity<BrandingConversionAccountSwitch>(entity =>
			{
				entity.HasKey(e => new { e.AccountManagerId, e.AccountId });

				entity.Property(e => e.AccountManagerId).HasColumnName("AccountManagerID");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");
			});

			modelBuilder.Entity<BrandingInstructions>(entity =>
			{
				entity.HasIndex(e => e.FkBrandingVersion)
					.HasName("ix_BrandingInstructions_FK_BrandingVersion");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkBrandingVersion).HasColumnName("FK_BrandingVersion");

				entity.Property(e => e.FkInstructionId).HasColumnName("FK_InstructionId");

				entity.Property(e => e.Instruction)
					.IsRequired()
					.HasMaxLength(2000)
					.IsUnicode(false);

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.HasOne(d => d.FkBrandingVersionNavigation)
					.WithMany(p => p.BrandingInstructions)
					.HasForeignKey(d => d.FkBrandingVersion)
					.HasConstraintName("FK_BrandingInstructions_JobcardBrandingInstructionVersions");
			});

			modelBuilder.Entity<BrandItemCuring>(entity =>
			{
				entity.HasKey(e => e.ItemCuringId);

				entity.ToTable("Brand_Item_Curing");

				entity.Property(e => e.ItemCuringId).ValueGeneratedNever();

				entity.Property(e => e.BrandCuringCuringId).HasColumnName("Brand_Curing_CuringId");

				entity.Property(e => e.BrandItemItemId).HasColumnName("Brand_Item_ItemId");

				entity.Property(e => e.BrandMethodDepartmentId).HasColumnName("Brand_MethodDepartmentId");

				entity.HasOne(d => d.BrandCuringCuring)
					.WithMany(p => p.BrandItemCuring)
					.HasForeignKey(d => d.BrandCuringCuringId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_CuringBrand_Item_Curing");

				entity.HasOne(d => d.BrandItemItem)
					.WithMany(p => p.BrandItemCuring)
					.HasForeignKey(d => d.BrandItemItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemBrand_Item_Curing");

				entity.HasOne(d => d.BrandMethodDepartment)
					.WithMany(p => p.BrandItemCuring)
					.HasForeignKey(d => d.BrandMethodDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_MethodBrand_Item_Curing");
			});

			modelBuilder.Entity<BrandItemGroup>(entity =>
			{
				entity.HasKey(e => e.GroupId);

				entity.ToTable("Brand_ItemGroup");

				entity.Property(e => e.GroupId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<BrandItemQuantities>(entity =>
			{
				entity.HasKey(e => e.ItemQuantityId);

				entity.ToTable("Brand_ItemQuantities");

				entity.Property(e => e.ItemQuantityId).ValueGeneratedNever();

				entity.Property(e => e.BrandDepartmentDepartmentId).HasColumnName("Brand_DepartmentDepartmentId");

				entity.Property(e => e.BrandItemItemId).HasColumnName("Brand_ItemItemId");

				entity.Property(e => e.BrandQuantityQuantityId).HasColumnName("Brand_Quantity_QuantityId");

				entity.HasOne(d => d.BrandDepartmentDepartment)
					.WithMany(p => p.BrandItemQuantities)
					.HasForeignKey(d => d.BrandDepartmentDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_DepartmentBrand_ItemQuantities");

				entity.HasOne(d => d.BrandItemItem)
					.WithMany(p => p.BrandItemQuantities)
					.HasForeignKey(d => d.BrandItemItemId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemBrand_ItemQuantities");

				entity.HasOne(d => d.BrandQuantityQuantity)
					.WithMany(p => p.BrandItemQuantities)
					.HasForeignKey(d => d.BrandQuantityQuantityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemQuantitiesBrand_Quantity");
			});

			modelBuilder.Entity<BrandItems>(entity =>
			{
				entity.HasKey(e => e.ItemId);

				entity.ToTable("Brand_Items");

				entity.Property(e => e.ItemId).ValueGeneratedNever();

				entity.Property(e => e.BaseCode).IsRequired();
			});

			modelBuilder.Entity<BrandItemTypeQuantities>(entity =>
			{
				entity.HasKey(e => e.ItemTypeQuantityId);

				entity.ToTable("Brand_ItemType_Quantities");

				entity.Property(e => e.ItemTypeQuantityId).ValueGeneratedNever();

				entity.Property(e => e.BrandItemTypeId).HasColumnName("Brand_ItemTypeId");

				entity.Property(e => e.BrandMethodId).HasColumnName("Brand_MethodId");

				entity.Property(e => e.BrandQuantityQuantityId).HasColumnName("Brand_Quantity_QuantityId");

				entity.HasOne(d => d.BrandItemType)
					.WithMany(p => p.BrandItemTypeQuantities)
					.HasForeignKey(d => d.BrandItemTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemTypeBrand_ItemType_Quantities");

				entity.HasOne(d => d.BrandMethod)
					.WithMany(p => p.BrandItemTypeQuantities)
					.HasForeignKey(d => d.BrandMethodId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_DepartmentBrand_ItemType_Quantities");

				entity.HasOne(d => d.BrandQuantityQuantity)
					.WithMany(p => p.BrandItemTypeQuantities)
					.HasForeignKey(d => d.BrandQuantityQuantityId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Brand_ItemType_QuantitiesBrand_Quantity");
			});

			modelBuilder.Entity<BrandItemTypes>(entity =>
			{
				entity.HasKey(e => e.ItemTypeId);

				entity.ToTable("Brand_ItemTypes");

				entity.Property(e => e.ItemTypeId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.RegEx)
					.IsRequired()
					.HasMaxLength(255);
			});

			modelBuilder.Entity<BrandQuantities>(entity =>
			{
				entity.HasKey(e => e.QuantityId);

				entity.ToTable("Brand_Quantities");

				entity.Property(e => e.QuantityId).ValueGeneratedNever();
			});

			modelBuilder.Entity<CheckInReportData>(entity =>
			{
				entity.Property(e => e.DateTime).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ClBatchContents>(entity =>
			{
				entity.ToTable("clBatchContents");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkBatchId).HasColumnName("FK_BatchId");

				entity.Property(e => e.FkOrderId).HasColumnName("FK_OrderId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.SgStatus).HasColumnName("sgStatus");

				entity.Property(e => e.TerminalIp)
					.HasColumnName("TerminalIP")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBatch)
					.WithMany(p => p.ClBatchContents)
					.HasForeignKey(d => d.FkBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_clBatchContents_clBatchContents");

				entity.HasOne(d => d.FkOrder)
					.WithMany(p => p.ClBatchContents)
					.HasForeignKey(d => d.FkOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_clBatchContents_Order");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.ClBatchContents)
					.HasForeignKey(d => d.FkUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_clBatchContents_User");
			});

			modelBuilder.Entity<CmtProcess>(entity =>
			{
				entity.HasKey(e => e.JobcardId);

				entity.ToTable("CMT_Process");

				entity.Property(e => e.JobcardId).ValueGeneratedNever();

				entity.Property(e => e.Cmt).HasColumnName("CMT");

				entity.Property(e => e.Jcp).HasColumnName("JCP");
			});

			modelBuilder.Entity<ContactWebInfo>(entity =>
			{
				entity.HasKey(e => new { e.AccountNumber, e.Email });

				entity.Property(e => e.AccountNumber)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Bday)
					.HasColumnName("bday")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Position)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Surname)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditLimitGroups>(entity =>
			{
				entity.HasIndex(e => e.Name)
					.HasName("IX_CreditLimitGroups")
					.IsUnique();

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Flags).HasColumnName("flags");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditNote>(entity =>
			{
				entity.HasIndex(e => e.Number)
					.HasName("NonClusteredIndex-20130222-111453");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasColumnName("barcode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Date)
					.HasColumnName("date")
					.HasColumnType("datetime");

				entity.Property(e => e.Flags).HasColumnName("flags");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PastelInvoiceNumber)
					.HasColumnName("pastelInvoiceNumber")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.TotalExcl).HasColumnName("totalExcl");

				entity.Property(e => e.TotalIncl).HasColumnName("totalIncl");

				entity.Property(e => e.VatAmount).HasColumnName("vatAmount");

				entity.Property(e => e.WarehouseNumber)
					.HasColumnName("warehouseNumber")
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditNoteAccount>(entity =>
			{
				entity.HasKey(e => e.Pk);

				entity.Property(e => e.Pk)
					.HasColumnName("pk")
					.ValueGeneratedNever();

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteAccount)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteAccount_Account");

				entity.HasOne(d => d.PkNavigation)
					.WithOne(p => p.CreditNoteAccount)
					.HasForeignKey<CreditNoteAccount>(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteAccount_CreditNote");
			});

			modelBuilder.Entity<CreditNoteAttachment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Filename)
					.HasColumnName("filename")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.RelativePath)
					.HasColumnName("relativePath")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type)
					.IsRequired()
					.HasColumnName("type")
					.HasMaxLength(55)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditNoteAttachments>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_CreditNoteAttachments")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.CreditNoteAttachments)
					.HasForeignKey<CreditNoteAttachments>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteAttachments_Attachment");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteAttachments)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteAttachments_CreditNote");
			});

			modelBuilder.Entity<CreditNoteAuthorizer>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteAuthorizer)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteAuthorizer_User");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteAuthorizer)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteAuthorizer_CreditNoteRequest");
			});

			modelBuilder.Entity<CreditNoteCreditNoteRequest>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk);

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteCreditNoteRequest)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteCreditNoteRequest_CreditNoteRequest");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteCreditNoteRequest)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteCreditNoteRequest_CreditNote");
			});

			modelBuilder.Entity<CreditNoteDetail>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_CreditNoteDetail")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.CreditNoteDetail)
					.HasForeignKey<CreditNoteDetail>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteDetail_CreditNoteForLines");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteDetail)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteDetail_Lines");
			});

			modelBuilder.Entity<CreditNoteOrder>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => new { e.Pk, e.Fk })
					.HasName("IX_CreditNoteOrder_fk");

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteOrder)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteOrder_Order");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteOrder)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteOrder_CreditNote");
			});

			modelBuilder.Entity<CreditNotePackaging>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNotePackaging)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNotePackaging_Parcel");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNotePackaging)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNotePackaging_CreditNote");
			});

			modelBuilder.Entity<CreditNoteRequest>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.CancelationFee).HasColumnName("cancelationFee");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.FkApprovalManagerId).HasColumnName("fk_approvalManagerId");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.ProjectCode)
					.HasColumnName("projectCode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.RequestNumber)
					.IsRequired()
					.HasColumnName("requestNumber")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.RequestReason)
					.IsRequired()
					.HasColumnName("requestReason")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditNoteRequestDetail>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteRequestDetail)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestDetail_Line");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteRequestDetail)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestDetail_CreditNoteRequest");
			});

			modelBuilder.Entity<CreditNoteRequester>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteRequester)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequester_User");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteRequester)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequester_CreditNoteRequest");

				entity.HasOne(d => d.CreditNoteRequesterNavigation)
					.WithOne(p => p.InverseCreditNoteRequesterNavigation)
					.HasForeignKey<CreditNoteRequester>(d => new { d.Pk, d.Fk })
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Table_1_Table_1");
			});

			modelBuilder.Entity<CreditNoteRequestEx>(entity =>
			{
				entity.HasKey(e => e.CreditNoteRequestId);

				entity.ToTable("CreditNoteRequestEX");

				entity.Property(e => e.CreditNoteRequestId)
					.HasColumnName("CreditNoteRequestID")
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<CreditNoteRequestNotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteRequestNotes)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestNotes_Note");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteRequestNotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestNotes_CreditNoteRequest");
			});

			modelBuilder.Entity<CreditNoteRequestOrder>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk);

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteRequestOrder)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestOrder_Order");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteRequestOrder)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestOrder_CreditNoteRequest");
			});

			modelBuilder.Entity<CreditNoteRequestPaymentApprovedNotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteRequestPaymentApprovedNotes)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestPaymentApprovedNotes_Note");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteRequestPaymentApprovedNotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestPaymentApprovedNotes_CreditNoteRequest");
			});

			modelBuilder.Entity<CreditNoteRequestTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteRequestTracking)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestTracking_Tracking");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteRequestTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteRequestTracking_CreditNoteRequest");
			});

			modelBuilder.Entity<CreditNoteShelvedStock>(entity =>
			{
				entity.HasKey(e => new { e.LineId, e.CreditNoteId });

				entity.Property(e => e.LineId).HasColumnName("LineID");

				entity.Property(e => e.CreditNoteId).HasColumnName("CreditNoteID");

				entity.Property(e => e.RecomendedShelf)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ShelfChosen)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.CreditNote)
					.WithMany(p => p.CreditNoteShelvedStock)
					.HasForeignKey(d => d.CreditNoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteShelvedStock_CreditNote");

				entity.HasOne(d => d.Line)
					.WithMany(p => p.CreditNoteShelvedStock)
					.HasForeignKey(d => d.LineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteShelvedStock_Line");
			});

			modelBuilder.Entity<CreditNoteTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => new { e.Pk, e.Fk })
					.HasName("IX_CreditNoteTracking_fk");

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.CreditNoteTracking)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteTracking_Tracking");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CreditNoteTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CreditNoteTracking_CreditNote");
			});

			modelBuilder.Entity<CreditReceipt>(entity =>
			{
				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.StockItem)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditReturnReceipt>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CsStockTake>(entity =>
			{
				entity.ToTable("csStockTake");

				entity.HasIndex(e => e.Number)
					.HasName("IX_csStockTake")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkOwnerId).HasColumnName("FK_OwnerId");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkOwner)
					.WithMany(p => p.CsStockTake)
					.HasForeignKey(d => d.FkOwnerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_csStockTake_User");
			});

			modelBuilder.Entity<CsStockTakeParcel>(entity =>
			{
				entity.ToTable("csStockTakeParcel");

				entity.Property(e => e.DateScanned).HasColumnType("datetime");

				entity.Property(e => e.FkParcelId).HasColumnName("FK_ParcelId");

				entity.Property(e => e.FkStockTakeShelfId).HasColumnName("FK_StockTakeShelfId");

				entity.HasOne(d => d.FkStockTakeShelf)
					.WithMany(p => p.CsStockTakeParcel)
					.HasForeignKey(d => d.FkStockTakeShelfId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_csStockTakeParcel_csStockTakeShelf");
			});

			modelBuilder.Entity<CsStockTakeResolved>(entity =>
			{
				entity.ToTable("csStockTakeResolved");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkStockTakeId).HasColumnName("FK_StockTakeId");

				entity.Property(e => e.FkStockTakeParcelId).HasColumnName("FK_StockTakeParcelId");

				entity.Property(e => e.FkStockTakeSnapshotId).HasColumnName("FK_StockTakeSnapshotId");
			});

			modelBuilder.Entity<CsStockTakeShelf>(entity =>
			{
				entity.ToTable("csStockTakeShelf");

				entity.Property(e => e.FkShelfId).HasColumnName("FK_ShelfId");

				entity.Property(e => e.FkStockTakeId).HasColumnName("FK_StockTakeId");

				entity.HasOne(d => d.FkStockTake)
					.WithMany(p => p.CsStockTakeShelf)
					.HasForeignKey(d => d.FkStockTakeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_csStockTakeShelf_csStockTake");
			});

			modelBuilder.Entity<CsStockTakeSnapshot>(entity =>
			{
				entity.ToTable("csStockTakeSnapshot");

				entity.HasIndex(e => new { e.Id, e.FkParcelId, e.FkStockTakeShelfId, e.FkOrderId })
					.HasName("IX_StockTakeSnapshot_Shelf_Order");

				entity.Property(e => e.FkOrderId).HasColumnName("FK_OrderId");

				entity.Property(e => e.FkParcelId).HasColumnName("FK_ParcelId");

				entity.Property(e => e.FkStockTakeShelfId).HasColumnName("FK_StockTakeShelfId");

				entity.HasOne(d => d.FkStockTakeShelf)
					.WithMany(p => p.CsStockTakeSnapshot)
					.HasForeignKey(d => d.FkStockTakeShelfId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_csStockTakeSnapshot_csStockTakeShelf");
			});

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Email)
					.IsRequired()
					.HasColumnName("email")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Firstname)
					.IsRequired()
					.HasColumnName("firstname")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Fullname)
					.IsRequired()
					.HasColumnName("fullname")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Lastname)
					.IsRequired()
					.HasColumnName("lastname")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Mobile)
					.IsRequired()
					.HasColumnName("mobile")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Phone)
					.IsRequired()
					.HasColumnName("phone")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");
			});

			modelBuilder.Entity<CustomerQuotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_CustomerQuotes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.CustomerQuotes)
					.HasForeignKey<CustomerQuotes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CustomerQuotes_Quote");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.CustomerQuotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CustomerQuotes_Customer");
			});

			modelBuilder.Entity<CustomerTeirs>(entity =>
			{
				entity.HasIndex(e => e.Customercode);

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Currentamount).HasColumnName("currentamount");

				entity.Property(e => e.Customercode)
					.IsRequired()
					.HasColumnName("customercode")
					.HasMaxLength(20);

				entity.Property(e => e.Flags).HasColumnName("flags");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.PreTurnoverValue).HasColumnName("preTurnoverValue");

				entity.Property(e => e.PrevBrandingAmount).HasColumnName("prevBrandingAmount");

				entity.Property(e => e.PrevClothingAmount).HasColumnName("prevClothingAmount");

				entity.Property(e => e.PrevGiftAmount).HasColumnName("prevGiftAmount");

				entity.Property(e => e.Previousamount).HasColumnName("previousamount");

				entity.Property(e => e.Teir).HasColumnName("teir");
			});

			modelBuilder.Entity<DeletedParcel>(entity =>
			{
				entity.HasKey(e => e.ParcelId);

				entity.HasIndex(e => e.JobCardId)
					.HasName("ix_DeletedParcel_JobCardId");

				entity.HasIndex(e => e.OrderId);

				entity.Property(e => e.ParcelId).ValueGeneratedNever();

				entity.Property(e => e.DateDeleted).HasColumnType("datetime");
			});

			modelBuilder.Entity<DeletedParcelBatches>(entity =>
			{
				entity.HasKey(e => new { e.ParcelId, e.BatchId });
			});

			modelBuilder.Entity<DeletedParcelTrackings>(entity =>
			{
				entity.HasKey(e => new { e.ParcelId, e.TrackingId });
			});

			modelBuilder.Entity<DeliveryRequest>(entity =>
			{
				entity.HasIndex(e => e.AccountId)
					.HasName("NonClusteredIndex-20180515-112413");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.ContactEmail)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactNameAlternate)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactNumber)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.ContactNumberAlternate)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DeliveryAddress)
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.DeliveryArea)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

				entity.Property(e => e.DeliveryText).IsUnicode(false);

				entity.Property(e => e.Driver)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.HasOne(d => d.Account)
					.WithMany(p => p.DeliveryRequest)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequest_Account");
			});

			modelBuilder.Entity<DeliveryRequestContents>(entity =>
			{
				entity.HasIndex(e => new { e.DeliveryRequestId, e.OrderId })
					.HasName("NonClusteredIndex-20180515-112216");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.DeliveryRequestId).HasColumnName("DeliveryRequestID");

				entity.Property(e => e.OrderId).HasColumnName("OrderID");

				entity.HasOne(d => d.DeliveryRequest)
					.WithMany(p => p.DeliveryRequestContents)
					.HasForeignKey(d => d.DeliveryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequestContents_DeliveryRequest");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.DeliveryRequestContents)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequestContents_Order");
			});

			modelBuilder.Entity<DeliveryRequestTracking>(entity =>
			{
				entity.HasKey(e => new { e.DeliveryRequestId, e.TrackingId });

				entity.Property(e => e.DeliveryRequestId).HasColumnName("DeliveryRequestID");

				entity.Property(e => e.TrackingId).HasColumnName("TrackingID");

				entity.HasOne(d => d.DeliveryRequest)
					.WithMany(p => p.DeliveryRequestTracking)
					.HasForeignKey(d => d.DeliveryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequestTracking_DeliveryRequest");

				entity.HasOne(d => d.Tracking)
					.WithMany(p => p.DeliveryRequestTracking)
					.HasForeignKey(d => d.TrackingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequestTracking_Tracking");
			});

			modelBuilder.Entity<DualJobCardLink>(entity =>
			{
				entity.HasIndex(e => e.MasterJobId)
					.HasName("IX_DualJobMAters");

				entity.HasIndex(e => new { e.OrderId, e.SubJobId })
					.HasName("IX_DualJobOrderToJobId");
			});

			modelBuilder.Entity<EmailLog>(entity =>
			{
				entity.HasKey(e => e.LogId);

				entity.Property(e => e.LogId).HasColumnName("LogID");

				entity.Property(e => e.Attachments).IsUnicode(false);

				entity.Property(e => e.Bcc)
					.HasColumnName("BCC")
					.IsUnicode(false);

				entity.Property(e => e.Cc)
					.HasColumnName("CC")
					.IsUnicode(false);

				entity.Property(e => e.DateSent).HasColumnType("datetime");

				entity.Property(e => e.Recipients)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.Subject)
					.IsRequired()
					.HasMaxLength(1024)
					.IsUnicode(false);
			});

			modelBuilder.Entity<EmbroideryQuoteRequest>(entity =>
			{
				entity.HasIndex(e => new { e.Author, e.CustomerId })
					.HasName("NonClusteredIndex-20180515-112144");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.CustomerEmail)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

				entity.Property(e => e.PriceCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.AuthorNavigation)
					.WithMany(p => p.EmbroideryQuoteRequest)
					.HasForeignKey(d => d.Author)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EmbroideryQuoteRequest_User");

				entity.HasOne(d => d.Customer)
					.WithMany(p => p.EmbroideryQuoteRequest)
					.HasForeignKey(d => d.CustomerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EmbroideryQuoteRequest_Account");
			});

			modelBuilder.Entity<EmbroideryQuoteRequestAttachment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.EmbroideryRequestId).HasColumnName("EmbroideryRequestID");

				entity.Property(e => e.Filename)
					.IsRequired()
					.HasColumnName("filename")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.EmbroideryRequest)
					.WithMany(p => p.EmbroideryQuoteRequestAttachment)
					.HasForeignKey(d => d.EmbroideryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EmbroideryQuoteRequestAttachment_EmbroideryQuoteRequest");
			});

			modelBuilder.Entity<EmbroideryQuoteRequestDetails>(entity =>
			{
				entity.HasKey(e => new { e.EmbroideryRequestId, e.PositionNo });

				entity.Property(e => e.EmbroideryRequestId).HasColumnName("EmbroideryRequestID");

				entity.Property(e => e.Price).HasColumnType("money");

				entity.HasOne(d => d.EmbroideryRequest)
					.WithMany(p => p.EmbroideryQuoteRequestDetails)
					.HasForeignKey(d => d.EmbroideryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EmbroideryQuoteRequestDetails_EmbroideryQuoteRequest");
			});

			modelBuilder.Entity<EmbroideryQuoteRequestNotes>(entity =>
			{
				entity.HasKey(e => new { e.EmbroideryRequestId, e.PositionNo, e.NoteId });

				entity.Property(e => e.EmbroideryRequestId).HasColumnName("EmbroideryRequestID");

				entity.Property(e => e.NoteId).HasColumnName("NoteID");
			});

			modelBuilder.Entity<EmbroideryQuoteRequestPositionDetail>(entity =>
			{
				entity.HasKey(e => new { e.EmbroideryRequestId, e.PositionNo });

				entity.Property(e => e.EmbroideryRequestId).HasColumnName("EmbroideryRequestID");

				entity.Property(e => e.Colours)
					.IsRequired()
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.Logo)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Position)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.RepeatJob)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.StockToBrand)
					.IsRequired()
					.IsUnicode(false);

				entity.HasOne(d => d.EmbroideryRequest)
					.WithMany(p => p.EmbroideryQuoteRequestPositionDetail)
					.HasForeignKey(d => d.EmbroideryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EmbroideryQuoteRequestPositionDetail_EmbroideryQuoteRequest");
			});

			modelBuilder.Entity<EmbroideryQuoteRequestTracking>(entity =>
			{
				entity.HasKey(e => new { e.QuoteRequestId, e.PositionNo, e.TrackingId });

				entity.Property(e => e.QuoteRequestId).HasColumnName("QuoteRequestID");

				entity.Property(e => e.TrackingId).HasColumnName("TrackingID");

				entity.HasOne(d => d.QuoteRequest)
					.WithMany(p => p.EmbroideryQuoteRequestTracking)
					.HasForeignKey(d => d.QuoteRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EmbroideryQuoteRequestTracking_EmbroideryQuoteRequest");

				entity.HasOne(d => d.Tracking)
					.WithMany(p => p.EmbroideryQuoteRequestTracking)
					.HasForeignKey(d => d.TrackingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EmbroideryQuoteRequestTracking_Tracking");
			});

			modelBuilder.Entity<ExUser>(entity =>
			{
				entity.HasKey(e => e.UserId);

				entity.ToTable("EX_User");

				entity.Property(e => e.UserId)
					.HasColumnName("UserID")
					.ValueGeneratedNever();

				entity.Property(e => e.Department).IsUnicode(false);

				entity.Property(e => e.PastelCode)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.User)
					.WithOne(p => p.ExUser)
					.HasForeignKey<ExUser>(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EX_User_User");
			});

			modelBuilder.Entity<FaultyGoodsRequests>(entity =>
			{
				entity.HasKey(e => e.RequestId);

				entity.Property(e => e.RequestId).HasColumnName("RequestID");

				entity.Property(e => e.DateClosed).HasColumnType("datetime");

				entity.Property(e => e.DateRequested).HasColumnType("datetime");

				entity.Property(e => e.FullfilledDate).HasColumnType("datetime");

				entity.Property(e => e.LineId).HasColumnName("LineID");

				entity.HasOne(d => d.ClosedByNavigation)
					.WithMany(p => p.FaultyGoodsRequestsClosedByNavigation)
					.HasForeignKey(d => d.ClosedBy)
					.HasConstraintName("FK_FaultyGoodsRequests_ClosedBy");

				entity.HasOne(d => d.FullfilledByNavigation)
					.WithMany(p => p.FaultyGoodsRequestsFullfilledByNavigation)
					.HasForeignKey(d => d.FullfilledBy)
					.HasConstraintName("FK_FaultyGoodsRequests_FullfilledBy");

				entity.HasOne(d => d.Line)
					.WithMany(p => p.FaultyGoodsRequests)
					.HasForeignKey(d => d.LineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_FaultyGoodsRequests_Line");

				entity.HasOne(d => d.RequestedByNavigation)
					.WithMany(p => p.FaultyGoodsRequestsRequestedByNavigation)
					.HasForeignKey(d => d.RequestedBy)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_FaultyGoodsRequests_RequestedBy");
			});

			modelBuilder.Entity<GenericTrackings>(entity =>
			{
				entity.HasKey(e => e.EntityId);

				entity.Property(e => e.EntityId).ValueGeneratedNever();

				entity.Property(e => e.TrackingDate).HasColumnType("datetime");

				entity.Property(e => e.TrackingExtra).IsRequired();
			});

			modelBuilder.Entity<Inventory>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(150)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InventoryStock>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_InventoryStock")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.InventoryStock)
					.HasForeignKey<InventoryStock>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InventoryStock_Stock");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.InventoryStock)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InventoryStock_Inventory");
			});

			modelBuilder.Entity<InvoiceAttachment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Filename)
					.HasColumnName("filename")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.RelativePath)
					.HasColumnName("relativePath")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type)
					.IsRequired()
					.HasColumnName("type")
					.HasMaxLength(55)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InvoiceAttachments>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_InvoiceAttachments")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.InvoiceAttachments)
					.HasForeignKey<InvoiceAttachments>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InvoiceAttachments_Attachment");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.InvoiceAttachments)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InvoiceAttachments_Invoice");
			});

			modelBuilder.Entity<JobCard>(entity =>
			{
				entity.HasIndex(e => new { e.Id, e.LogoName })
					.HasName("IX_LogoSearch");

				entity.HasIndex(e => new { e.Id, e.Number })
					.HasName("ix_JobCard_number_includes");

				entity.HasIndex(e => new { e.Status, e.Created })
					.HasName("IX_JobCardStatus");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.CancelledReason)
					.HasColumnName("cancelledReason")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Colours)
					.IsRequired()
					.HasColumnName("colours")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactPerson)
					.HasColumnName("contactPerson")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.DueDate)
					.HasColumnName("dueDate")
					.HasColumnType("datetime");

				entity.Property(e => e.Flag).HasColumnName("flag");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.IsLogoRedrawRequired).HasColumnName("isLogoRedrawRequired");

				entity.Property(e => e.IsRepeatJob).HasColumnName("isRepeatJob");

				entity.Property(e => e.IsSampleRequired).HasColumnName("isSampleRequired");

				entity.Property(e => e.LogoName)
					.HasColumnName("logoName")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.RepeatJobCardLayoutReference)
					.HasColumnName("repeatJobCardLayoutReference")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.RepeatJobInvoiceNumber)
					.HasColumnName("repeatJobInvoiceNumber")
					.HasMaxLength(50);

				entity.Property(e => e.SizeAndPosition)
					.IsRequired()
					.HasColumnName("sizeAndPosition")
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.SpecialInstructions)
					.IsRequired()
					.HasColumnName("specialInstructions")
					.HasMaxLength(2049)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");
			});

			modelBuilder.Entity<JobCardAccountContacts>(entity =>
			{
				entity.HasKey(e => new { e.JobCardFk, e.AccountContactFk });

				entity.Property(e => e.JobCardFk).HasColumnName("JobCard_FK");

				entity.Property(e => e.AccountContactFk).HasColumnName("AccountContact_FK");

				entity.HasOne(d => d.AccountContactFkNavigation)
					.WithMany(p => p.JobCardAccountContacts)
					.HasForeignKey(d => d.AccountContactFk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardAccountContacts_AccountContacts");

				entity.HasOne(d => d.JobCardFkNavigation)
					.WithMany(p => p.JobCardAccountContacts)
					.HasForeignKey(d => d.JobCardFk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardAccountContacts_JobCard");
			});

			modelBuilder.Entity<JobCardAttachment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FileUrl)
					.HasColumnName("fileUrl")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Filename)
					.HasColumnName("filename")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.RelativePath)
					.HasColumnName("relativePath")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<JobCardAttachments>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardAttachments")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardAttachments)
					.HasForeignKey<JobCardAttachments>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardAttachments_JobCardForAttachments");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardAttachments)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardAttachments_Attachments");
			});

			modelBuilder.Entity<JobcardBrandingInstructionVersions>(entity =>
			{
				entity.HasIndex(e => new { e.JobCardId, e.Status })
					.HasName("ix_JobcardBrandingInstructionVersions_JobCardId_Status");

				entity.Property(e => e.BrandingPosition)
					.HasMaxLength(2)
					.IsUnicode(false);

				entity.Property(e => e.Colours)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactPerson)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Instruction)
					.HasMaxLength(2000)
					.IsUnicode(false);

				entity.Property(e => e.LogoName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.LogoPos)
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.LogoSize)
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.PrintColour)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<JobCardCustomerNotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardCustomerNotes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardCustomerNotes)
					.HasForeignKey<JobCardCustomerNotes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardCustomerNotes_JobCard");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardCustomerNotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardCustomerNotes_NotesForJobCard");
			});

			modelBuilder.Entity<JobCardDates>(entity =>
			{
				entity.HasIndex(e => e.FkJobCardId)
					.HasName("ix_JobCardDates_FK_JobCardId");

				entity.Property(e => e.ActionDate).HasColumnType("datetime");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DateApproved).HasColumnType("date");

				entity.Property(e => e.DateCleared).HasColumnType("date");

				entity.Property(e => e.DueDate).HasColumnType("datetime");

				entity.Property(e => e.FkJobCardId).HasColumnName("FK_JobCardId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.ProductionDueDate).HasColumnType("date");
			});

			modelBuilder.Entity<JobCardEmbroideryQuoteRequest>(entity =>
			{
				entity.HasKey(e => e.JobCardId);

				entity.Property(e => e.JobCardId)
					.HasColumnName("JobCardID")
					.ValueGeneratedNever();

				entity.Property(e => e.EmbroideryRequestId).HasColumnName("EmbroideryRequestID");

				entity.HasOne(d => d.EmbroideryRequest)
					.WithMany(p => p.JobCardEmbroideryQuoteRequest)
					.HasForeignKey(d => d.EmbroideryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardEmbroideryQuoteRequest_EmbroideryQuoteRequest");

				entity.HasOne(d => d.JobCard)
					.WithOne(p => p.JobCardEmbroideryQuoteRequest)
					.HasForeignKey<JobCardEmbroideryQuoteRequest>(d => d.JobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardEmbroideryQuoteRequest_JobCard");
			});

			modelBuilder.Entity<JobCardEx>(entity =>
			{
				entity.HasKey(e => e.JobCardId);

				entity.ToTable("JobCardEX");

				entity.Property(e => e.JobCardId)
					.HasColumnName("JobCardID")
					.ValueGeneratedNever();

				entity.Property(e => e.SalesRep)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.JobCard)
					.WithOne(p => p.JobCardEx)
					.HasForeignKey<JobCardEx>(d => d.JobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardEX_JobCard");
			});

			modelBuilder.Entity<JobCardEx2>(entity =>
			{
				entity.HasKey(e => e.JobCardId);

				entity.ToTable("JobCardEX2");

				entity.Property(e => e.JobCardId)
					.HasColumnName("JobCardID")
					.ValueGeneratedNever();

				entity.Property(e => e.SalesRep)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.JobCard)
					.WithOne(p => p.JobCardEx2)
					.HasForeignKey<JobCardEx2>(d => d.JobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardEX2_JobCard");
			});

			modelBuilder.Entity<JobCardLayouts>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardLayouts")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardLayouts)
					.HasForeignKey<JobCardLayouts>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardLayouts_JobCardForLayouts");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardLayouts)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardLayouts_LayoutsForJobCard");
			});

			modelBuilder.Entity<JobCardLeadtimeTracking>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Descriptor)
					.IsRequired()
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.FkJobCardId).HasColumnName("fk_JobCardId");

				entity.Property(e => e.ModifiedSource)
					.IsRequired()
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.User)
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.HasOne(d => d.FkJobCard)
					.WithMany(p => p.JobCardLeadtimeTracking)
					.HasForeignKey(d => d.FkJobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardLeadtimeTracking_JobCardId");
			});

			modelBuilder.Entity<JobCardNotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardNotes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardNotes)
					.HasForeignKey<JobCardNotes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardNotes_JobCard");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardNotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardNotes_NotesForJobCard");
			});

			modelBuilder.Entity<JobCardPackaging>(entity =>
			{
				entity.HasKey(e => new { e.JobCardId, e.ParcelId });

				entity.HasIndex(e => e.ParcelId)
					.HasName("TEST_JobCardPackaging_ParcelID");

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.ParcelId).HasColumnName("ParcelID");
			});

			modelBuilder.Entity<JobCardPacker>(entity =>
			{
				entity.HasKey(e => e.JobCardId);

				entity.Property(e => e.JobCardId)
					.HasColumnName("JobCardID")
					.ValueGeneratedNever();

				entity.Property(e => e.Packer)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<JobCardPackingNotes>(entity =>
			{
				entity.HasKey(e => new { e.JobCardId, e.PackingNoteId });

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.PackingNoteId).HasColumnName("PackingNoteID");
			});

			modelBuilder.Entity<JobCardPrintingProcess>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardPrintingProcess")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardPrintingProcess)
					.HasForeignKey<JobCardPrintingProcess>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardPrintingProcess_PrintProcess");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardPrintingProcess)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardPrintingProcess_JobCardsForPrintProcess");
			});

			modelBuilder.Entity<JobCardQuery>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkReasonId).HasColumnName("FK_ReasonId");

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.QueryData)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.ResolvedData).IsUnicode(false);

				entity.Property(e => e.ResolvedOn).HasColumnType("datetime");

				entity.HasOne(d => d.AuthorNavigation)
					.WithMany(p => p.JobCardQueryAuthorNavigation)
					.HasForeignKey(d => d.Author)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardQuerry_User");

				entity.HasOne(d => d.FkReason)
					.WithMany(p => p.JobCardQuery)
					.HasForeignKey(d => d.FkReasonId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardQuery_QueryReasonCode");

				entity.HasOne(d => d.JobCard)
					.WithMany(p => p.JobCardQuery)
					.HasForeignKey(d => d.JobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardQuerry_JobCard");

				entity.HasOne(d => d.ResolvedByNavigation)
					.WithMany(p => p.JobCardQueryResolvedByNavigation)
					.HasForeignKey(d => d.ResolvedBy)
					.HasConstraintName("FK_JobCardQuerry_User1");
			});

			modelBuilder.Entity<JobCardQueue>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardQueue")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardQueue)
					.HasForeignKey<JobCardQueue>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardQueue_Queue");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardQueue)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardQueue_JobCardsInQueue");
			});

			modelBuilder.Entity<JobCardRelations>(entity =>
			{
				entity.HasKey(e => new { e.StockJobCardId, e.AdditionalJobCardId });

				entity.Property(e => e.StockJobCardId).HasColumnName("StockJobCardID");

				entity.Property(e => e.AdditionalJobCardId).HasColumnName("AdditionalJobCardID");
			});

			modelBuilder.Entity<JobCardsForPrintLines>(entity =>
			{
				entity.HasKey(e => e.Pk);

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardsForPrintLines_FK")
					.IsUnique();

				entity.Property(e => e.Pk)
					.HasColumnName("pk")
					.ValueGeneratedNever();

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardsForPrintLines)
					.HasForeignKey<JobCardsForPrintLines>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardsForPrintLines_JobCardPrintLineItem");

				entity.HasOne(d => d.PkNavigation)
					.WithOne(p => p.JobCardsForPrintLines)
					.HasForeignKey<JobCardsForPrintLines>(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardsForPrintLines_PrintLineItemJobCard");
			});

			modelBuilder.Entity<JobCardSpecialInstructions>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_JobCardSpecialInstructions")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("PK");

				entity.Property(e => e.Fk).HasColumnName("FK");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.JobCardSpecialInstructions)
					.HasForeignKey<JobCardSpecialInstructions>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardSpecialInstructions_SpecialInstuctions");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardSpecialInstructions)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardSpecialInstructions_JobCard");
			});

			modelBuilder.Entity<JobCardStatusIndex>(entity =>
			{
				entity.Property(e => e.ClientStatusText)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<JobCardSurplus>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<JobCardTeamLeader>(entity =>
			{
				entity.HasKey(e => new { e.FkLeaderId, e.FkJobtId });

				entity.HasIndex(e => new { e.FkLeaderId, e.FkJobtId })
					.HasName("IX_JobCardTeamLeader_JobId_LeaderId");

				entity.Property(e => e.FkLeaderId).HasColumnName("fk_leaderId");

				entity.Property(e => e.FkJobtId).HasColumnName("fk_JobtId");
			});

			modelBuilder.Entity<JobcardTimesheetRecords>(entity =>
			{
				entity.HasKey(e => e.RecordId);

				entity.Property(e => e.RecordId).ValueGeneratedNever();

				entity.Property(e => e.JobCompleted).HasColumnType("datetime");

				entity.Property(e => e.JobcardNumber)
					.IsRequired()
					.HasMaxLength(12)
					.IsUnicode(false);

				entity.Property(e => e.Machine).HasMaxLength(6);

				entity.Property(e => e.SetupComplete).HasColumnType("datetime");

				entity.Property(e => e.Started).HasColumnType("datetime");
			});

			modelBuilder.Entity<JobCardTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => new { e.Pk, e.Fk })
					.HasName("IX_JobCardTracking_FK");

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.JobCardTracking)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardTracking_JobCardTracks");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.JobCardTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_JobCardTracking_TracksForJobCard");
			});

			modelBuilder.Entity<Layout>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Comments)
					.IsRequired()
					.HasColumnName("comments")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Options).HasColumnName("options");

				entity.Property(e => e.RelativePath)
					.HasColumnName("relativePath")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Revision).HasColumnName("revision");

				entity.Property(e => e.Status).HasColumnName("status");
			});

			modelBuilder.Entity<LayoutArtistBusyWith>(entity =>
			{
				entity.HasKey(e => new { e.LayoutArtistId, e.JobCardId });

				entity.HasIndex(e => new { e.LayoutArtistId, e.JobCardId })
					.HasName("ix_LayoutArtistBusyWith_JobCardId_includes");

				entity.Property(e => e.LayoutFinished).HasColumnType("datetime");

				entity.Property(e => e.LayoutStarted).HasColumnType("datetime");
			});

			modelBuilder.Entity<LayoutArtists>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_LayoutArtists")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.LayoutArtists)
					.HasForeignKey<LayoutArtists>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LayoutArtists_Artist");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LayoutArtists)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LayoutArtists_LayoutsForArtist");
			});

			modelBuilder.Entity<LayoutOptions>(entity =>
			{
				entity.HasIndex(e => e.FkLayoutId)
					.HasName("ix_LayoutOptions_fk_Layout_Id");

				entity.HasIndex(e => new { e.OptionNumber, e.FkLayoutId })
					.HasName("IX_LayoutOptions")
					.IsUnique();

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.FkLayoutId).HasColumnName("fk_Layout_Id");

				entity.Property(e => e.Flags).HasColumnName("flags");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.OptionNumber).HasColumnName("optionNumber");

				entity.Property(e => e.PageNumbers)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.RelativePath)
					.HasColumnName("relativePath")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.StringValue)
					.HasColumnName("stringValue")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkLayout)
					.WithMany(p => p.LayoutOptions)
					.HasForeignKey(d => d.FkLayoutId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LayoutOptions_Layout");
			});

			modelBuilder.Entity<LayoutReject>(entity =>
			{
				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.FkLayoutId).HasColumnName("FK_LayoutId");

				entity.Property(e => e.Reason)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LayoutTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_LayoutTracking")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.LayoutTracking)
					.HasForeignKey<LayoutTracking>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LayoutTracking_Layout");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LayoutTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LayoutTracking_TracksForLayout");
			});

			modelBuilder.Entity<LayoutUpdateData>(entity =>
			{
				entity.Property(e => e.FkCreatedUserId).HasColumnName("FK_CreatedUserId");

				entity.Property(e => e.FkJobCardId).HasColumnName("FK_JobCardId");

				entity.Property(e => e.FkUpdatedUserId).HasColumnName("FK_UpdatedUserId");

				entity.Property(e => e.JobCardCreated).HasColumnType("datetime");

				entity.Property(e => e.JobCardUpdated).HasColumnType("datetime");
			});

			modelBuilder.Entity<LdItemsAtGlx>(entity =>
			{
				entity.ToTable("LD_ItemsAtGLX");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkBasket).HasColumnName("Fk_Basket");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<LdmAdjustment>(entity =>
			{
				entity.ToTable("ldmAdjustment");

				entity.Property(e => e.FkDepartmentId).HasColumnName("FK_DepartmentId");

				entity.Property(e => e.FkGroupId).HasColumnName("FK_GroupId");

				entity.HasOne(d => d.FkDepartment)
					.WithMany(p => p.LdmAdjustment)
					.HasForeignKey(d => d.FkDepartmentId)
					.HasConstraintName("FK_ldmAdjustment_ldmDepartments");

				entity.HasOne(d => d.FkGroup)
					.WithMany(p => p.LdmAdjustment)
					.HasForeignKey(d => d.FkGroupId)
					.HasConstraintName("FK_ldmAdjustment_ldmGroups");
			});

			modelBuilder.Entity<LdmAdjustmentTrackings>(entity =>
			{
				entity.ToTable("ldmAdjustmentTrackings");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkDepartmentId).HasColumnName("FK_DepartmentId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkDepartment)
					.WithMany(p => p.LdmAdjustmentTrackings)
					.HasForeignKey(d => d.FkDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmAdjustmentTrackings_ldmDepartments");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.LdmAdjustmentTrackings)
					.HasForeignKey(d => d.FkUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmAdjustmentTrackings_User");
			});

			modelBuilder.Entity<LdmDepartments>(entity =>
			{
				entity.ToTable("ldmDepartments");

				entity.HasIndex(e => e.FkPrintDepartmentId)
					.HasName("UK_ldmDepartments")
					.IsUnique();

				entity.Property(e => e.FkPrintDepartmentId).HasColumnName("FK_PrintDepartmentId");

				entity.HasOne(d => d.FkPrintDepartment)
					.WithOne(p => p.LdmDepartments)
					.HasForeignKey<LdmDepartments>(d => d.FkPrintDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmDepartments_PrintDepartment");
			});

			modelBuilder.Entity<LdmGroupItems>(entity =>
			{
				entity.ToTable("ldmGroupItems");

				entity.HasIndex(e => new { e.FkGroupId, e.BaseItemCode })
					.HasName("UK_ldmGroupItems")
					.IsUnique();

				entity.Property(e => e.BaseItemCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.FkGroupId).HasColumnName("FK_GroupId");

				entity.HasOne(d => d.FkGroup)
					.WithMany(p => p.LdmGroupItems)
					.HasForeignKey(d => d.FkGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmGroupItems_ldmGroups");
			});

			modelBuilder.Entity<LdmGroupLeadtimes>(entity =>
			{
				entity.ToTable("ldmGroupLeadtimes");

				entity.HasIndex(e => new { e.FkGroupId, e.QtyMin, e.QtyMax })
					.HasName("UK_ldmGroupLeadtimes")
					.IsUnique();

				entity.Property(e => e.FkGroupId).HasColumnName("FK_GroupId");

				entity.HasOne(d => d.FkGroup)
					.WithMany(p => p.LdmGroupLeadtimes)
					.HasForeignKey(d => d.FkGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmGroupLeadtimes_ldmGroups");
			});

			modelBuilder.Entity<LdmGroups>(entity =>
			{
				entity.ToTable("ldmGroups");

				entity.HasIndex(e => new { e.FkDepartmentId, e.Name })
					.HasName("UK_ldmGroupName")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkDepartmentId).HasColumnName("FK_DepartmentId");

				entity.Property(e => e.FltInventoryType).HasColumnName("fltInventoryType");

				entity.Property(e => e.FltPrefix)
					.HasColumnName("fltPrefix")
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.FltPrintCode)
					.HasColumnName("fltPrintCode")
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDepartment)
					.WithMany(p => p.LdmGroups)
					.HasForeignKey(d => d.FkDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmGroups_ldmDepartments");
			});

			modelBuilder.Entity<LdmPackingRules>(entity =>
			{
				entity.ToTable("ldmPackingRules");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LdmPackingRuleValues>(entity =>
			{
				entity.ToTable("ldmPackingRuleValues");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkPackingRuleId).HasColumnName("FK_PackingRuleId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.HasOne(d => d.FkPackingRule)
					.WithMany(p => p.LdmPackingRuleValues)
					.HasForeignKey(d => d.FkPackingRuleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmPackingRuleValues_ldmPackingRule");
			});

			modelBuilder.Entity<LdmPersonalization>(entity =>
			{
				entity.ToTable("ldmPersonalization");

				entity.Property(e => e.FkDepartmentId).HasColumnName("FK_DepartmentId");

				entity.HasOne(d => d.FkDepartment)
					.WithMany(p => p.LdmPersonalization)
					.HasForeignKey(d => d.FkDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmPersonalization_ldmDepartments");
			});

			modelBuilder.Entity<LdmStitchCounts>(entity =>
			{
				entity.ToTable("ldmStitchCounts");

				entity.Property(e => e.FkDepartmentId).HasColumnName("FK_DepartmentId");

				entity.HasOne(d => d.FkDepartment)
					.WithMany(p => p.LdmStitchCounts)
					.HasForeignKey(d => d.FkDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ldmStitchCounts_ldmDepartments");
			});

			modelBuilder.Entity<LeadTimes>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.LeadTime).HasColumnName("leadTime");

				entity.Property(e => e.PrintDepartmentId).HasColumnName("printDepartmentID");

				entity.Property(e => e.Quantity).HasColumnName("quantity");
			});

			modelBuilder.Entity<LeadTimesJobCard>(entity =>
			{
				entity.HasKey(e => new { e.JobCardId, e.PrintProcessId });

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.PrintProcessId).HasColumnName("PrintProcessID");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Flag).HasColumnName("flag");

				entity.Property(e => e.LeadTime).HasColumnName("leadTime");

				entity.Property(e => e.Notes)
					.IsRequired()
					.HasColumnName("notes")
					.HasMaxLength(4000)
					.IsUnicode(false);

				entity.HasOne(d => d.AssignedByNavigation)
					.WithMany(p => p.LeadTimesJobCard)
					.HasForeignKey(d => d.AssignedBy)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LeadTimesJobCard_User");

				entity.HasOne(d => d.JobCard)
					.WithMany(p => p.LeadTimesJobCard)
					.HasForeignKey(d => d.JobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LeadTimesJobCard_JobCard");

				entity.HasOne(d => d.PrintProcess)
					.WithMany(p => p.LeadTimesJobCard)
					.HasForeignKey(d => d.PrintProcessId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LeadTimesJobCard_PrintProcess");
			});

			modelBuilder.Entity<Level>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Line>(entity =>
			{
				entity.HasIndex(e => new { e.Id, e.StockCode })
					.HasName("<IDX_STOCKCODE_LINE, dbo,>");

				entity.HasIndex(e => new { e.Id, e.StockCode, e.ShelfNumber, e.RowNumber })
					.HasName("ix_Line_rowNumber_includes");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasColumnName("barcode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.LineAmountExcl).HasColumnName("lineAmountExcl");

				entity.Property(e => e.LineAmountIncl).HasColumnName("lineAmountIncl");

				entity.Property(e => e.LineVatAmount).HasColumnName("lineVatAmount");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Quantity).HasColumnName("quantity");

				entity.Property(e => e.RowNumber).HasColumnName("rowNumber");

				entity.Property(e => e.ShelfNumber)
					.IsRequired()
					.HasColumnName("shelfNumber")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.StockCode)
					.IsRequired()
					.HasColumnName("stockCode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type).HasColumnName("type");

				entity.Property(e => e.UnitPriceExcl).HasColumnName("unitPriceExcl");

				entity.Property(e => e.UnitPriceIncl).HasColumnName("unitPriceIncl");

				entity.Property(e => e.UnitVatAmount).HasColumnName("unitVatAmount");
			});

			modelBuilder.Entity<LineJobCards>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => new { e.Pk, e.Fk })
					.HasName("IX_JobCardLineItems");

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.LineJobCards)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineJobCards_JobCardLineItem");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LineJobCards)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineJobCards_PrintJobcards");
			});

			modelBuilder.Entity<LinkedBatches>(entity =>
			{
				entity.HasKey(e => new { e.BatchId, e.FkLinkBatchId });

				entity.HasIndex(e => e.FkLinkBatchId)
					.HasName("UK_LinkedBatch")
					.IsUnique();

				entity.Property(e => e.FkLinkBatchId).HasColumnName("FK_LinkBatchId");

				entity.HasOne(d => d.Batch)
					.WithMany(p => p.LinkedBatchesBatch)
					.HasForeignKey(d => d.BatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ParentBatch");

				entity.HasOne(d => d.FkLinkBatch)
					.WithOne(p => p.LinkedBatchesFkLinkBatch)
					.HasForeignKey<LinkedBatches>(d => d.FkLinkBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LinkedBatch");
			});

			modelBuilder.Entity<LinkedReturnStock>(entity =>
			{
				entity.HasIndex(e => new { e.JclineId, e.AccountId, e.JobCardId, e.UserId, e.OrderId })
					.HasName("LinkedReturnStock_Line_IX");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AccountId).HasColumnName("AccountID");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.JclineId).HasColumnName("JCLineID");

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.OrderId).HasColumnName("OrderID");

				entity.Property(e => e.Quantity).HasColumnName("quantity");

				entity.Property(e => e.StockCode)
					.IsRequired()
					.HasColumnName("stockCode")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.UserId).HasColumnName("UserID");

				entity.HasOne(d => d.Account)
					.WithMany(p => p.LinkedReturnStock)
					.HasForeignKey(d => d.AccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LinkedStockCode_Account");

				entity.HasOne(d => d.JobCard)
					.WithMany(p => p.LinkedReturnStock)
					.HasForeignKey(d => d.JobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LinkedStockCode_JobCard");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.LinkedReturnStock)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LinkedReturnStock_Order");

				entity.HasOne(d => d.User)
					.WithMany(p => p.LinkedReturnStock)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LinkedStockCode_User");
			});

			modelBuilder.Entity<LinkLineJobCards>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.LinkLineJobCards)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LinkLineJobCards_JobCard");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LinkLineJobCards)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LinkLineJobCards_Line");
			});

			modelBuilder.Entity<Location>(entity =>
			{
				entity.HasIndex(e => e.Barcode)
					.HasName("ix_Location_barcode");

				entity.HasIndex(e => new { e.Id, e.Barcode, e.Type, e.Status, e.Branch, e.Name })
					.HasName("ix_Location_name_includes");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Barcode)
					.HasColumnName("barcode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Branch)
					.HasColumnName("branch")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.NestedLevel).HasColumnName("nestedLevel");

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<LocationHierarchy>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_LocationHierarchy")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.LocationHierarchyFkNavigation)
					.HasForeignKey<LocationHierarchy>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationHierarchy_ParentLocation");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LocationHierarchyPkNavigation)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationHierarchy_SubLocations");
			});

			modelBuilder.Entity<LocationItems>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_LocationItems")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.LocationItems)
					.HasForeignKey<LocationItems>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationItems_CurrentLocation");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LocationItems)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationItems_ItemsInThisLocation");
			});

			modelBuilder.Entity<LocationJobCards>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_LocationJobCards")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.LocationJobCards)
					.HasForeignKey<LocationJobCards>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationJobCards_CurrentLocation");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LocationJobCards)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationJobCards_JobCardsInThisLocation");
			});

			modelBuilder.Entity<LocationSorting>(entity =>
			{
				entity.Property(e => e.FkLocationId).HasColumnName("FK_LocationId");

				entity.HasOne(d => d.FkLocation)
					.WithMany(p => p.LocationSorting)
					.HasForeignKey(d => d.FkLocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationSorting_Location");
			});

			modelBuilder.Entity<LocationTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.LocationTracking)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationTracking_Location");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.LocationTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LocationTracking_TracksForLocation");
			});

			modelBuilder.Entity<LogBranchScanning>(entity =>
			{
				entity.ToTable("log_BranchScanning");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Response)
					.IsRequired()
					.HasMaxLength(4000)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Lookup>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Description)
					.HasMaxLength(4000)
					.IsUnicode(false);

				entity.Property(e => e.Group)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LookupDocTypes>(entity =>
			{
				entity.HasKey(e => e.DocType);

				entity.ToTable("Lookup_DocTypes");

				entity.Property(e => e.DocType).ValueGeneratedNever();

				entity.Property(e => e.DocTypeCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.DocTypeDisplay)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LookupSort>(entity =>
			{
				entity.HasKey(e => e.Code);

				entity.Property(e => e.Code)
					.HasMaxLength(50)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.Group)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LqAllocation>(entity =>
			{
				entity.ToTable("lqAllocation");

				entity.HasIndex(e => e.FkOrderId)
					.HasName("ix_lqAllocation_FK_OrderId");

				entity.Property(e => e.DateAllocated).HasColumnType("datetime");

				entity.Property(e => e.FkJobCardId).HasColumnName("FK_JobCardId");

				entity.Property(e => e.FkOrderId).HasColumnName("FK_OrderId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkJobCard)
					.WithMany(p => p.LqAllocation)
					.HasForeignKey(d => d.FkJobCardId)
					.HasConstraintName("FK_lqAllocation_JobCard");

				entity.HasOne(d => d.FkOrder)
					.WithMany(p => p.LqAllocation)
					.HasForeignKey(d => d.FkOrderId)
					.HasConstraintName("FK_lqAllocation_Order");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.LqAllocation)
					.HasForeignKey(d => d.FkUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqAllocation_User");
			});

			modelBuilder.Entity<LqLayoutDocuments>(entity =>
			{
				entity.ToTable("lqLayoutDocuments");

				entity.HasIndex(e => e.FkQueueId)
					.HasName("ix_lqLayoutDocuments_FK_QueueId");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkQueueId).HasColumnName("FK_QueueId");

				entity.Property(e => e.Path)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkQueue)
					.WithMany(p => p.LqLayoutDocuments)
					.HasForeignKey(d => d.FkQueueId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqLayoutDocuments_lqQueue");
			});

			modelBuilder.Entity<LqLookupQueueTrackingTypes>(entity =>
			{
				entity.ToTable("lqLookupQueueTrackingTypes");

				entity.Property(e => e.TypeCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.TypeDescription)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LqQueue>(entity =>
			{
				entity.ToTable("lqQueue");

				entity.HasIndex(e => e.FkJobCardId)
					.HasName("IX_lqQueueJobCarItem")
					.IsUnique();

				entity.HasIndex(e => new { e.Id, e.FkJobCardId, e.Revision, e.Flags, e.Status })
					.HasName("ix_lqQueue_Status_includes");

				entity.Property(e => e.FkJobCardId).HasColumnName("FK_JobCardId");

				entity.HasOne(d => d.FkJobCard)
					.WithOne(p => p.LqQueue)
					.HasForeignKey<LqQueue>(d => d.FkJobCardId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueue_JobCard");
			});

			modelBuilder.Entity<LqQueueAccess>(entity =>
			{
				entity.ToTable("lqQueueAccess");

				entity.HasIndex(e => new { e.Id, e.Queue, e.FkForUserId, e.FkShiftId, e.AccessDate, e.FkAccessedById })
					.HasName("ix_lqQueueAccess_Queue_FK_ForUserId_FK_ShiftId_AccessDate_FK_AccessedById_includes");

				entity.Property(e => e.AccessDate).HasColumnType("datetime");

				entity.Property(e => e.FkAccessedById).HasColumnName("FK_AccessedById");

				entity.Property(e => e.FkForUserId).HasColumnName("FK_ForUserId");

				entity.Property(e => e.FkShiftId).HasColumnName("FK_ShiftId");

				entity.Property(e => e.Queue)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.HasOne(d => d.FkAccessedBy)
					.WithMany(p => p.LqQueueAccessFkAccessedBy)
					.HasForeignKey(d => d.FkAccessedById)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueueAccess_Author");

				entity.HasOne(d => d.FkForUser)
					.WithMany(p => p.LqQueueAccessFkForUser)
					.HasForeignKey(d => d.FkForUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueueAccess_UserQueue");

				entity.HasOne(d => d.FkShift)
					.WithMany(p => p.LqQueueAccess)
					.HasForeignKey(d => d.FkShiftId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueueAccess_lqShifts");
			});

			modelBuilder.Entity<LqQueueNotes>(entity =>
			{
				entity.ToTable("lqQueueNotes");

				entity.HasIndex(e => e.FkEventId)
					.HasName("IX_lqQueueEventNote")
					.IsUnique();

				entity.Property(e => e.FkEventId).HasColumnName("FK_EventId");

				entity.Property(e => e.Note)
					.IsRequired()
					.HasColumnType("ntext");

				entity.HasOne(d => d.FkEvent)
					.WithOne(p => p.LqQueueNotes)
					.HasForeignKey<LqQueueNotes>(d => d.FkEventId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueueNotes_lqQueueTracking");
			});

			modelBuilder.Entity<LqQueueTracking>(entity =>
			{
				entity.ToTable("lqQueueTracking");

				entity.HasIndex(e => new { e.FkQueueId, e.FkUserId, e.FkTypeId })
					.HasName("IX_LQTrackingQueueId");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkQueueId).HasColumnName("FK_QueueId");

				entity.Property(e => e.FkTypeId).HasColumnName("FK_TypeId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkQueue)
					.WithMany(p => p.LqQueueTracking)
					.HasForeignKey(d => d.FkQueueId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueueTracking_lqQueue");

				entity.HasOne(d => d.FkType)
					.WithMany(p => p.LqQueueTracking)
					.HasForeignKey(d => d.FkTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueueTracking_lqLookupQueueTrackingTypes");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.LqQueueTracking)
					.HasForeignKey(d => d.FkUserId)
					.HasConstraintName("FK_lqQueueTracking_User");
			});

			modelBuilder.Entity<LqQueueTypes>(entity =>
			{
				entity.ToTable("lqQueueTypes");

				entity.HasIndex(e => e.Code)
					.HasName("IX_lqQueueTypes")
					.IsUnique();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LqQueueTypeValues>(entity =>
			{
				entity.ToTable("lqQueueTypeValues");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkLqQueueTypeId).HasColumnName("FK_lqQueueTypeId");

				entity.Property(e => e.StringValue)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkLqQueueType)
					.WithMany(p => p.LqQueueTypeValues)
					.HasForeignKey(d => d.FkLqQueueTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_lqQueueTypeValues_lqQueueTypes");
			});

			modelBuilder.Entity<LqSettings>(entity =>
			{
				entity.ToTable("lqSettings");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.QueueTypeCode)
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<LqShifts>(entity =>
			{
				entity.ToTable("lqShifts");

				entity.HasIndex(e => e.Name)
					.HasName("UL_Shift")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.TimeEnd).HasColumnType("time(1)");

				entity.Property(e => e.TimeStart).HasColumnType("time(1)");
			});

			modelBuilder.Entity<Machines>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(6)
					.IsUnicode(false);

				entity.HasOne(d => d.DepartmentNavigation)
					.WithMany(p => p.Machines)
					.HasForeignKey(d => d.Department)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Machines_PrintDepartment");
			});

			modelBuilder.Entity<Note>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Author)
					.IsRequired()
					.HasColumnName("author")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Block).HasColumnName("block");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Text)
					.IsRequired()
					.HasColumnName("text")
					.IsUnicode(false);
			});

			modelBuilder.Entity<Notes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_Notes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.Notes)
					.HasForeignKey<Notes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Notes_Author");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.Notes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Notes_NotesForAuthor");
			});

			modelBuilder.Entity<Notification>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Data)
					.IsRequired()
					.HasColumnName("data")
					.HasColumnType("image");

				entity.Property(e => e.FailureReason)
					.HasColumnName("failureReason")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Format).HasColumnName("format");

				entity.Property(e => e.From)
					.HasColumnName("from")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Function).HasColumnName("function");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Recipients)
					.HasColumnName("recipients")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.Subject)
					.HasColumnName("subject")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<Order>(entity =>
			{
				entity.HasIndex(e => new { e.Id, e.Number })
					.HasName("ix_Order_number_includes");

				entity.HasIndex(e => new { e.Number, e.Date, e.Id })
					.HasName("_dta_index_Order_5_1592156888__K1_7_8");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Barcode)
					.HasColumnName("barcode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.CustomerReference)
					.HasColumnName("customerReference")
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Date)
					.HasColumnName("date")
					.HasColumnType("datetime");

				entity.Property(e => e.Flags).HasColumnName("flags");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.TotalExcl).HasColumnName("totalExcl");

				entity.Property(e => e.TotalIncl).HasColumnName("totalIncl");

				entity.Property(e => e.VatAmount).HasColumnName("vatAmount");

				entity.Property(e => e.WarehouseNumber)
					.HasColumnName("warehouseNumber")
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<OrderCustomerNotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_OrderCustomerNotes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.OrderCustomerNotes)
					.HasForeignKey<OrderCustomerNotes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderCustomerNotes_Order");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.OrderCustomerNotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderCustomerNotes_NotesForOrder");
			});

			modelBuilder.Entity<OrderDetail>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_OrderDetail")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.OrderDetail)
					.HasForeignKey<OrderDetail>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderDetail_OrderForLines");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.OrderDetail)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderDetail_Lines");
			});

			modelBuilder.Entity<OrderNotes>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_OrderNotes")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.OrderNotes)
					.HasForeignKey<OrderNotes>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderNotes_Order");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.OrderNotes)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderNotes_NotesForOrder");
			});

			modelBuilder.Entity<OrderQuery>(entity =>
			{
				entity.HasIndex(e => new { e.OrderId, e.Author, e.ResolvedBy, e.FkReasonId })
					.HasName("NonClusteredIndex-20180515-111832");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkReasonId).HasColumnName("FK_ReasonId");

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.OrderId).HasColumnName("OrderID");

				entity.Property(e => e.QueryData)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.ResolvedData).IsUnicode(false);

				entity.Property(e => e.ResolvedOn).HasColumnType("datetime");

				entity.HasOne(d => d.AuthorNavigation)
					.WithMany(p => p.OrderQueryAuthorNavigation)
					.HasForeignKey(d => d.Author)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderQuerry_User");

				entity.HasOne(d => d.FkReason)
					.WithMany(p => p.OrderQuery)
					.HasForeignKey(d => d.FkReasonId)
					.HasConstraintName("FK_OrderQuery_QueryReasonCode");

				entity.HasOne(d => d.Order)
					.WithMany(p => p.OrderQuery)
					.HasForeignKey(d => d.OrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderQuerry_Order");

				entity.HasOne(d => d.ResolvedByNavigation)
					.WithMany(p => p.OrderQueryResolvedByNavigation)
					.HasForeignKey(d => d.ResolvedBy)
					.HasConstraintName("FK_OrderQuerry_User1");
			});

			modelBuilder.Entity<OrderQueryLines>(entity =>
			{
				entity.HasKey(e => new { e.FkQueryId, e.ItemCode });

				entity.Property(e => e.FkQueryId).HasColumnName("FK_Query_Id");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.FkDocumentNumber)
					.HasColumnName("FK_DocumentNumber")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkQuery)
					.WithMany(p => p.OrderQueryLines)
					.HasForeignKey(d => d.FkQueryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderQueryLines");
			});

			modelBuilder.Entity<OrderRemoved>(entity =>
			{
				entity.Property(e => e.FloatValue).HasMaxLength(100);

				entity.Property(e => e.ProcessId)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.RemovedFrom).HasColumnType("date");

				entity.Property(e => e.RemovedTo).HasColumnType("date");

				entity.Property(e => e.StringValue).HasMaxLength(100);
			});

			modelBuilder.Entity<OrderStrikes>(entity =>
			{
				entity.HasKey(e => e.InvoiceNumber);

				entity.HasIndex(e => e.InvoiceNumber)
					.HasName("IX_OrderStrikeInvoiceNumber");

				entity.Property(e => e.InvoiceNumber)
					.HasMaxLength(8)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<OrderTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_OrderTracking")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.OrderTracking)
					.HasForeignKey<OrderTracking>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderTracking_OrderForTracks");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.OrderTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_OrderTracking_TracksForOrder");
			});

			modelBuilder.Entity<Packaging>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_Packaging")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.Packaging)
					.HasForeignKey<Packaging>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Packaging_ParcelOrder");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.Packaging)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Packaging_OrderParcels");
			});

			modelBuilder.Entity<PackingInstructions>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkBrandingVersion).HasColumnName("FK_BrandingVersion");

				entity.Property(e => e.FkInstructionId).HasColumnName("FK_InstructionId");

				entity.Property(e => e.Instruction)
					.IsRequired()
					.HasMaxLength(2000)
					.IsUnicode(false);

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.HasOne(d => d.FkBrandingVersionNavigation)
					.WithMany(p => p.PackingInstructions)
					.HasForeignKey(d => d.FkBrandingVersion)
					.HasConstraintName("FK_PackingInstructions_JobcardBrandingInstructionVersions");
			});

			modelBuilder.Entity<Parcel>(entity =>
			{
				entity.HasIndex(e => e.Barcode);

				entity.HasIndex(e => new { e.Id, e.Barcode, e.DisplayNumber, e.Status })
					.HasName("IX_ParcelStatusDetails");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasColumnName("barcode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.DisplayNumber)
					.IsRequired()
					.HasColumnName("displayNumber")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Number).HasColumnName("number");

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.Weight).HasColumnName("weight");
			});

			modelBuilder.Entity<ParcelLocations>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_ParcelLocations")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.ParcelLocations)
					.HasForeignKey<ParcelLocations>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ParcelLocations_ParcelLocation");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.ParcelLocations)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ParcelLocations_LocationParcels");
			});

			modelBuilder.Entity<ParcelStatusEnum>(entity =>
			{
				entity.HasKey(e => e.Status);

				entity.Property(e => e.Status).ValueGeneratedNever();

				entity.Property(e => e.StatusCode)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ParcelTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_ParcelTracking")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.ParcelTracking)
					.HasForeignKey<ParcelTracking>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ParcelTracking_TrackedParcel");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.ParcelTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ParcelTracking_ParcelTracks");
			});

			modelBuilder.Entity<PartialCollectionDetail>(entity =>
			{
				entity.HasKey(e => new { e.OrderId, e.ItemCode });

				entity.Property(e => e.OrderId).HasColumnName("OrderID");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<PastelWarehouse>(entity =>
			{
				entity.ToTable("Pastel_Warehouse");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.StoreCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Payment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Amount).HasColumnName("amount");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<PaymentInformation>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_PaymentInformation")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.PaymentInformation)
					.HasForeignKey<PaymentInformation>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PaymentInformation_OrderForPayment");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.PaymentInformation)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PaymentInformation_Payments");
			});

			modelBuilder.Entity<Permission>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Group)
					.HasColumnName("group")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<PermissionMatrix>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.PermissionMatrix)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PermissionMatrix_Levels");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.PermissionMatrix)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PermissionMatrix_LevelPermissions");
			});

			modelBuilder.Entity<PhysicalStockCountNotification>(entity =>
			{
				entity.HasKey(e => new { e.PhysicalStockCountRequestId, e.NotifyUserId });

				entity.Property(e => e.PhysicalStockCountRequestId).HasColumnName("PhysicalStockCountRequestID");

				entity.Property(e => e.NotifyUserId).HasColumnName("NotifyUserID");
			});

			modelBuilder.Entity<PhysicalStockCountRecipients>(entity =>
			{
				entity.HasIndex(e => e.PhysicalStockCountId)
					.HasName("IX_FK_PhysicalStockCountPhysicalStockCountRecipients");

				entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

				entity.HasOne(d => d.PhysicalStockCount)
					.WithMany(p => p.PhysicalStockCountRecipients)
					.HasForeignKey(d => d.PhysicalStockCountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PhysicalStockCountPhysicalStockCountRecipients");
			});

			modelBuilder.Entity<PhysicalStockCounts>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(15);
			});

			modelBuilder.Entity<PhysicalStockCountVariances>(entity =>
			{
				entity.HasIndex(e => e.PhysicalStockCountId)
					.HasName("IX_FK_PhysicalStockCountPhysicalStockCountVariance");

				entity.Property(e => e.DateAdjusted).HasColumnType("datetime");

				entity.Property(e => e.DateCounted).HasColumnType("datetime");

				entity.HasOne(d => d.PhysicalStockCount)
					.WithMany(p => p.PhysicalStockCountVariances)
					.HasForeignKey(d => d.PhysicalStockCountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PhysicalStockCountPhysicalStockCountVariance");
			});

			modelBuilder.Entity<Price>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.UnitPrice)
					.HasColumnName("unitPrice")
					.HasColumnType("decimal(18, 0)");
			});

			modelBuilder.Entity<Pricelist>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name).HasColumnName("name");
			});

			modelBuilder.Entity<PricePricelist>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_PricePricelist")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.PricePricelist)
					.HasForeignKey<PricePricelist>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PricePricelist_Pricelist");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.PricePricelist)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PricePricelist_Price");
			});

			modelBuilder.Entity<PriceRegime>(entity =>
			{
				entity.HasKey(e => e.Name);

				entity.Property(e => e.Name)
					.HasMaxLength(200)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<PrintAttributes>(entity =>
			{
				entity.Property(e => e.DbColumnName)
					.IsRequired()
					.HasColumnName("DB_ColumnName")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkPrintDepartmentId).HasColumnName("FK_PrintDepartment_Id");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Symbol)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkPrintDepartment)
					.WithMany(p => p.PrintAttributes)
					.HasForeignKey(d => d.FkPrintDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintAttributes_PrintDepartment");
			});

			modelBuilder.Entity<PrintAttributeValues>(entity =>
			{
				entity.HasIndex(e => new { e.FkPrintDepartmentId, e.ItemCode, e.Position })
					.HasName("UK_ItemPrintAttribute")
					.IsUnique();

				entity.Property(e => e.Comment).HasColumnType("text");

				entity.Property(e => e.CuringMethod)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkPrintDepartmentId).HasColumnName("FK_PrintDepartment_Id");

				entity.Property(e => e.Hardner)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Ink)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.Material)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Position)
					.IsRequired()
					.HasMaxLength(1)
					.IsUnicode(false);

				entity.Property(e => e.Primer)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Reduser)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkPrintDepartment)
					.WithMany(p => p.PrintAttributeValues)
					.HasForeignKey(d => d.FkPrintDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintAttributeValues_PrintDepartment");
			});

			modelBuilder.Entity<PrintDepartment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Code)
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<PrintDepartmentLeaders>(entity =>
			{
				entity.HasKey(e => e.FkUserId);

				entity.Property(e => e.FkUserId)
					.HasColumnName("fk_UserId")
					.ValueGeneratedNever();

				entity.Property(e => e.FkDepartmentId).HasColumnName("fk_DepartmentId");
			});

			modelBuilder.Entity<PrintDepartmentQueues>(entity =>
			{
				entity.HasKey(e => e.Fk);

				entity.HasIndex(e => e.Fk)
					.HasName("IX_PrintDepartmentQueues")
					.IsUnique();

				entity.Property(e => e.Fk)
					.HasColumnName("fk")
					.ValueGeneratedNever();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.PrintDepartmentQueues)
					.HasForeignKey<PrintDepartmentQueues>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintDepartmentQueues_Queues");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.PrintDepartmentQueues)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintDepartmentQueues_PrintDepartment");
			});

			modelBuilder.Entity<PrintDepartmentUsers>(entity =>
			{
				entity.HasKey(e => e.Pk);

				entity.HasIndex(e => e.Pk)
					.HasName("IX_PrintDepartmentUsers_PK")
					.IsUnique();

				entity.Property(e => e.Pk)
					.HasColumnName("pk")
					.ValueGeneratedNever();

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.PrintDepartmentUsers)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintDepartmentUsers_UserPrintDepartment");

				entity.HasOne(d => d.PkNavigation)
					.WithOne(p => p.PrintDepartmentUsers)
					.HasForeignKey<PrintDepartmentUsers>(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintDepartmentUsers_HeadOfDepartment");
			});

			modelBuilder.Entity<PrinterQueueAccess>(entity =>
			{
				entity.HasIndex(e => new { e.ComputerName, e.FkPrinterQueueId })
					.HasName("UK_PrinterQueueAccess")
					.IsUnique();

				entity.Property(e => e.ComputerName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkPrinterQueueId).HasColumnName("FK_PrinterQueueId");

				entity.HasOne(d => d.FkPrinterQueue)
					.WithMany(p => p.PrinterQueueAccess)
					.HasForeignKey(d => d.FkPrinterQueueId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrinterQueueAccess_PrinterQueues");
			});

			modelBuilder.Entity<PrinterQueues>(entity =>
			{
				entity.HasIndex(e => e.Name)
					.HasName("PK_PrinterQueue")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Folder)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<PrinterSessions>(entity =>
			{
				entity.HasIndex(e => new { e.FkApisessionId, e.FkPrinterQueueId })
					.HasName("UK_PrinterSessions")
					.IsUnique();

				entity.Property(e => e.FkApisessionId).HasColumnName("FK_APISessionId");

				entity.Property(e => e.FkPrinterQueueId).HasColumnName("FK_PrinterQueueId");

				entity.HasOne(d => d.FkApisession)
					.WithMany(p => p.PrinterSessions)
					.HasForeignKey(d => d.FkApisessionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrinterSessions_api_Sessions");

				entity.HasOne(d => d.FkPrinterQueue)
					.WithMany(p => p.PrinterSessions)
					.HasForeignKey(d => d.FkPrinterQueueId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrinterSessions_PrinterQueues");
			});

			modelBuilder.Entity<PrintingDepartmentProcesses>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_PrintingDepartmentProcesses")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.PrintingDepartmentProcesses)
					.HasForeignKey<PrintingDepartmentProcesses>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintingDepartmentProcesses_PrintDepartment");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.PrintingDepartmentProcesses)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintingDepartmentProcesses_PrintProcesses");
			});

			modelBuilder.Entity<PrintJobs>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_PrintJobs")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.PrintJobs)
					.HasForeignKey<PrintJobs>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintJobs_OrderForJobCard");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.PrintJobs)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PrintJobs_JobCards");
			});

			modelBuilder.Entity<PrintProcess>(entity =>
			{
				entity.HasIndex(e => e.Code)
					.HasName("UK_PrintProcess_Code")
					.IsUnique();

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasColumnName("code")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.NumberOfColours).HasColumnName("numberOfColours");
			});

			modelBuilder.Entity<ProductionQctask>(entity =>
			{
				entity.ToTable("Production_QCTask");

				entity.Property(e => e.FkDepartmentId).HasColumnName("FK_Department_ID");

				entity.Property(e => e.Owner)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Task)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ProductionStore>(entity =>
			{
				entity.HasKey(e => new { e.JobCardId, e.TrackingId });

				entity.Property(e => e.JobCardId).HasColumnName("JobCardID");

				entity.Property(e => e.TrackingId).HasColumnName("TrackingID");
			});

			modelBuilder.Entity<Province>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Name)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<QueryNotifications>(entity =>
			{
				entity.Property(e => e.FkReasonId).HasColumnName("FK_ReasonId");

				entity.Property(e => e.FkRecipientId).HasColumnName("FK_RecipientId");

				entity.Property(e => e.RecipientEmail)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Warehouse)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.HasOne(d => d.FkReason)
					.WithMany(p => p.QueryNotifications)
					.HasForeignKey(d => d.FkReasonId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_QueryNotifications_QueryReasonCode");

				entity.HasOne(d => d.FkRecipient)
					.WithMany(p => p.QueryNotifications)
					.HasForeignKey(d => d.FkRecipientId)
					.HasConstraintName("FK_QueryNotifications_User");
			});

			modelBuilder.Entity<QueryReasonCodes>(entity =>
			{
				entity.HasIndex(e => new { e.ReasonCode, e.Type })
					.HasName("UQ_QueryReasonCodes")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ReasonCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.ReasonDescription)
					.IsRequired()
					.HasMaxLength(1024)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Queues>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Priority).HasColumnName("priority");
			});

			modelBuilder.Entity<Quote>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasColumnName("number")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.QuoteNotes)
					.IsRequired()
					.HasColumnName("quoteNotes")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.QuoteStatus)
					.IsRequired()
					.HasColumnName("quoteStatus")
					.HasMaxLength(150)
					.IsUnicode(false);

				entity.Property(e => e.TotalExclVat).HasColumnName("totalExclVat");

				entity.Property(e => e.TotalInclVat).HasColumnName("totalInclVat");

				entity.Property(e => e.Vat).HasColumnName("vat");
			});

			modelBuilder.Entity<QuoteItem>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AmountInclVat).HasColumnName("amountInclVat");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasColumnName("itemCode")
					.HasMaxLength(150)
					.IsUnicode(false);

				entity.Property(e => e.LineNumber).HasColumnName("lineNumber");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Qty).HasColumnName("qty");

				entity.Property(e => e.Unit).HasColumnName("unit");

				entity.Property(e => e.UnitPriceExclVat).HasColumnName("unitPriceExclVat");

				entity.Property(e => e.Vat).HasColumnName("vat");
			});

			modelBuilder.Entity<QuoteItems>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_QuoteItems")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.QuoteItems)
					.HasForeignKey<QuoteItems>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_QuoteItems_QuoteItem");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.QuoteItems)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_QuoteItems_Quote");
			});

			modelBuilder.Entity<ReportMailers>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Exportcolumnsoverwrite)
					.HasColumnName("exportcolumnsoverwrite")
					.IsUnicode(false);

				entity.Property(e => e.Exportheadingoverwrite)
					.HasColumnName("exportheadingoverwrite")
					.IsUnicode(false);

				entity.Property(e => e.Heading)
					.IsRequired()
					.HasColumnName("heading")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Recipients)
					.IsRequired()
					.HasColumnName("recipients")
					.IsUnicode(false);

				entity.Property(e => e.Sql)
					.IsRequired()
					.HasColumnName("sql")
					.IsUnicode(false);
			});

			modelBuilder.Entity<ReportMailerSchedule>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Day).HasColumnName("day");

				entity.Property(e => e.Frequency).HasColumnName("frequency");

				entity.Property(e => e.Reportid).HasColumnName("reportid");

				entity.Property(e => e.Runtime)
					.HasColumnName("runtime")
					.HasColumnType("datetime");

				entity.HasOne(d => d.Report)
					.WithMany(p => p.ReportMailerSchedule)
					.HasForeignKey(d => d.Reportid)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReportMailerSchedule_ReportMailers");
			});

			modelBuilder.Entity<ReportOverride>(entity =>
			{
				entity.HasKey(e => new { e.OrderId, e.ReportId });

				entity.Property(e => e.OrderId).HasColumnName("OrderID");

				entity.Property(e => e.ReportId)
					.HasColumnName("ReportID")
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.DisplayOverride)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.UserId).HasColumnName("UserID");
			});

			modelBuilder.Entity<Resource>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<ResourcePermissions>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithMany(p => p.ResourcePermissions)
					.HasForeignKey(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ResourcePermissions_Resources");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.ResourcePermissions)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ResourcePermissions_Permissions");
			});

			modelBuilder.Entity<RestoreData>(entity =>
			{
				entity.HasKey(e => e.OrderNumber);

				entity.ToTable("restoreData");

				entity.Property(e => e.OrderNumber)
					.HasMaxLength(8)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.Shelf)
					.HasMaxLength(6)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ReturnedBatchDetail>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_ReturnedOrderDetail")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.ReturnedBatchDetail)
					.HasForeignKey<ReturnedBatchDetail>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReturnedBatchDetail_ReturnedLine");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.ReturnedBatchDetail)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReturnedBatchDetail_Batch");
			});

			modelBuilder.Entity<ReturnedLine>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasColumnName("code")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Quantity).HasColumnName("quantity");

				entity.Property(e => e.RowNumber).HasColumnName("rowNumber");
			});

			modelBuilder.Entity<RushAccounts>(entity =>
			{
				entity.HasIndex(e => new { e.FkAccount, e.XfkCustomerId })
					.HasName("IX_RushAccounts")
					.IsUnique();

				entity.Property(e => e.AccessToken)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkAccount).HasColumnName("FK_Account");

				entity.Property(e => e.WebCustomerEmail)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.WebCustomerFirstName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.WebCustomerLastName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.XfkCustomerId).HasColumnName("XFK_CustomerId");

				entity.HasOne(d => d.FkAccountNavigation)
					.WithMany(p => p.RushAccounts)
					.HasForeignKey(d => d.FkAccount)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RushAccounts_Account");
			});

			modelBuilder.Entity<RushStaging>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<SalesRepresentatives>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_SalesRepresentatives")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.SalesRepresentatives)
					.HasForeignKey<SalesRepresentatives>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SalesRepresentatives_AccountManager");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.SalesRepresentatives)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SalesRepresentatives_OrdersPlaced");
			});

			modelBuilder.Entity<SecurityLevels>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_SecurityLevels")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.SecurityLevels)
					.HasForeignKey<SecurityLevels>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SecurityLevels_Level");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.SecurityLevels)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SecurityLevels_Users");
			});

			modelBuilder.Entity<Setting>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.BoolValue).HasColumnName("boolValue");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.DateValue)
					.HasColumnName("dateValue")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FloatValue).HasColumnName("floatValue");

				entity.Property(e => e.Group)
					.IsRequired()
					.HasColumnName("group")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.IntegralValue).HasColumnName("integralValue");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Protection).HasColumnName("protection");

				entity.Property(e => e.StringValue)
					.HasColumnName("stringValue")
					.HasMaxLength(4096)
					.IsUnicode(false);

				entity.Property(e => e.Type).HasColumnName("type");
			});

			modelBuilder.Entity<ShAccountShippingInfoes>(entity =>
			{
				entity.HasKey(e => e.AccountNumber);

				entity.ToTable("shAccountShippingInfoes");

				entity.Property(e => e.AccountNumber)
					.HasMaxLength(10)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.RamEcfuelSurcharge).HasColumnName("ramECFuelSurcharge");

				entity.Property(e => e.RamEcmaxWeight).HasColumnName("ramECMaxWeight");

				entity.Property(e => e.RamEcminCharge).HasColumnName("ramECMinCharge");

				entity.Property(e => e.RamEcperKg).HasColumnName("ramECPerKG");

				entity.Property(e => e.RamEcwaybillSurcharge).HasColumnName("ramECWaybillSurcharge");

				entity.Property(e => e.RamHub)
					.IsRequired()
					.HasColumnName("ramHUB")
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.RamHubtype)
					.IsRequired()
					.HasColumnName("ramHUBType")
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Shelves>(entity =>
			{
				entity.HasKey(e => e.Name);

				entity.ToTable("_shelves");

				entity.Property(e => e.Name)
					.HasColumnName("name")
					.HasMaxLength(20)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<SpecialInstuctions>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.StringValue)
					.HasColumnName("stringValue")
					.HasMaxLength(2049)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StatsFinancial>(entity =>
			{
				entity.HasKey(e => new { e.Year, e.Month });

				entity.ToTable("stats_Financial");

				entity.Property(e => e.CosBranding).HasColumnName("cosBranding");

				entity.Property(e => e.CosClothing).HasColumnName("cosClothing");

				entity.Property(e => e.CosGifts).HasColumnName("cosGifts");

				entity.Property(e => e.CosHeadwear).HasColumnName("cosHeadwear");

				entity.Property(e => e.NtBranding).HasColumnName("ntBranding");

				entity.Property(e => e.NtClothing).HasColumnName("ntClothing");

				entity.Property(e => e.NtGifts).HasColumnName("ntGifts");

				entity.Property(e => e.NtHeadwear).HasColumnName("ntHeadwear");

				entity.Property(e => e.TBranding).HasColumnName("tBranding");

				entity.Property(e => e.TClothing).HasColumnName("tClothing");

				entity.Property(e => e.TGifts).HasColumnName("tGifts");

				entity.Property(e => e.THeadwear).HasColumnName("tHeadwear");
			});

			modelBuilder.Entity<StInventoryCategorySales>(entity =>
			{
				entity.HasKey(e => new { e.Date, e.Category, e.InventoryType });

				entity.ToTable("stInventoryCategorySales");

				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.Category)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StkimportedSnapshot>(entity =>
			{
				entity.ToTable("STKImportedSnapshot");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FileLocation)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FileName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StkimpotedSnapshotData>(entity =>
			{
				entity.ToTable("STKImpotedSnapshotData");

				entity.Property(e => e.FkImportedSnapshot).HasColumnName("FK_ImportedSnapshot");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ItemStatus)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkImportedSnapshotNavigation)
					.WithMany(p => p.StkimpotedSnapshotData)
					.HasForeignKey(d => d.FkImportedSnapshot)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_STK_ImpotedSnapshotData_STK_ ImportedSnapshot");
			});

			modelBuilder.Entity<StksnapshotDifferenceData>(entity =>
			{
				entity.ToTable("STKSnapshotDifferenceData");

				entity.Property(e => e.FkImportedSnapshot).HasColumnName("FK_ImportedSnapshot");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ItemStatus)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkImportedSnapshotNavigation)
					.WithMany(p => p.StksnapshotDifferenceData)
					.HasForeignKey(d => d.FkImportedSnapshot)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_STK_SnapshotDifferenceData_STK_ ImportedSnapshot");
			});

			modelBuilder.Entity<Stock>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.StockCode)
					.IsRequired()
					.HasColumnName("stockCode")
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockCheckTracking>(entity =>
			{
				entity.Property(e => e.StockCheckTrackingId).HasColumnName("StockCheckTrackingID");

				entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(6)
					.IsUnicode(false);

				entity.Property(e => e.ProductCode)
					.IsRequired()
					.HasMaxLength(15)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockFlags>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ItemCodeClear)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");
			});

			modelBuilder.Entity<StockGroupTypes>(entity =>
			{
				entity.Property(e => e.GroupName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StockPrice>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_StockPrice")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.StockPrice)
					.HasForeignKey<StockPrice>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockPrice_Price");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.StockPrice)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockPrice_Stock");
			});

			modelBuilder.Entity<StockTakeEntries>(entity =>
			{
				entity.Property(e => e.ActionComments)
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DataExp)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.DataIn)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.DateResolved).HasColumnType("datetime");

				entity.Property(e => e.FkAuthorId).HasColumnName("FK_AuthorId");

				entity.Property(e => e.FkLocationId).HasColumnName("FK_LocationId");

				entity.Property(e => e.FkUserResolverId).HasColumnName("FK_UserResolverId");
			});

			modelBuilder.Entity<StockWarehouse>(entity =>
			{
				entity.HasKey(e => e.Warehouse);

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PastelCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StSales>(entity =>
			{
				entity.HasKey(e => e.Date);

				entity.ToTable("stSales");

				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.UniqueSku).HasColumnName("UniqueSKU");
			});

			modelBuilder.Entity<StTopCustomerSpend>(entity =>
			{
				entity.HasKey(e => new { e.Date, e.CustomerCode });

				entity.ToTable("stTopCustomerSpend");

				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.CustomerName)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PricelistName)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StTurnover>(entity =>
			{
				entity.HasKey(e => e.Date);

				entity.ToTable("stTurnover");

				entity.Property(e => e.Date).HasColumnType("date");
			});

			modelBuilder.Entity<StTurnoverRegional>(entity =>
			{
				entity.HasKey(e => new { e.Date, e.Region, e.Province });

				entity.ToTable("stTurnoverRegional");

				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.Province)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<StWarehouseStockLevels>(entity =>
			{
				entity.ToTable("stWarehouseStockLevels");

				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.Skucount).HasColumnName("SKUCount");

				entity.Property(e => e.WarehouseCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<SuburbCity>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Name)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ProvinceFk).HasColumnName("Province_FK");

				entity.HasOne(d => d.ProvinceFkNavigation)
					.WithMany(p => p.SuburbCity)
					.HasForeignKey(d => d.ProvinceFk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SuburbCity_Province");
			});

			modelBuilder.Entity<SystemRequest>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Data)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.Page)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Referrer)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.Author)
					.WithMany(p => p.SystemRequest)
					.HasForeignKey(d => d.AuthorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SystemRequest_User");
			});

			modelBuilder.Entity<SystemRequestAttachment>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Path)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SystemRequestId).HasColumnName("SystemRequestID");

				entity.Property(e => e.SystemRequestNoteId).HasColumnName("SystemRequestNoteID");

				entity.HasOne(d => d.SystemRequest)
					.WithMany(p => p.SystemRequestAttachment)
					.HasForeignKey(d => d.SystemRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SystemRequestAttachment_SystemRequest");

				entity.HasOne(d => d.SystemRequestNote)
					.WithMany(p => p.SystemRequestAttachment)
					.HasForeignKey(d => d.SystemRequestNoteId)
					.HasConstraintName("FK_SystemRequestAttachment_SystemRequestNotes");
			});

			modelBuilder.Entity<SystemRequestNote>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Data)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.SystemRequestId).HasColumnName("SystemRequestID");

				entity.HasOne(d => d.Author)
					.WithMany(p => p.SystemRequestNote)
					.HasForeignKey(d => d.AuthorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SystemRequestNotes_User");
			});

			modelBuilder.Entity<SystemRequestTracking>(entity =>
			{
				entity.HasKey(e => new { e.SystemRequestId, e.TrackingId });

				entity.Property(e => e.SystemRequestId).HasColumnName("SystemRequestID");

				entity.Property(e => e.TrackingId).HasColumnName("TrackingID");

				entity.HasOne(d => d.SystemRequest)
					.WithMany(p => p.SystemRequestTracking)
					.HasForeignKey(d => d.SystemRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SystemRequestTracking_SystemRequest");

				entity.HasOne(d => d.Tracking)
					.WithMany(p => p.SystemRequestTracking)
					.HasForeignKey(d => d.TrackingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SystemRequestTracking_Tracking");
			});

			modelBuilder.Entity<TempAplookup>(entity =>
			{
				entity.HasKey(e => new { e.ParentAccountNumber, e.ChildAccountNumber, e.IsAmtrackSoftLink });

				entity.ToTable("temp_APLookup");

				entity.Property(e => e.ParentAccountNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ChildAccountNumber)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Terminal>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");
			});

			modelBuilder.Entity<TerminalLocations>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_TerminalLocations")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.TerminalLocations)
					.HasForeignKey<TerminalLocations>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TerminalLocations_LocationOfTerminal");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.TerminalLocations)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TerminalLocations_Terminals");
			});

			modelBuilder.Entity<TerminalTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_TerminalTracking")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.TerminalTracking)
					.HasForeignKey<TerminalTracking>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TerminalTracking_Terminal");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.TerminalTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_TerminalTracking_TracksForTerminal");
			});

			modelBuilder.Entity<Tracking>(entity =>
			{
				entity.HasIndex(e => new { e.Id, e.Created, e.TypeCode })
					.HasName("_dta_index_Tracking_24_148299688__K6_K1_K2");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.TrackDate)
					.IsRequired()
					.HasColumnName("trackDate")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.TrackTime)
					.IsRequired()
					.HasColumnName("trackTime")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.TypeCode)
					.IsRequired()
					.HasColumnName("typeCode")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<TrueAccountManagers>(entity =>
			{
				entity.HasKey(e => e.AccountId);

				entity.Property(e => e.AccountId).ValueGeneratedNever();
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.HasIndex(e => e.AccountManagerCode)
					.HasName("IX_User_AccountManagerCode");

				entity.HasIndex(e => e.Username)
					.HasName("IX_User")
					.IsUnique();

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.AccountManagerCode)
					.HasColumnName("accountManagerCode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasColumnName("barcode")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.DisplayName)
					.IsRequired()
					.HasColumnName("displayName")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.HasColumnName("email")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Firstname)
					.HasColumnName("firstname")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.IsDefaultSalesRepresentative).HasColumnName("isDefaultSalesRepresentative");

				entity.Property(e => e.Lastname)
					.HasColumnName("lastname")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Mobile)
					.HasColumnName("mobile")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Password)
					.IsRequired()
					.HasColumnName("password")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.Username)
					.IsRequired()
					.HasColumnName("username")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<UserTracking>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.HasIndex(e => e.Fk)
					.HasName("IX_UserTracking")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.UserTracking)
					.HasForeignKey<UserTracking>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserTracking_User");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.UserTracking)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserTracking_TracksForUser");
			});

			modelBuilder.Entity<Warehouse>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Checksum)
					.IsRequired()
					.HasColumnName("checksum")
					.IsRowVersion();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasColumnName("code")
					.HasMaxLength(15)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnName("description")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Guid).HasColumnName("guid");

				entity.Property(e => e.Modified)
					.HasColumnName("modified")
					.HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasColumnName("name")
					.HasMaxLength(150)
					.IsUnicode(false);
			});

			modelBuilder.Entity<WarehouseInventory>(entity =>
			{
				entity.HasKey(e => new { e.Pk, e.Fk });

				entity.ToTable("warehouseInventory");

				entity.HasIndex(e => e.Fk)
					.HasName("IX_WarehouseInventory")
					.IsUnique();

				entity.Property(e => e.Pk).HasColumnName("pk");

				entity.Property(e => e.Fk).HasColumnName("fk");

				entity.HasOne(d => d.FkNavigation)
					.WithOne(p => p.WarehouseInventory)
					.HasForeignKey<WarehouseInventory>(d => d.Fk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehouseInventory_Inventory");

				entity.HasOne(d => d.PkNavigation)
					.WithMany(p => p.WarehouseInventory)
					.HasForeignKey(d => d.Pk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehouseInventory_Warehouse");
			});

			modelBuilder.Entity<Waybill>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Courier)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Notes).IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Wc15ParcelBatchInfo>(entity =>
			{
				entity.ToTable("wc15ParcelBatchInfo");

				entity.Property(e => e.FkParcelId).HasColumnName("FK_ParcelId");

				entity.Property(e => e.ParcelRangeCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Wc15ReceivedSampleBatches>(entity =>
			{
				entity.HasKey(e => new { e.FkOrderId, e.StyleCode });

				entity.ToTable("wc15ReceivedSampleBatches");

				entity.Property(e => e.FkOrderId).HasColumnName("FK_OrderId");

				entity.Property(e => e.StyleCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.DateReceived).HasColumnType("datetime");
			});

			modelBuilder.HasSequence<int>("IncrementsVal").StartsAt(10000);
		}
	}
}
