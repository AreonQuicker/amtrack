using Amtrack.Amtrack_V2.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Amtrack.Amtrack_V2.Data
{
	public partial class AmtrackV2Context : DbContext
	{
		public AmtrackV2Context()
		{
		}

		public AmtrackV2Context(DbContextOptions<AmtrackV2Context> options)
			: base(options)
		{
		}

		public virtual DbSet<AccountAccountManagers> AccountAccountManagers { get; set; }
		public virtual DbSet<AccountAddress> AccountAddress { get; set; }
		public virtual DbSet<AccountAttributes> AccountAttributes { get; set; }
		public virtual DbSet<AccountAttributeTemplates> AccountAttributeTemplates { get; set; }
		public virtual DbSet<AccountBalances> AccountBalances { get; set; }
		public virtual DbSet<AccountContactAddress> AccountContactAddress { get; set; }
		public virtual DbSet<AccountContactContactNumbers> AccountContactContactNumbers { get; set; }
		public virtual DbSet<AccountContactNotifications> AccountContactNotifications { get; set; }
		public virtual DbSet<AccountContactNumbers> AccountContactNumbers { get; set; }
		public virtual DbSet<AccountContacts> AccountContacts { get; set; }
		public virtual DbSet<AccountCreditLimitSettings> AccountCreditLimitSettings { get; set; }
		public virtual DbSet<Accounts> Accounts { get; set; }
		public virtual DbSet<AccountSystemNotificationTypes> AccountSystemNotificationTypes { get; set; }
		public virtual DbSet<AdAddressValidationInfo> AdAddressValidationInfo { get; set; }
		public virtual DbSet<Addresses> Addresses { get; set; }
		public virtual DbSet<AdLinesUpdated> AdLinesUpdated { get; set; }
		public virtual DbSet<AdPickingSlipPrintStatus> AdPickingSlipPrintStatus { get; set; }
		public virtual DbSet<Alpdatas> Alpdatas { get; set; }
		public virtual DbSet<AlpdocumentAlps> AlpdocumentAlps { get; set; }
		public virtual DbSet<AlpexportData> AlpexportData { get; set; }
		public virtual DbSet<AlpexportDataDetail> AlpexportDataDetail { get; set; }
		public virtual DbSet<AlpmailerCustomerData> AlpmailerCustomerData { get; set; }
		public virtual DbSet<AlpmailerData> AlpmailerData { get; set; }
		public virtual DbSet<AlpMailerRecipients> AlpMailerRecipients { get; set; }
		public virtual DbSet<AlpMailerUpdates> AlpMailerUpdates { get; set; }
		public virtual DbSet<AlpmidYearDatas> AlpmidYearDatas { get; set; }
		public virtual DbSet<Alpoverride> Alpoverride { get; set; }
		public virtual DbSet<AlppointRuleBonusTypes> AlppointRuleBonusTypes { get; set; }
		public virtual DbSet<AlppointRules> AlppointRules { get; set; }
		public virtual DbSet<AlppointRuleValues> AlppointRuleValues { get; set; }
		public virtual DbSet<AlppointsTypes> AlppointsTypes { get; set; }
		public virtual DbSet<Alppromotion> Alppromotion { get; set; }
		public virtual DbSet<Alps> Alps { get; set; }
		public virtual DbSet<Alptargets> Alptargets { get; set; }
		public virtual DbSet<AlptempData> AlptempData { get; set; }
		public virtual DbSet<Alptypes> Alptypes { get; set; }
		public virtual DbSet<Alpvalues> Alpvalues { get; set; }
		public virtual DbSet<ApiIntegrator> ApiIntegrator { get; set; }
		public virtual DbSet<ApiIntegratorImpersonations> ApiIntegratorImpersonations { get; set; }
		public virtual DbSet<ApiIntegratorPermissions> ApiIntegratorPermissions { get; set; }
		public virtual DbSet<ApiIntegratorRoles> ApiIntegratorRoles { get; set; }
		public virtual DbSet<ApiLoginTokens> ApiLoginTokens { get; set; }
		public virtual DbSet<ApiPermissions> ApiPermissions { get; set; }
		public virtual DbSet<ApiRolePermissions> ApiRolePermissions { get; set; }
		public virtual DbSet<ApiRoles> ApiRoles { get; set; }
		public virtual DbSet<AsmDevice> AsmDevice { get; set; }
		public virtual DbSet<AsmDeviceManufacturer> AsmDeviceManufacturer { get; set; }
		public virtual DbSet<AsmDeviceModels> AsmDeviceModels { get; set; }
		public virtual DbSet<AsmDeviceNotes> AsmDeviceNotes { get; set; }
		public virtual DbSet<AsmDeviceOperators> AsmDeviceOperators { get; set; }
		public virtual DbSet<AsmLogBook> AsmLogBook { get; set; }
		public virtual DbSet<AudBrandingConversionDatas> AudBrandingConversionDatas { get; set; }
		public virtual DbSet<AuditDocuments> AuditDocuments { get; set; }
		public virtual DbSet<Barcodes> Barcodes { get; set; }
		public virtual DbSet<Baskets> Baskets { get; set; }
		public virtual DbSet<BasketSessionItems> BasketSessionItems { get; set; }
		public virtual DbSet<BasketSessions> BasketSessions { get; set; }
		public virtual DbSet<BasketSessionTrackings> BasketSessionTrackings { get; set; }
		public virtual DbSet<BlanketAcceptances> BlanketAcceptances { get; set; }
		public virtual DbSet<BranchAddresses> BranchAddresses { get; set; }
		public virtual DbSet<BranchAlps> BranchAlps { get; set; }
		public virtual DbSet<BranchAttributes> BranchAttributes { get; set; }
		public virtual DbSet<BranchAttributeTemplateOptionValues> BranchAttributeTemplateOptionValues { get; set; }
		public virtual DbSet<BranchAttributeTemplates> BranchAttributeTemplates { get; set; }
		public virtual DbSet<BranchContactNumbers> BranchContactNumbers { get; set; }
		public virtual DbSet<BranchDelivery> BranchDelivery { get; set; }
		public virtual DbSet<BranchDeliveryCourierInfoes> BranchDeliveryCourierInfoes { get; set; }
		public virtual DbSet<BranchDeliveryParcels> BranchDeliveryParcels { get; set; }
		public virtual DbSet<BranchDeliveryProcesses> BranchDeliveryProcesses { get; set; }
		public virtual DbSet<BranchDeliveryProcessTracking> BranchDeliveryProcessTracking { get; set; }
		public virtual DbSet<BranchDeliveryRequestResponses> BranchDeliveryRequestResponses { get; set; }
		public virtual DbSet<BranchDeliveryRequests> BranchDeliveryRequests { get; set; }
		public virtual DbSet<Branches> Branches { get; set; }
		public virtual DbSet<BranchInvoiceType> BranchInvoiceType { get; set; }
		public virtual DbSet<BranchInvoiceTypeShipment> BranchInvoiceTypeShipment { get; set; }
		public virtual DbSet<BranchRules> BranchRules { get; set; }
		public virtual DbSet<BranchRuleValues> BranchRuleValues { get; set; }
		public virtual DbSet<BranchServers> BranchServers { get; set; }
		public virtual DbSet<BranchSetting> BranchSetting { get; set; }
		public virtual DbSet<BranchWarehouse> BranchWarehouse { get; set; }
		public virtual DbSet<BranchWarehouseLink> BranchWarehouseLink { get; set; }
		public virtual DbSet<BranchWifi> BranchWifi { get; set; }
		public virtual DbSet<BrandingConversionAldatas> BrandingConversionAldatas { get; set; }
		public virtual DbSet<BrandingConversionDatas> BrandingConversionDatas { get; set; }
		public virtual DbSet<BrandingConversionGroups> BrandingConversionGroups { get; set; }
		public virtual DbSet<BrandingConversionMembers> BrandingConversionMembers { get; set; }
		public virtual DbSet<BrandingInfoLine> BrandingInfoLine { get; set; }
		public virtual DbSet<BrandingLineInfo> BrandingLineInfo { get; set; }
		public virtual DbSet<BrandingLineInfoAttachments> BrandingLineInfoAttachments { get; set; }
		public virtual DbSet<BrandingLineInfoContacts> BrandingLineInfoContacts { get; set; }
		public virtual DbSet<BudgetedTurnover> BudgetedTurnover { get; set; }
		public virtual DbSet<ClientContact> ClientContact { get; set; }
		public virtual DbSet<ClientDelivery> ClientDelivery { get; set; }
		public virtual DbSet<ClientDeliveryAddress> ClientDeliveryAddress { get; set; }
		public virtual DbSet<ClientDocumentRequests> ClientDocumentRequests { get; set; }
		public virtual DbSet<ClientDocumentResponses> ClientDocumentResponses { get; set; }
		public virtual DbSet<CommercialBrandingDocuments> CommercialBrandingDocuments { get; set; }
		public virtual DbSet<ContactNumbers> ContactNumbers { get; set; }
		public virtual DbSet<CreateInsuffiecients> CreateInsuffiecients { get; set; }
		public virtual DbSet<CreditLimitSettings> CreditLimitSettings { get; set; }
		public virtual DbSet<CreditNoteLogs> CreditNoteLogs { get; set; }
		public virtual DbSet<CreditNoteProcesses> CreditNoteProcesses { get; set; }
		public virtual DbSet<CreditNoteRequestLogs> CreditNoteRequestLogs { get; set; }
		public virtual DbSet<CreditNoteRequestProcesses> CreditNoteRequestProcesses { get; set; }
		public virtual DbSet<Currency> Currency { get; set; }
		public virtual DbSet<DeliveryAddress> DeliveryAddress { get; set; }
		public virtual DbSet<DeliveryProvider> DeliveryProvider { get; set; }
		public virtual DbSet<DeliveryProviderConfig> DeliveryProviderConfig { get; set; }
		public virtual DbSet<DeliveryProviderServiceExclusions> DeliveryProviderServiceExclusions { get; set; }
		public virtual DbSet<DeliveryProviderServiceLeadTimes> DeliveryProviderServiceLeadTimes { get; set; }
		public virtual DbSet<DeliveryProviderServices> DeliveryProviderServices { get; set; }
		public virtual DbSet<DeliveryQuote> DeliveryQuote { get; set; }
		public virtual DbSet<DeliveryQuoteDetail> DeliveryQuoteDetail { get; set; }
		public virtual DbSet<DeliveryQuoteDocuments> DeliveryQuoteDocuments { get; set; }
		public virtual DbSet<DeliveryQuoteItems> DeliveryQuoteItems { get; set; }
		public virtual DbSet<DeliverySuburbLookup> DeliverySuburbLookup { get; set; }
		public virtual DbSet<DeliveryWaybill> DeliveryWaybill { get; set; }
		public virtual DbSet<DeliveryWaybillCourierDetails> DeliveryWaybillCourierDetails { get; set; }
		public virtual DbSet<DeliveryWaybillDetail> DeliveryWaybillDetail { get; set; }
		public virtual DbSet<DeliveryWaybillTracking> DeliveryWaybillTracking { get; set; }
		public virtual DbSet<Departments> Departments { get; set; }
		public virtual DbSet<DestroyedPalletInfo> DestroyedPalletInfo { get; set; }
		public virtual DbSet<DmDevice> DmDevice { get; set; }
		public virtual DbSet<DmDeviceHandler> DmDeviceHandler { get; set; }
		public virtual DbSet<DmDeviceLogBook> DmDeviceLogBook { get; set; }
		public virtual DbSet<DmDeviceRotation> DmDeviceRotation { get; set; }
		public virtual DbSet<DmDeviceTracking> DmDeviceTracking { get; set; }
		public virtual DbSet<DocumentAttachments> DocumentAttachments { get; set; }
		public virtual DbSet<DocumentBoxDetail> DocumentBoxDetail { get; set; }
		public virtual DbSet<DocumentBoxes> DocumentBoxes { get; set; }
		public virtual DbSet<DocumentHistory> DocumentHistory { get; set; }
		public virtual DbSet<DocumentNotificationInfos> DocumentNotificationInfos { get; set; }
		public virtual DbSet<DocumentNumbers> DocumentNumbers { get; set; }
		public virtual DbSet<DocumentPallet> DocumentPallet { get; set; }
		public virtual DbSet<DocumentPostProcessing> DocumentPostProcessing { get; set; }
		public virtual DbSet<DocumentPostProcessingInfoes> DocumentPostProcessingInfoes { get; set; }
		public virtual DbSet<DocumentReservedStocks> DocumentReservedStocks { get; set; }
		public virtual DbSet<Documents> Documents { get; set; }
		public virtual DbSet<DocumentsSkippedProcessing> DocumentsSkippedProcessing { get; set; }
		public virtual DbSet<DocumentSyncStates> DocumentSyncStates { get; set; }
		public virtual DbSet<DocumentVersionInfoes> DocumentVersionInfoes { get; set; }
		public virtual DbSet<DocumentVolumetric> DocumentVolumetric { get; set; }
		public virtual DbSet<EntityAttachmentLinks> EntityAttachmentLinks { get; set; }
		public virtual DbSet<EntityAttachments> EntityAttachments { get; set; }
		public virtual DbSet<EntityNotificationRecipients> EntityNotificationRecipients { get; set; }
		public virtual DbSet<EntityNotificationReferrals> EntityNotificationReferrals { get; set; }
		public virtual DbSet<EntityNotifications> EntityNotifications { get; set; }
		public virtual DbSet<EntityProcesses> EntityProcesses { get; set; }
		public virtual DbSet<GenericTrackings> GenericTrackings { get; set; }
		public virtual DbSet<HistoryContributor> HistoryContributor { get; set; }
		public virtual DbSet<ImportStates> ImportStates { get; set; }
		public virtual DbSet<InvoiceInfoes> InvoiceInfoes { get; set; }
		public virtual DbSet<InvoicingSpecials> InvoicingSpecials { get; set; }
		public virtual DbSet<ItemPalletInfo> ItemPalletInfo { get; set; }
		public virtual DbSet<LineDatas> LineDatas { get; set; }
		public virtual DbSet<LineDisplay> LineDisplay { get; set; }
		public virtual DbSet<LineDisplayComponents> LineDisplayComponents { get; set; }
		public virtual DbSet<LineDisplayPartDetails> LineDisplayPartDetails { get; set; }
		public virtual DbSet<LineLinks> LineLinks { get; set; }
		public virtual DbSet<Lines> Lines { get; set; }
		public virtual DbSet<LookupBrandingConversionIgnoredStocks> LookupBrandingConversionIgnoredStocks { get; set; }
		public virtual DbSet<LookupClothingMensClothings> LookupClothingMensClothings { get; set; }
		public virtual DbSet<LookupOrderTypePriorities> LookupOrderTypePriorities { get; set; }
		public virtual DbSet<MDocuments> MDocuments { get; set; }
		public virtual DbSet<MessageQueueItems> MessageQueueItems { get; set; }
		public virtual DbSet<MessageQueueLogs> MessageQueueLogs { get; set; }
		public virtual DbSet<MMessage> MMessage { get; set; }
		public virtual DbSet<MRecipientResponses> MRecipientResponses { get; set; }
		public virtual DbSet<MRecipients> MRecipients { get; set; }
		public virtual DbSet<MSchedules> MSchedules { get; set; }
		public virtual DbSet<MStore> MStore { get; set; }
		public virtual DbSet<MTracking> MTracking { get; set; }
		public virtual DbSet<OneTimeTokens> OneTimeTokens { get; set; }
		public virtual DbSet<PalletConfirmLocationBatches> PalletConfirmLocationBatches { get; set; }
		public virtual DbSet<PalletConfirmLocationExceptions> PalletConfirmLocationExceptions { get; set; }
		public virtual DbSet<PalletConfirmLocationMovements> PalletConfirmLocationMovements { get; set; }
		public virtual DbSet<PalletConfirmLocationRaw> PalletConfirmLocationRaw { get; set; }
		public virtual DbSet<PalletContents> PalletContents { get; set; }
		public virtual DbSet<PalletMovementErrors> PalletMovementErrors { get; set; }
		public virtual DbSet<Pallets> Pallets { get; set; }
		public virtual DbSet<PalletTransferBatchContents> PalletTransferBatchContents { get; set; }
		public virtual DbSet<PalletTransferBatches> PalletTransferBatches { get; set; }
		public virtual DbSet<PaymentInfoData> PaymentInfoData { get; set; }
		public virtual DbSet<PaymentInfoes> PaymentInfoes { get; set; }
		public virtual DbSet<PaymentInfoProcessResults> PaymentInfoProcessResults { get; set; }
		public virtual DbSet<PickingInstructions> PickingInstructions { get; set; }
		public virtual DbSet<PickingSlipMovements> PickingSlipMovements { get; set; }
		public virtual DbSet<PickingSlipPrintStatus> PickingSlipPrintStatus { get; set; }
		public virtual DbSet<PickingSlipReservedStocks> PickingSlipReservedStocks { get; set; }
		public virtual DbSet<PickingSlips> PickingSlips { get; set; }
		public virtual DbSet<PodCollectionInstructionContainer> PodCollectionInstructionContainer { get; set; }
		public virtual DbSet<PodCollectionInstructionLocation> PodCollectionInstructionLocation { get; set; }
		public virtual DbSet<PodCollectionIntruction> PodCollectionIntruction { get; set; }
		public virtual DbSet<PodCollectionNote> PodCollectionNote { get; set; }
		public virtual DbSet<PodCollectionNoteBoxInfo> PodCollectionNoteBoxInfo { get; set; }
		public virtual DbSet<PodCollectionNoteDocument> PodCollectionNoteDocument { get; set; }
		public virtual DbSet<PodCollectionNoteWaybill> PodCollectionNoteWaybill { get; set; }
		public virtual DbSet<PodDispatchBuzzer> PodDispatchBuzzer { get; set; }
		public virtual DbSet<PodDispatchBuzzerAllocation> PodDispatchBuzzerAllocation { get; set; }
		public virtual DbSet<PodDispatchBuzzerAllocationTracking> PodDispatchBuzzerAllocationTracking { get; set; }
		public virtual DbSet<PrintDelayedReasons> PrintDelayedReasons { get; set; }
		public virtual DbSet<Printers> Printers { get; set; }
		public virtual DbSet<ProductPurchaseRecords> ProductPurchaseRecords { get; set; }
		public virtual DbSet<QuoteDocuments> QuoteDocuments { get; set; }
		public virtual DbSet<QuoteLines> QuoteLines { get; set; }
		public virtual DbSet<ReservationInfoes> ReservationInfoes { get; set; }
		public virtual DbSet<ReservedStockAdjustmentTransactions> ReservedStockAdjustmentTransactions { get; set; }
		public virtual DbSet<ReservedStocks> ReservedStocks { get; set; }
		public virtual DbSet<Rework> Rework { get; set; }
		public virtual DbSet<ReworkBoxes> ReworkBoxes { get; set; }
		public virtual DbSet<ReworkDocuments> ReworkDocuments { get; set; }
		public virtual DbSet<ReworkInstructionBoxes> ReworkInstructionBoxes { get; set; }
		public virtual DbSet<ReworkInstructionData> ReworkInstructionData { get; set; }
		public virtual DbSet<ReworkInstructionLines> ReworkInstructionLines { get; set; }
		public virtual DbSet<ReworkInstructionMasterBoxes> ReworkInstructionMasterBoxes { get; set; }
		public virtual DbSet<ReworkInstructionMasterLines> ReworkInstructionMasterLines { get; set; }
		public virtual DbSet<ReworkInstructions> ReworkInstructions { get; set; }
		public virtual DbSet<ReworkReport> ReworkReport { get; set; }
		public virtual DbSet<RushDocumentDetail> RushDocumentDetail { get; set; }
		public virtual DbSet<ScannedConveyerParcels> ScannedConveyerParcels { get; set; }
		public virtual DbSet<SecurityLevels> SecurityLevels { get; set; }
		public virtual DbSet<SecurityLevelSecurityPermission> SecurityLevelSecurityPermission { get; set; }
		public virtual DbSet<SecurityPermissions> SecurityPermissions { get; set; }
		public virtual DbSet<SentClientNotifications> SentClientNotifications { get; set; }
		public virtual DbSet<ServerDetails> ServerDetails { get; set; }
		public virtual DbSet<ShipmentCommercialBrandingDocumentLines> ShipmentCommercialBrandingDocumentLines { get; set; }
		public virtual DbSet<ShipmentCommercialBrandingDocuments> ShipmentCommercialBrandingDocuments { get; set; }
		public virtual DbSet<ShipmentDetail> ShipmentDetail { get; set; }
		public virtual DbSet<ShipmentNumber> ShipmentNumber { get; set; }
		public virtual DbSet<ShipmentProcessTracking> ShipmentProcessTracking { get; set; }
		public virtual DbSet<ShipmentReservesRecycle> ShipmentReservesRecycle { get; set; }
		public virtual DbSet<Shipments> Shipments { get; set; }
		public virtual DbSet<ShippingDestinations> ShippingDestinations { get; set; }
		public virtual DbSet<ShippingProviderConfigurations> ShippingProviderConfigurations { get; set; }
		public virtual DbSet<ShippingProviders> ShippingProviders { get; set; }
		public virtual DbSet<ShippingRates> ShippingRates { get; set; }
		public virtual DbSet<ShippingServices> ShippingServices { get; set; }
		public virtual DbSet<SpecialDates> SpecialDates { get; set; }
		public virtual DbSet<SrReceiptCompletedLines> SrReceiptCompletedLines { get; set; }
		public virtual DbSet<SrReceiptLines> SrReceiptLines { get; set; }
		public virtual DbSet<SrReceipts> SrReceipts { get; set; }
		public virtual DbSet<SrReceiptTracking> SrReceiptTracking { get; set; }
		public virtual DbSet<StockTakeBatches> StockTakeBatches { get; set; }
		public virtual DbSet<StockTakeRecords> StockTakeRecords { get; set; }
		public virtual DbSet<StockTakeUnProcessedBatchEntries> StockTakeUnProcessedBatchEntries { get; set; }
		public virtual DbSet<SuggestedReOrderPallets> SuggestedReOrderPallets { get; set; }
		public virtual DbSet<SwadSummary> SwadSummary { get; set; }
		public virtual DbSet<SyncDataErrorDetail> SyncDataErrorDetail { get; set; }
		public virtual DbSet<SyncDataErrorRecipients> SyncDataErrorRecipients { get; set; }
		public virtual DbSet<SyncDataErrors> SyncDataErrors { get; set; }
		public virtual DbSet<TaxRates> TaxRates { get; set; }
		public virtual DbSet<TempNotCreatable> TempNotCreatable { get; set; }
		public virtual DbSet<TempPalletCodes> TempPalletCodes { get; set; }
		public virtual DbSet<TempPrices> TempPrices { get; set; }
		public virtual DbSet<TurnOverTest> TurnOverTest { get; set; }
		public virtual DbSet<TurnoverTransactionDetails> TurnoverTransactionDetails { get; set; }
		public virtual DbSet<TurnoverTransactions> TurnoverTransactions { get; set; }
		public virtual DbSet<TurnoverTransactions1> TurnoverTransactions1 { get; set; }
		public virtual DbSet<TurnoverTransfers> TurnoverTransfers { get; set; }
		public virtual DbSet<UserBranches> UserBranches { get; set; }
		public virtual DbSet<UserDepartment> UserDepartment { get; set; }
		public virtual DbSet<UserLink> UserLink { get; set; }
		public virtual DbSet<Users> Users { get; set; }
		public virtual DbSet<UserSecurityPermission> UserSecurityPermission { get; set; }
		public virtual DbSet<UtiBondedIntegrationAudit> UtiBondedIntegrationAudit { get; set; }
		public virtual DbSet<WarehouseEntityMovements> WarehouseEntityMovements { get; set; }
		public virtual DbSet<WarehouseLocations> WarehouseLocations { get; set; }
		public virtual DbSet<WarehouseMinimumReorders> WarehouseMinimumReorders { get; set; }
		public virtual DbSet<WarehouseNotifications> WarehouseNotifications { get; set; }
		public virtual DbSet<WarehouseReorders> WarehouseReorders { get; set; }
		public virtual DbSet<WarehouseReplenishments> WarehouseReplenishments { get; set; }
		public virtual DbSet<Warehouses> Warehouses { get; set; }
		public virtual DbSet<WarehouseStockStorageMovements> WarehouseStockStorageMovements { get; set; }
		public virtual DbSet<WarehouseStockStorages> WarehouseStockStorages { get; set; }
		public virtual DbSet<WdbActiveJobcards> WdbActiveJobcards { get; set; }
		public virtual DbSet<WdbActiveOrders> WdbActiveOrders { get; set; }
		public virtual DbSet<WdbRecentCreditNotes> WdbRecentCreditNotes { get; set; }
		public virtual DbSet<WdbResync> WdbResync { get; set; }
		public virtual DbSet<WmsDocumentBoxDetail> WmsDocumentBoxDetail { get; set; }
		public virtual DbSet<WmsDocumentBoxes> WmsDocumentBoxes { get; set; }
		public virtual DbSet<WmsDocumentBoxInfo> WmsDocumentBoxInfo { get; set; }
		public virtual DbSet<WmsDocumentBoxLinks> WmsDocumentBoxLinks { get; set; }
		public virtual DbSet<WmsDocumentBoxMovements> WmsDocumentBoxMovements { get; set; }
		public virtual DbSet<WmsDocumentBoxTracking> WmsDocumentBoxTracking { get; set; }
		public virtual DbSet<WmsDocumentImportStatus> WmsDocumentImportStatus { get; set; }
		public virtual DbSet<WmsDocumentLines> WmsDocumentLines { get; set; }
		public virtual DbSet<WmsDocumentLinks> WmsDocumentLinks { get; set; }
		public virtual DbSet<WmsDocuments> WmsDocuments { get; set; }
		public virtual DbSet<WmsDocumentTracking> WmsDocumentTracking { get; set; }
		public virtual DbSet<WmsStagingLocations> WmsStagingLocations { get; set; }
		public virtual DbSet<WmsStagingLocationSessionBoxes> WmsStagingLocationSessionBoxes { get; set; }
		public virtual DbSet<WmsStagingLocationSessions> WmsStagingLocationSessions { get; set; }
		public virtual DbSet<WmsStagingLocationSessionTracking> WmsStagingLocationSessionTracking { get; set; }
		public virtual DbSet<WmsTracking> WmsTracking { get; set; }

		// Unable to generate entity type for table 'dbo.PriceList_131759565840289205'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._TempDiscontinuedALP'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TempWebinarsData'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.tmp_docs'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._TempALPDatas'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._unPostedJuneRecon'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.cacheLeadTimeMainData'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.PS_Temp'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.cacheLeadTimeSubData'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._NFTemp'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.excludeLeadTimeDocument'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.StockCheckUnbatchedItems'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.StockCheckUnbatchedHamperStock'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TEMP_EX'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TEMP_SCALE_USER_BARCODES'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TEMP_SCALE_USER_USERNAMES'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ALPClosingImport'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ALPCarryOver'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._tempReservesToDelete'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.ALPStatuses'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.Sheet1$'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.PalletStockTake'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.WmsDocumentStatusLookup'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._StockTakeUnProcessedBatchEntries'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.APTraining'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo._bkBrandingConversion201707'. Please see the warning messages.
		// Unable to generate entity type for table 'dbo.TempALPDatas'. Please see the warning messages.

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer("server=ACG-SERV-TST2\\ACTST5;database=amtrack_v2;uid=sa;pwd=F15HP@15T;Max Pool Size=300;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountAccountManagers>(entity =>
			{
				entity.HasIndex(e => new { e.FkAccountId, e.FkBrandId })
					.HasName("IX_AccountAccountManagers")
					.IsUnique();

				entity.Property(e => e.Brand)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkAccountId).HasColumnName("FK_AccountId");

				entity.Property(e => e.FkBrandId).HasColumnName("FK_BrandId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkAccount)
					.WithMany(p => p.AccountAccountManagers)
					.HasForeignKey(d => d.FkAccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAccountManagers_Accounts");

				entity.HasOne(d => d.User)
					.WithMany(p => p.AccountAccountManagers)
					.HasForeignKey(d => d.FkUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAccountManagers_Users");
			});

			modelBuilder.Entity<AccountAddress>(entity =>
			{
				entity.HasIndex(e => new { e.FkAccountId, e.FkAddressId })
					.HasName("IX_AccountAddress")
					.IsUnique();

				entity.Property(e => e.AddressName)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.ContactEmail)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactName)
					.HasMaxLength(200)
					.IsUnicode(false);

				entity.Property(e => e.ContactNumber)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.FkAccountId).HasColumnName("FK_AccountId");

				entity.Property(e => e.FkAddressId).HasColumnName("FK_AddressId");

				entity.HasOne(d => d.FkAccount)
					.WithMany(p => p.AccountAddress)
					.HasForeignKey(d => d.FkAccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAddress_Accounts");

				entity.HasOne(d => d.FkAddress)
					.WithMany(p => p.AccountAddress)
					.HasForeignKey(d => d.FkAddressId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAddress_Addresses");
			});

			modelBuilder.Entity<AccountAttributes>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkAccountId).HasColumnName("FK_AccountId");

				entity.Property(e => e.FkAttributeTemplateId).HasColumnName("FK_AttributeTemplateId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.StringValue)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.TextValue).HasColumnType("text");

				entity.HasOne(d => d.FkAccount)
					.WithMany(p => p.AccountAttributes)
					.HasForeignKey(d => d.FkAccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAttributes_Accounts");

				entity.HasOne(d => d.FkAttributeTemplate)
					.WithMany(p => p.AccountAttributes)
					.HasForeignKey(d => d.FkAttributeTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountAttributes_AccountAttributeTemplates");
			});

			modelBuilder.Entity<AccountAttributeTemplates>(entity =>
			{
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

			modelBuilder.Entity<AccountBalances>(entity =>
			{
				entity.Property(e => e.EnhancedExpiryDate).HasColumnType("date");
			});

			modelBuilder.Entity<AccountContactAddress>(entity =>
			{
				entity.Property(e => e.AddressName)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.ContactEmail)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactName)
					.HasMaxLength(200)
					.IsUnicode(false);

				entity.Property(e => e.ContactNumber)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.FkAccountContactId).HasColumnName("FK_AccountContactId");

				entity.Property(e => e.FkAddressId).HasColumnName("FK_AddressId");

				entity.HasOne(d => d.FkAccountContact)
					.WithMany(p => p.AccountContactAddress)
					.HasForeignKey(d => d.FkAccountContactId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactAddress_AccountContacts");

				entity.HasOne(d => d.FkAddress)
					.WithMany(p => p.AccountContactAddress)
					.HasForeignKey(d => d.FkAddressId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactAddress_Addresses");
			});

			modelBuilder.Entity<AccountContactContactNumbers>(entity =>
			{
				entity.Property(e => e.FkAccountContactId).HasColumnName("FK_AccountContactId");

				entity.Property(e => e.FkContactNumberId).HasColumnName("FK_ContactNumberId");

				entity.HasOne(d => d.FkAccountContact)
					.WithMany(p => p.AccountContactContactNumbers)
					.HasForeignKey(d => d.FkAccountContactId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactContactNumbers_AccountContacts");

				entity.HasOne(d => d.FkContactNumber)
					.WithMany(p => p.AccountContactContactNumbers)
					.HasForeignKey(d => d.FkContactNumberId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactContactNumbers_ContactNumbers");
			});

			modelBuilder.Entity<AccountContactNotifications>(entity =>
			{
				entity.Property(e => e.FkAccountContactId).HasColumnName("FK_AccountContactId");

				entity.Property(e => e.FkNotificationId).HasColumnName("FK_NotificationId");

				entity.HasOne(d => d.FkAccountContact)
					.WithMany(p => p.AccountContactNotifications)
					.HasForeignKey(d => d.FkAccountContactId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactNotifications_AccountContacts");

				entity.HasOne(d => d.FkNotification)
					.WithMany(p => p.AccountContactNotifications)
					.HasForeignKey(d => d.FkNotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactNotifications_AccountSystemNotificationTypes");
			});

			modelBuilder.Entity<AccountContactNumbers>(entity =>
			{
				entity.Property(e => e.FkAccountId).HasColumnName("FK_AccountId");

				entity.Property(e => e.FkContactNumberId).HasColumnName("FK_ContactNumberId");

				entity.HasOne(d => d.FkAccount)
					.WithMany(p => p.AccountContactNumbers)
					.HasForeignKey(d => d.FkAccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactNumbers_Accounts");

				entity.HasOne(d => d.FkContactNumber)
					.WithMany(p => p.AccountContactNumbers)
					.HasForeignKey(d => d.FkContactNumberId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContactNumbers_ContactNumbers");
			});

			modelBuilder.Entity<AccountContacts>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DateOfBirth).HasColumnType("date");

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Firstname)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.FkAccountId).HasColumnName("FK_AccountId");

				entity.Property(e => e.Lastname)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Title)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.HasOne(d => d.FkAccount)
					.WithMany(p => p.AccountContacts)
					.HasForeignKey(d => d.FkAccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountContacts_Accounts");
			});

			modelBuilder.Entity<AccountCreditLimitSettings>(entity =>
			{
				entity.HasKey(e => e.FkAccountId);

				entity.Property(e => e.FkAccountId)
					.HasColumnName("FK_AccountId")
					.ValueGeneratedNever();

				entity.Property(e => e.FkCreditLimitSettingsId).HasColumnName("FK_CreditLimitSettingsId");

				entity.HasOne(d => d.FkAccount)
					.WithOne(p => p.AccountCreditLimitSettings)
					.HasForeignKey<AccountCreditLimitSettings>(d => d.FkAccountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountCreditLimitSettings_Accounts");

				entity.HasOne(d => d.FkCreditLimitSettings)
					.WithMany(p => p.AccountCreditLimitSettings)
					.HasForeignKey(d => d.FkCreditLimitSettingsId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AccountCreditLimitSettings_CreditLimitSettings");
			});

			modelBuilder.Entity<Accounts>(entity =>
			{
				entity.HasIndex(e => e.Number)
					.HasName("IX_Accounts")
					.IsUnique();

				entity.HasIndex(e => new { e.CompanyCode, e.XfxHostId })
					.HasName("ix_Accounts_CompanyCode_XFX_HostId");

				entity.HasIndex(e => new { e.Number, e.FkMasterAccountId })
					.HasName("ix_Accounts_FK_MasterAccountId_includes");

				entity.Property(e => e.BranchCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.CompanyCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkAccountBalanceId).HasColumnName("FK_AccountBalanceId");

				entity.Property(e => e.FkMasterAccountId).HasColumnName("FK_MasterAccountId");

				entity.Property(e => e.FkPricelistId).HasColumnName("FK_PricelistId");

				entity.Property(e => e.FkTaxRateId).HasColumnName("FK_TaxRateId");

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.WebAddress)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.XfxHostId).HasColumnName("XFX_HostId");

				entity.HasOne(d => d.FkAccountBalance)
					.WithMany(p => p.Accounts)
					.HasForeignKey(d => d.FkAccountBalanceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Accounts_AccountBalances");

				entity.HasOne(d => d.MasterAccount)
					.WithMany(p => p.SubAccounts)
					.HasForeignKey(d => d.FkMasterAccountId)
					.HasConstraintName("FK_Accounts_Accounts");

				entity.HasOne(d => d.TaxRate)
					.WithMany(p => p.Accounts)
					.HasForeignKey(d => d.FkTaxRateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Accounts_TaxRates");
			});

			modelBuilder.Entity<AccountSystemNotificationTypes>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AdAddressValidationInfo>(entity =>
			{
				entity.ToTable("AD_AddressValidationInfo");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Locale)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.PostCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.State)
					.IsRequired()
					.HasMaxLength(250)
					.IsUnicode(false);

				entity.Property(e => e.Suburb)
					.IsRequired()
					.HasMaxLength(250)
					.IsUnicode(false);

				entity.Property(e => e.Use)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Addresses>(entity =>
			{
				entity.Property(e => e.City)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.CompanyName)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Country)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.OfficePark)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Province)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.StreetLine1)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.StreetLine2)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Suburb)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.UnitNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.XfxHostId).HasColumnName("XFX_HostId");
			});

			modelBuilder.Entity<AdLinesUpdated>(entity =>
			{
				entity.ToTable("adLinesUpdated");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.ActionDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<AdPickingSlipPrintStatus>(entity =>
			{
				entity.ToTable("adPickingSlipPrintStatus");

				entity.Property(e => e.ActionDate).HasColumnType("datetime");

				entity.Property(e => e.AdminTimeDelay).HasColumnType("datetime");

				entity.Property(e => e.DateCancelled).HasColumnType("datetime");

				entity.Property(e => e.DateDelayLifted).HasColumnType("datetime");

				entity.Property(e => e.DatePrintDelayed).HasColumnType("datetime");

				entity.Property(e => e.DatePrintQueued).HasColumnType("datetime");

				entity.Property(e => e.DatePrinted).HasColumnType("datetime");

				entity.Property(e => e.PickingSlipNumber)
					.IsRequired()
					.HasMaxLength(55);

				entity.Property(e => e.PrintDelayReasonCode).HasMaxLength(3);
			});

			modelBuilder.Entity<Alpdatas>(entity =>
			{
				entity.ToTable("ALPDatas");

				entity.HasIndex(e => new { e.Created, e.AccountManagerCode, e.CustomerCode, e.GiftsTotal, e.ClothingTotal, e.ClothingHeadgearTotal, e.BrandingTotal, e.GiftsAlp, e.ClothingAlp, e.ClothingHeadgearAlp, e.BrandingAlp, e.OtherAlp, e.AdditionalAlp, e.StaticTotalAlp, e.Type })
					.HasName("IX_ALPData_All");

				entity.HasIndex(e => new { e.Created, e.DocumentNumber, e.GiftsTotal, e.ClothingTotal, e.ClothingHeadgearTotal, e.BrandingTotal, e.GiftsAlp, e.ClothingAlp, e.ClothingHeadgearAlp, e.BrandingAlp, e.PromotionAlp, e.OverrideAlp, e.OtherAlp, e.GlAlp, e.AdditionalAlp, e.StaticTotalAlp, e.StaticTotal, e.Type, e.CustomerCode })
					.HasName("ix_ALPDatas_CustomerCode_includes");

				entity.Property(e => e.AccountManagerCode)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.AdditionalAlp).HasColumnName("AdditionalALP");

				entity.Property(e => e.BrandingAlp).HasColumnName("BrandingALP");

				entity.Property(e => e.ClothingAlp).HasColumnName("ClothingALP");

				entity.Property(e => e.ClothingHeadgearAlp).HasColumnName("ClothingHeadgearALP");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CreditNoteNumber).HasMaxLength(50);

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(30);

				entity.Property(e => e.DocumentNumber).HasMaxLength(50);

				entity.Property(e => e.GiftsAlp).HasColumnName("GiftsALP");

				entity.Property(e => e.GlAlp).HasColumnName("GlALP");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.OtherAlp).HasColumnName("OtherALP");

				entity.Property(e => e.OverrideAlp).HasColumnName("OverrideALP");

				entity.Property(e => e.PromotionAlp).HasColumnName("PromotionALP");

				entity.Property(e => e.StaticTotalAlp).HasColumnName("StaticTotalALP");

				entity.Property(e => e.SubType).HasDefaultValueSql("((0))");

				entity.Property(e => e.TransferAlp).HasColumnName("TransferALP");
			});

			modelBuilder.Entity<AlpdocumentAlps>(entity =>
			{
				entity.ToTable("ALPDocumentALPS");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AlpexportData>(entity =>
			{
				entity.HasKey(e => e.CustomerCode);

				entity.ToTable("_ALPExportData");

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(20)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<AlpexportDataDetail>(entity =>
			{
				entity.ToTable("_ALPExportDataDetail");

				entity.Property(e => e.AccountName)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.ContactName)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AlpmailerCustomerData>(entity =>
			{
				entity.ToTable("ALPMailerCustomerData");

				entity.Property(e => e.AccountName)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Alpmaintain).HasColumnName("ALPMaintain");

				entity.Property(e => e.Alpupgrade).HasColumnName("ALPUpgrade");

				entity.Property(e => e.CurrentAlp).HasColumnName("CurrentALP");

				entity.Property(e => e.CurrentStatus)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.FkMailerId).HasColumnName("FK_MailerId");

				entity.Property(e => e.GenerationStatus).HasDefaultValueSql("((0))");
			});

			modelBuilder.Entity<AlpmailerData>(entity =>
			{
				entity.ToTable("ALPMailerData");

				entity.Property(e => e.BrandingAlp).HasColumnName("BrandingALP");

				entity.Property(e => e.ClothingAlp).HasColumnName("ClothingALP");

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.FkMailerId).HasColumnName("FK_MailerId");

				entity.Property(e => e.GiftsAlp).HasColumnName("GiftsALP");

				entity.Property(e => e.HeadwearAlp).HasColumnName("HeadwearALP");

				entity.Property(e => e.TotalAlp).HasColumnName("TotalALP");
			});

			modelBuilder.Entity<AlpMailerRecipients>(entity =>
			{
				entity.ToTable("alpMailerRecipients");

				entity.Property(e => e.AccountName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactEmail)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.DateSent).HasColumnType("datetime");

				entity.Property(e => e.FkMailerId).HasColumnName("FK_MailerId");

				entity.HasOne(d => d.FkMailer)
					.WithMany(p => p.AlpMailerRecipients)
					.HasForeignKey(d => d.FkMailerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_alpMailerRecipients_alpMailerUpdates");
			});

			modelBuilder.Entity<AlpMailerUpdates>(entity =>
			{
				entity.ToTable("alpMailerUpdates");

				entity.Property(e => e.Bcc)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.FkAuthor).HasColumnName("FK_Author");

				entity.Property(e => e.Message).HasColumnType("text");

				entity.Property(e => e.ScheduledDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<AlpmidYearDatas>(entity =>
			{
				entity.HasKey(e => new { e.CustomerCode, e.Year });

				entity.ToTable("ALPMidYearDatas");

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Year).HasColumnName("year");

				entity.Property(e => e.AlpBranding).HasColumnName("alp_branding");

				entity.Property(e => e.AlpClothing).HasColumnName("alp_clothing");

				entity.Property(e => e.AlpGifts).HasColumnName("alp_gifts");

				entity.Property(e => e.AlpTotal).HasColumnName("alp_total");

				entity.Property(e => e.ContactPerson)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SpendBranding).HasColumnName("spend_branding");

				entity.Property(e => e.SpendClothing).HasColumnName("spend_clothing");

				entity.Property(e => e.SpendGifts).HasColumnName("spend_gifts");

				entity.Property(e => e.SpendTotal).HasColumnName("spend_total");
			});

			modelBuilder.Entity<Alpoverride>(entity =>
			{
				entity.ToTable("ALPOverride");

				entity.Property(e => e.ItemCodeClear)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AlppointRuleBonusTypes>(entity =>
			{
				entity.ToTable("ALPPointRuleBonusTypes");

				entity.HasIndex(e => e.Name)
					.HasName("IX_ALPPointRuleBonusTypes")
					.IsUnique();

				entity.Property(e => e.DisplayName)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AlppointRules>(entity =>
			{
				entity.ToTable("ALPPointRules");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkAlpid).HasColumnName("FK_ALPId");

				entity.Property(e => e.FkAlppointRuleId).HasColumnName("FK_ALPPointRuleId");

				entity.Property(e => e.FkBrandId)
					.HasColumnName("FK_BrandId")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.ValidFrom).HasColumnType("datetime");

				entity.Property(e => e.ValidTo).HasColumnType("datetime");

				entity.HasOne(d => d.FkAlp)
					.WithMany(p => p.AlppointRules)
					.HasForeignKey(d => d.FkAlpid)
					.HasConstraintName("FK_ALPPointsRules_ALPS");

				entity.HasOne(d => d.FkAlppointRule)
					.WithMany(p => p.InverseFkAlppointRule)
					.HasForeignKey(d => d.FkAlppointRuleId)
					.HasConstraintName("FK_ALPPointRules_ALPPointRules");
			});

			modelBuilder.Entity<AlppointRuleValues>(entity =>
			{
				entity.ToTable("ALPPointRuleValues");

				entity.Property(e => e.FkAlppointsMultiplierRuleId).HasColumnName("FK_ALPPointsMultiplierRuleId");

				entity.Property(e => e.Value)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkAlppointsMultiplierRule)
					.WithMany(p => p.AlppointRuleValues)
					.HasForeignKey(d => d.FkAlppointsMultiplierRuleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ALPPointsMultiplierRuleValues_ALPPointsMultiplierRules");
			});

			modelBuilder.Entity<AlppointsTypes>(entity =>
			{
				entity.ToTable("ALPPointsTypes");

				entity.HasIndex(e => e.Type)
					.HasName("IX_ALPPointsMultiplierTypes")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkAlpid).HasColumnName("FK_ALPId");

				entity.Property(e => e.Name)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkAlp)
					.WithMany(p => p.AlppointsTypes)
					.HasForeignKey(d => d.FkAlpid)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ALPPointsMultiplierTypes_ALPS");
			});

			modelBuilder.Entity<Alppromotion>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("ALPPromotion");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(50)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.ValidFrom).HasColumnType("date");

				entity.Property(e => e.ValidTo).HasColumnType("date");
			});

			modelBuilder.Entity<Alps>(entity =>
			{
				entity.ToTable("ALPS");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CutOffDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<Alptargets>(entity =>
			{
				entity.ToTable("ALPTargets");

				entity.Property(e => e.ColorCode)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DisplayName)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkAlpid).HasColumnName("FK_ALPId");

				entity.HasOne(d => d.FkAlp)
					.WithMany(p => p.Alptargets)
					.HasForeignKey(d => d.FkAlpid)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ALPTargets_ALPS");
			});

			modelBuilder.Entity<AlptempData>(entity =>
			{
				entity.ToTable("ALPTempData");

				entity.Property(e => e.AccountManager)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BeginStatus)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Branding)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BrandingAlp)
					.HasColumnName("BrandingALP")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CarryOver)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CarryOverInto)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Cloting)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ClotingAlp)
					.HasColumnName("ClotingALP")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.EndStatus)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Gifts)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.GiftsAlp)
					.HasColumnName("GiftsALP")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Headwear)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.HeadwearAlp)
					.HasColumnName("HeadwearALP")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PromotionAlp)
					.HasColumnName("PromotionALP")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ShortFall)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Total)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.TotalAlp)
					.HasColumnName("TotalALP")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Alptypes>(entity =>
			{
				entity.ToTable("ALPTypes");

				entity.Property(e => e.Type)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Alpvalues>(entity =>
			{
				entity.ToTable("ALPValues");

				entity.HasIndex(e => new { e.Created, e.Year, e.Month, e.Reference1, e.Alp, e.SalesValue, e.Units, e.InventoryType, e.SubType, e.CustomerCode, e.IsStatic, e.Type })
					.HasName("ix_ALPValues_CustomerCode_IsStatic_Type_includes");

				entity.HasIndex(e => new { e.Id, e.Created, e.Month, e.Reference1, e.Reference2, e.Reference3, e.Alp, e.SalesValue, e.Units, e.InventoryType, e.Type, e.SubType, e.Flags, e.Year, e.CustomerCode, e.IsStatic })
					.HasName("ix_ALPValues_Year_CustomerCode_IsStatic_includes");

				entity.HasIndex(e => new { e.Id, e.Created, e.Year, e.Month, e.CustomerCode, e.Reference2, e.Reference3, e.Alp, e.SalesValue, e.Units, e.IsStatic, e.InventoryType, e.Type, e.SubType, e.Flags, e.Reference1 })
					.HasName("ix_ALPValues_Reference1_includes");

				entity.Property(e => e.Alp).HasColumnName("ALP");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Reference1)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Reference2)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Reference3)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ApiIntegrator>(entity =>
			{
				entity.ToTable("apiIntegrator");

				entity.Property(e => e.Ips)
					.HasColumnName("IPs")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Token).HasMaxLength(255);
			});

			modelBuilder.Entity<ApiIntegratorImpersonations>(entity =>
			{
				entity.ToTable("apiIntegratorImpersonations");

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkIntegratorId).HasColumnName("fk_IntegratorId");

				entity.HasOne(d => d.FkIntegrator)
					.WithMany(p => p.ApiIntegratorImpersonations)
					.HasForeignKey(d => d.FkIntegratorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_sIntegratorInpersonations_sIntegrator");
			});

			modelBuilder.Entity<ApiIntegratorPermissions>(entity =>
			{
				entity.HasKey(e => new { e.FkIntegratorId, e.FkPermissionId });

				entity.ToTable("apiIntegratorPermissions");

				entity.Property(e => e.FkIntegratorId).HasColumnName("FK_IntegratorId");

				entity.Property(e => e.FkPermissionId).HasColumnName("FK_PermissionId");

				entity.HasOne(d => d.FkIntegrator)
					.WithMany(p => p.ApiIntegratorPermissions)
					.HasForeignKey(d => d.FkIntegratorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_sIntegratorPermissions_sIntegrator");

				entity.HasOne(d => d.FkPermission)
					.WithMany(p => p.ApiIntegratorPermissions)
					.HasForeignKey(d => d.FkPermissionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_sIntegratorPermissions_sPermissions");
			});

			modelBuilder.Entity<ApiIntegratorRoles>(entity =>
			{
				entity.HasKey(e => new { e.FkIntegratorId, e.FkRoleId });

				entity.ToTable("apiIntegratorRoles");

				entity.Property(e => e.FkIntegratorId).HasColumnName("FK_IntegratorId");

				entity.Property(e => e.FkRoleId).HasColumnName("FK_RoleId");

				entity.HasOne(d => d.FkIntegrator)
					.WithMany(p => p.ApiIntegratorRoles)
					.HasForeignKey(d => d.FkIntegratorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_sIntegratorRoles_sIntegrator");

				entity.HasOne(d => d.FkRole)
					.WithMany(p => p.ApiIntegratorRoles)
					.HasForeignKey(d => d.FkRoleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_sIntegratorRoles_sRoles");
			});

			modelBuilder.Entity<ApiLoginTokens>(entity =>
			{
				entity.ToTable("apiLoginTokens");

				entity.Property(e => e.ClientId)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Token)
					.IsRequired()
					.HasMaxLength(255);
			});

			modelBuilder.Entity<ApiPermissions>(entity =>
			{
				entity.ToTable("apiPermissions");

				entity.Property(e => e.Action)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Controller)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ApiRolePermissions>(entity =>
			{
				entity.HasKey(e => new { e.FkRoleId, e.FkPermissionId });

				entity.ToTable("apiRolePermissions");

				entity.Property(e => e.FkRoleId).HasColumnName("FK_RoleId");

				entity.Property(e => e.FkPermissionId).HasColumnName("FK_PermissionId");

				entity.HasOne(d => d.FkPermission)
					.WithMany(p => p.ApiRolePermissions)
					.HasForeignKey(d => d.FkPermissionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_sRolePermissions_sPermissions");

				entity.HasOne(d => d.FkRole)
					.WithMany(p => p.ApiRolePermissions)
					.HasForeignKey(d => d.FkRoleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_sRolePermissions_sRoles");
			});

			modelBuilder.Entity<ApiRoles>(entity =>
			{
				entity.ToTable("apiRoles");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<AsmDevice>(entity =>
			{
				entity.HasKey(e => e.DeviceId);

				entity.ToTable("ASM_Device");

				entity.Property(e => e.DeviceId).ValueGeneratedNever();

				entity.Property(e => e.AssetTag)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.FkDeviceModelId).HasColumnName("FK_DeviceModelId");

				entity.Property(e => e.FkManagerId).HasColumnName("FK_ManagerID");

				entity.Property(e => e.SerialNumber)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.FkDeviceModel)
					.WithMany(p => p.AsmDevice)
					.HasForeignKey(d => d.FkDeviceModelId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ASM_DeviceModelsASM_Device");

				entity.HasOne(d => d.FkManager)
					.WithMany(p => p.AsmDevice)
					.HasForeignKey(d => d.FkManagerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserASM_Device");
			});

			modelBuilder.Entity<AsmDeviceManufacturer>(entity =>
			{
				entity.HasKey(e => e.ManufacturerId);

				entity.ToTable("ASM_DeviceManufacturer");

				entity.Property(e => e.ManufacturerId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<AsmDeviceModels>(entity =>
			{
				entity.HasKey(e => e.ModelId);

				entity.ToTable("ASM_DeviceModels");

				entity.Property(e => e.ModelId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkDeviceManufacturerId).HasColumnName("FK_DeviceManufacturerId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);

				entity.HasOne(d => d.FkDeviceManufacturer)
					.WithMany(p => p.AsmDeviceModels)
					.HasForeignKey(d => d.FkDeviceManufacturerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ASM_DeviceManufacturerASM_DeviceModels");
			});

			modelBuilder.Entity<AsmDeviceNotes>(entity =>
			{
				entity.HasKey(e => e.NoteId);

				entity.ToTable("ASM_DeviceNotes");

				entity.Property(e => e.NoteId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkDeviceId).HasColumnName("FK_DeviceId");

				entity.Property(e => e.FkNoteCreator).HasColumnName("FK_NoteCreator");

				entity.Property(e => e.NoteData).IsRequired();

				entity.HasOne(d => d.FkDevice)
					.WithMany(p => p.AsmDeviceNotes)
					.HasForeignKey(d => d.FkDeviceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ASM_DeviceASM_DeviceNotes");

				entity.HasOne(d => d.FkNoteCreatorNavigation)
					.WithMany(p => p.AsmDeviceNotes)
					.HasForeignKey(d => d.FkNoteCreator)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_History_ContributorASM_DeviceNotes");
			});

			modelBuilder.Entity<AsmDeviceOperators>(entity =>
			{
				entity.HasKey(e => new { e.FkDeviceId, e.FkOperatorId })
					.ForSqlServerIsClustered(false);

				entity.ToTable("ASM_DeviceOperators");

				entity.Property(e => e.FkDeviceId).HasColumnName("FK_DeviceId");

				entity.Property(e => e.FkOperatorId).HasColumnName("FK_OperatorId");

				entity.HasOne(d => d.FkDevice)
					.WithMany(p => p.AsmDeviceOperators)
					.HasForeignKey(d => d.FkDeviceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ASM_DeviceOperators_ASM_Device");

				entity.HasOne(d => d.FkOperator)
					.WithMany(p => p.AsmDeviceOperators)
					.HasForeignKey(d => d.FkOperatorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ASM_DeviceOperators_User");
			});

			modelBuilder.Entity<AsmLogBook>(entity =>
			{
				entity.HasKey(e => e.LogId);

				entity.ToTable("ASM_LogBook");

				entity.Property(e => e.DateIn).HasColumnType("datetime");

				entity.Property(e => e.DateOut).HasColumnType("datetime");

				entity.Property(e => e.FkDeviceId).HasColumnName("FK_DeviceId");

				entity.Property(e => e.FkInReceivedFromId).HasColumnName("FK_In_ReceivedFromId");

				entity.Property(e => e.FkInReceiverId).HasColumnName("FK_In_ReceiverId");

				entity.Property(e => e.FkOutIssuerId).HasColumnName("FK_Out_IssuerId");

				entity.Property(e => e.FkOutReceivedId).HasColumnName("FK_Out_ReceivedId");

				entity.Property(e => e.ReceivedBigo).HasColumnName("ReceivedBIGO");

				entity.Property(e => e.ReceivedIgo).HasColumnName("ReceivedIGO");
			});

			modelBuilder.Entity<AudBrandingConversionDatas>(entity =>
			{
				entity.HasKey(e => e.AuditId);

				entity.ToTable("aud_BrandingConversionDatas");

				entity.Property(e => e.AuditDate).HasColumnType("datetime");

				entity.Property(e => e.BrandingCode).HasMaxLength(50);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.LinkDocumentNumber).HasMaxLength(50);

				entity.Property(e => e.SalesmanCode)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.SalesmanCodeOverride)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<AuditDocuments>(entity =>
			{
				entity.HasKey(e => e.AId);

				entity.ToTable("auditDocuments");

				entity.Property(e => e.AId).HasColumnName("aId");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<Barcodes>(entity =>
			{
				entity.HasKey(e => e.BarcodeId);

				entity.Property(e => e.BarcodeId).ValueGeneratedNever();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(10);
			});

			modelBuilder.Entity<Baskets>(entity =>
			{
				entity.HasKey(e => e.BasketId);

				entity.HasIndex(e => e.Barcode)
					.HasName("UK_BasketBarcode")
					.IsUnique();

				entity.HasIndex(e => e.Name)
					.HasName("UK_BasketName")
					.IsUnique();

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.BranchCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Brand)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkBasketId).HasColumnName("FK_BasketId");

				entity.Property(e => e.FromBranchCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBasket)
					.WithMany(p => p.InverseFkBasket)
					.HasForeignKey(d => d.FkBasketId)
					.HasConstraintName("FK_Baskets_Baskets");
			});

			modelBuilder.Entity<BasketSessionItems>(entity =>
			{
				entity.HasIndex(e => new { e.BasketSessionItemsId, e.ItemCode, e.Quantity, e.CreatedDate, e.OrderNumber, e.CreditNumber, e.CreatedUserId, e.FkBasketSessionId, e.Status })
					.HasName("ix_BasketSessionItems_FK_BasketSessionId_Status_includes");

				entity.Property(e => e.BoxBarcode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ClosedDate).HasColumnType("datetime");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CreditNumber)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.FkBasketSessionId).HasColumnName("FK_BasketSessionId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.OpenDate).HasColumnType("datetime");

				entity.Property(e => e.OrderNumber)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBasketSession)
					.WithMany(p => p.BasketSessionItems)
					.HasForeignKey(d => d.FkBasketSessionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasketSessionBasketSessionItems");
			});

			modelBuilder.Entity<BasketSessions>(entity =>
			{
				entity.HasKey(e => e.BasketSessionId);

				entity.Property(e => e.ClosedDate).HasColumnType("datetime");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkBasketId).HasColumnName("FK_BasketId");

				entity.Property(e => e.LocationName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.OpenDate).HasColumnType("datetime");

				entity.HasOne(d => d.FkBasket)
					.WithMany(p => p.BasketSessions)
					.HasForeignKey(d => d.FkBasketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasketBasketSession");
			});

			modelBuilder.Entity<BasketSessionTrackings>(entity =>
			{
				entity.HasKey(e => e.BasketSessionTrackingId);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkBasketSessionId).HasColumnName("FK_BasketSessionId");

				entity.Property(e => e.FkBasketSessionItemId).HasColumnName("FK_BasketSessionItemId");

				entity.HasOne(d => d.FkBasketSession)
					.WithMany(p => p.BasketSessionTrackings)
					.HasForeignKey(d => d.FkBasketSessionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BasketSessionBasketSessionTracking");

				entity.HasOne(d => d.FkBasketSessionItem)
					.WithMany(p => p.BasketSessionTrackings)
					.HasForeignKey(d => d.FkBasketSessionItemId)
					.HasConstraintName("FK_BasketSessionTrackings_BasketSessionItems");
			});

			modelBuilder.Entity<BlanketAcceptances>(entity =>
			{
				entity.HasKey(e => e.BlanketAcceptanceId);

				entity.HasIndex(e => new { e.CustomerCode, e.BlanketType })
					.HasName("UK_BlanketAcceptances")
					.IsUnique();

				entity.Property(e => e.BlanketAcceptanceId).ValueGeneratedNever();

				entity.Property(e => e.AcceptedBy)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.BranchCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.ContactDesignation)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.ContactEmail)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.ContactNumber)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<BranchAddresses>(entity =>
			{
				entity.HasKey(e => new { e.FkBranchId, e.FkAddressId });

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkAddressId).HasColumnName("FK_AddressId");

				entity.HasOne(d => d.FkAddress)
					.WithMany(p => p.BranchAddresses)
					.HasForeignKey(d => d.FkAddressId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchAddresses_Addresses");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchAddresses)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchAddresses_Branches");
			});

			modelBuilder.Entity<BranchAlps>(entity =>
			{
				entity.HasKey(e => new { e.FkBranchId, e.FkAlpid });

				entity.ToTable("BranchALPS");

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkAlpid).HasColumnName("FK_ALPId");

				entity.HasOne(d => d.FkAlp)
					.WithMany(p => p.BranchAlps)
					.HasForeignKey(d => d.FkAlpid)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchALPS_ALPS");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchAlps)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchALPS_Branches");
			});

			modelBuilder.Entity<BranchAttributes>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkAttributeTemplateId).HasColumnName("FK_AttributeTemplateId");

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.StringValue)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.TextValue).HasColumnType("text");

				entity.HasOne(d => d.FkAttributeTemplate)
					.WithMany(p => p.BranchAttributes)
					.HasForeignKey(d => d.FkAttributeTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_branchAttributes_branchAttributeTemplates");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchAttributes)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_branchAttributes_Branches");
			});

			modelBuilder.Entity<BranchAttributeTemplateOptionValues>(entity =>
			{
				entity.ToTable("branchAttributeTemplateOptionValues");

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
					.WithMany(p => p.BranchAttributeTemplateOptionValues)
					.HasForeignKey(d => d.FkTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_branchAttributeTemplateOptionValues_branchAttributeTemplates");
			});

			modelBuilder.Entity<BranchAttributeTemplates>(entity =>
			{
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

			modelBuilder.Entity<BranchContactNumbers>(entity =>
			{
				entity.HasKey(e => new { e.FkBranchId, e.FkContactNumbersId });

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkContactNumbersId).HasColumnName("FK_ContactNumbersId");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchContactNumbers)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchContactNumbers_Branches");

				entity.HasOne(d => d.FkContactNumbers)
					.WithMany(p => p.BranchContactNumbers)
					.HasForeignKey(d => d.FkContactNumbersId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchContactNumbers_ContactNumbers");
			});

			modelBuilder.Entity<BranchDelivery>(entity =>
			{
				entity.Property(e => e.BranchCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DeliveryNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DispatchedDate).HasColumnType("datetime");

				entity.Property(e => e.DispatchedDateWaitingPoddate)
					.HasColumnName("DispatchedDateWaitingPODDate")
					.HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.HandOverDate).HasColumnType("datetime");

				entity.Property(e => e.Prefix)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

				entity.Property(e => e.SendDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<BranchDeliveryCourierInfoes>(entity =>
			{
				entity.Property(e => e.FkBranchDeliveryId).HasColumnName("FK_BranchDeliveryId");

				entity.Property(e => e.ParcelId)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.ShipmentId)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBranchDelivery)
					.WithMany(p => p.BranchDeliveryCourierInfoes)
					.HasForeignKey(d => d.FkBranchDeliveryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchDeliveryCourierInfoes_BranchDelivery");
			});

			modelBuilder.Entity<BranchDeliveryParcels>(entity =>
			{
				entity.HasIndex(e => e.ParcelId)
					.HasName("IX_BranchDeliveryParcels")
					.IsUnique();

				entity.Property(e => e.FkBranchDeliveryId).HasColumnName("FK_BranchDeliveryId");

				entity.HasOne(d => d.FkBranchDelivery)
					.WithMany(p => p.BranchDeliveryParcels)
					.HasForeignKey(d => d.FkBranchDeliveryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchDelivery_Parcels_BranchDelivery");
			});

			modelBuilder.Entity<BranchDeliveryProcesses>(entity =>
			{
				entity.Property(e => e.BranchPrefix)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DateProcessed).HasColumnType("datetime");

				entity.Property(e => e.FromFile)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Identifier)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.VParam1)
					.HasColumnName("v_param1")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.VParam2)
					.HasColumnName("v_param2")
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BranchDeliveryProcessTracking>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkBranchDeliveryProcessId).HasColumnName("FK_BranchDeliveryProcessId");

				entity.Property(e => e.TrackDescription)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBranchDeliveryProcess)
					.WithMany(p => p.BranchDeliveryProcessTracking)
					.HasForeignKey(d => d.FkBranchDeliveryProcessId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchDeliveryProcessTracking_BranchDeliveryProcesses");
			});

			modelBuilder.Entity<BranchDeliveryRequestResponses>(entity =>
			{
				entity.HasKey(e => e.ResponseId);

				entity.HasIndex(e => new { e.Branch, e.BranchDeliveryRequestId })
					.HasName("IX_BranchDeliveryRequestResponses_BranchDeliveryRequestId");

				entity.Property(e => e.ResponseId).ValueGeneratedNever();

				entity.Property(e => e.Branch)
					.IsRequired()
					.HasMaxLength(3);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ReferenceNumber)
					.IsRequired()
					.HasMaxLength(10);

				entity.HasOne(d => d.BranchDeliveryRequest)
					.WithMany(p => p.BranchDeliveryRequestResponses)
					.HasForeignKey(d => d.BranchDeliveryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchDeliveryRequestBranchDeliveryRequestResponse");
			});

			modelBuilder.Entity<BranchDeliveryRequests>(entity =>
			{
				entity.HasKey(e => e.BranchDeliveryRequestId);

				entity.HasIndex(e => e.DocumentNumber);

				entity.HasIndex(e => e.ReferenceNumber)
					.HasName("ix_BranchDeliveryRequests_ReferenceNumber");

				entity.Property(e => e.BranchDeliveryRequestId).ValueGeneratedNever();

				entity.Property(e => e.Branch)
					.IsRequired()
					.HasMaxLength(3);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Recipient)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.ReferenceNumber)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Branches>(entity =>
			{
				entity.Property(e => e.BranchCode)
					.HasMaxLength(32)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.BranchName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CompanyCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false)
					.HasDefaultValueSql("('EMPTY')");

				entity.Property(e => e.CompanyName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false)
					.HasDefaultValueSql("('EMPTY')");

				entity.Property(e => e.FkCurrencyId).HasColumnName("FK_CurrencyId");

				entity.Property(e => e.InFolder)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.OutFolder)
					.IsRequired()
					.HasColumnName("outFolder")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Prefix)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.RegNumber)
					.IsRequired()
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasDefaultValueSql("('EMPTY')");

				entity.Property(e => e.Status)
					.IsRequired()
					.HasMaxLength(128)
					.IsUnicode(false)
					.HasDefaultValueSql("('ACTIVE')");

				entity.Property(e => e.TradingName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false)
					.HasDefaultValueSql("('EMPTY')");

				entity.Property(e => e.VatNumber)
					.IsRequired()
					.HasMaxLength(64)
					.IsUnicode(false)
					.HasDefaultValueSql("('EMPTY')");

				entity.HasOne(d => d.FkCurrency)
					.WithMany(p => p.Branches)
					.HasForeignKey(d => d.FkCurrencyId)
					.HasConstraintName("FK_Branches_Currency");
			});

			modelBuilder.Entity<BranchInvoiceType>(entity =>
			{
				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkPrimaryBranchId).HasColumnName("FK_PrimaryBranchId");

				entity.Property(e => e.FkPrimaryBranchWarehouseId).HasColumnName("FK_PrimaryBranchWarehouseId");

				entity.Property(e => e.FkSecondaryBranchId).HasColumnName("FK_SecondaryBranchId");

				entity.Property(e => e.FkSecondaryBranchWarehouseId).HasColumnName("FK_SecondaryBranchWarehouseId");

				entity.Property(e => e.Name)
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.PastelDangerousGoodsCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.PastelInvoiceCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchInvoiceTypeFkBranch)
					.HasForeignKey(d => d.FkBranchId)
					.HasConstraintName("FK_BranchInvoiceType_Branches");

				entity.HasOne(d => d.FkPrimaryBranch)
					.WithMany(p => p.BranchInvoiceTypeFkPrimaryBranch)
					.HasForeignKey(d => d.FkPrimaryBranchId)
					.HasConstraintName("FK_BranchInvoiceType_PrimaryBranch");

				entity.HasOne(d => d.FkPrimaryBranchWarehouse)
					.WithMany(p => p.BranchInvoiceTypeFkPrimaryBranchWarehouse)
					.HasForeignKey(d => d.FkPrimaryBranchWarehouseId)
					.HasConstraintName("FK_BranchInvoiceType_PrimaryBranchWarehouse");

				entity.HasOne(d => d.FkSecondaryBranch)
					.WithMany(p => p.BranchInvoiceTypeFkSecondaryBranch)
					.HasForeignKey(d => d.FkSecondaryBranchId)
					.HasConstraintName("FK_BranchInvoiceType_SecondaryBranch");

				entity.HasOne(d => d.FkSecondaryBranchWarehouse)
					.WithMany(p => p.BranchInvoiceTypeFkSecondaryBranchWarehouse)
					.HasForeignKey(d => d.FkSecondaryBranchWarehouseId)
					.HasConstraintName("FK_BranchInvoiceType_SecondaryBranchWarehouse");
			});

			modelBuilder.Entity<BranchInvoiceTypeShipment>(entity =>
			{
				entity.Property(e => e.FkBranchInvoiceTypeId).HasColumnName("FK_BranchInvoiceTypeId");

				entity.HasOne(d => d.FkBranchInvoiceType)
					.WithMany(p => p.BranchInvoiceTypeShipment)
					.HasForeignKey(d => d.FkBranchInvoiceTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchInvoiceTypeShipment_BranchInvoiceType");
			});

			modelBuilder.Entity<BranchRules>(entity =>
			{
				entity.Property(e => e.FkBranchInvoiceTypeId).HasColumnName("FK_BranchInvoiceTypeId");

				entity.Property(e => e.FkBranchInvoiceTypeShipmentId).HasColumnName("FK_BranchInvoiceTypeShipmentId");

				entity.HasOne(d => d.FkBranchInvoiceType)
					.WithMany(p => p.BranchRules)
					.HasForeignKey(d => d.FkBranchInvoiceTypeId)
					.HasConstraintName("FK_BranchRules_BranchInvoiceType");

				entity.HasOne(d => d.FkBranchInvoiceTypeShipment)
					.WithMany(p => p.BranchRules)
					.HasForeignKey(d => d.FkBranchInvoiceTypeShipmentId)
					.HasConstraintName("FK_BranchRules_BranchInvoiceTypeShipment");
			});

			modelBuilder.Entity<BranchRuleValues>(entity =>
			{
				entity.Property(e => e.FkBranchRuleId).HasColumnName("FK_BranchRuleId");

				entity.Property(e => e.Value)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBranchRule)
					.WithMany(p => p.BranchRuleValues)
					.HasForeignKey(d => d.FkBranchRuleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchRuleValues_BranchRules");
			});

			modelBuilder.Entity<BranchServers>(entity =>
			{
				entity.HasKey(e => new { e.FkBranchId, e.FkServerId });

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkServerId).HasColumnName("FK_ServerId");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchServers)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchServers_Branches");

				entity.HasOne(d => d.FkServer)
					.WithMany(p => p.BranchServers)
					.HasForeignKey(d => d.FkServerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchServers_ServerDetails");
			});

			modelBuilder.Entity<BranchSetting>(entity =>
			{
				entity.Property(e => e.Address)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ContactPerson)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Country)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Courier)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CourierAddress)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.CourierPdfpath)
					.IsRequired()
					.HasColumnName("CourierPDFPath")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkBranchId).HasColumnName("FK_Branch_Id");

				entity.Property(e => e.PhoneNumber)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchSetting)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchSetting_Branches");
			});

			modelBuilder.Entity<BranchWarehouse>(entity =>
			{
				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(128)
					.IsUnicode(false);
			});

			modelBuilder.Entity<BranchWarehouseLink>(entity =>
			{
				entity.HasKey(e => new { e.FkBranchId, e.FkBranchWarehouseId });

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.FkBranchWarehouseId).HasColumnName("FK_BranchWarehouseId");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchWarehouseLink)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchWarehouseLink_Branches");

				entity.HasOne(d => d.FkBranchWarehouse)
					.WithMany(p => p.BranchWarehouseLink)
					.HasForeignKey(d => d.FkBranchWarehouseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchWarehouseLink_BranchWarehouse");
			});

			modelBuilder.Entity<BranchWifi>(entity =>
			{
				entity.Property(e => e.FkAuthenticationId).HasColumnName("FK_AuthenticationId");

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.Ssid)
					.IsRequired()
					.HasColumnName("SSID")
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.BranchWifi)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BranchWifi_Branches");
			});

			modelBuilder.Entity<BrandingConversionAldatas>(entity =>
			{
				entity.ToTable("BrandingConversionALDatas");

				entity.HasIndex(e => e.DocumentNumber)
					.HasName("IX_BCALDocumentNumber");

				entity.HasIndex(e => new { e.Day, e.Month, e.Year, e.DocumentNumber, e.ItemCode, e.LinkDocumentNumber, e.Flags, e.SalesmanCodeOverride, e.BrandingQuantity })
					.HasName("ix_BrandingConversionALDatas_SalesmanCodeOverride_BrandingQuantity_includes");

				entity.HasIndex(e => new { e.Day, e.Month, e.Year, e.DocumentNumber, e.ItemCode, e.LinkDocumentNumber, e.Flags, e.SalesmanCodeOverride, e.StockQuantity })
					.HasName("ix_BrandingConversionALDatas_SalesmanCodeOverride_StockQuantity_includes");

				entity.Property(e => e.AudTimestamp)
					.HasColumnName("audTimestamp")
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.BrandingCode).HasMaxLength(50);

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.LinkDocumentNumber).HasMaxLength(50);

				entity.Property(e => e.SalesmanCode)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.SalesmanCodeOverride)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<BrandingConversionDatas>(entity =>
			{
				entity.Property(e => e.BrandingCode).HasMaxLength(50);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.LinkDocumentNumber).HasMaxLength(50);

				entity.Property(e => e.SalesmanCode)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.SalesmanCodeOverride)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<BrandingConversionGroups>(entity =>
			{
				entity.HasKey(e => e.GroupId);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkOwnerId).HasColumnName("FK_OwnerId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkOwner)
					.WithMany(p => p.BrandingConversionGroups)
					.HasForeignKey(d => d.FkOwnerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingConversionGroupOwners");
			});

			modelBuilder.Entity<BrandingConversionMembers>(entity =>
			{
				entity.HasKey(e => e.MemberId);

				entity.Property(e => e.FkGroupId).HasColumnName("FK_GroupId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkGroup)
					.WithMany(p => p.BrandingConversionMembers)
					.HasForeignKey(d => d.FkGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingConversionMembers_BrandingConversionGroups");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.BrandingConversionMembers)
					.HasForeignKey(d => d.FkUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingConversionMembers_Users");
			});

			modelBuilder.Entity<BrandingInfoLine>(entity =>
			{
				entity.Property(e => e.ContactIds)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DownloadLogoPath)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ExactRepeatJobCardNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkLineId).HasColumnName("FK_LineId");

				entity.Property(e => e.FoilColour)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.LayoutNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.LogoCreated).HasColumnType("datetime");

				entity.Property(e => e.LogoName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.LogoRepeatJobCardNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PantoneColour)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Position)
					.IsRequired()
					.HasMaxLength(250)
					.IsUnicode(false);

				entity.Property(e => e.Size)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.SpecialInstructions)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.VinylColour)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkLine)
					.WithMany(p => p.BrandingInfoLine)
					.HasForeignKey(d => d.FkLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingInfoLine_Lines");
			});

			modelBuilder.Entity<BrandingLineInfo>(entity =>
			{
				entity.HasIndex(e => new { e.Flags, e.FkLineId })
					.HasName("IX_BrandingLineInfo_LineId_Flags");

				entity.Property(e => e.BrandingPosition)
					.IsRequired()
					.HasMaxLength(1)
					.IsUnicode(false);

				entity.Property(e => e.FkLineId).HasColumnName("FK_LineId");

				entity.Property(e => e.LogoName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.LogoPosition)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PrintColours)
					.HasMaxLength(1024)
					.IsUnicode(false);

				entity.Property(e => e.Repeatreference)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.SpecialInstructions)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.HasOne(d => d.FkLine)
					.WithMany(p => p.BrandingLineInfo)
					.HasForeignKey(d => d.FkLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingLineInfo_Lines");
			});

			modelBuilder.Entity<BrandingLineInfoAttachments>(entity =>
			{
				entity.Property(e => e.FkBrandingInfoLineId).HasColumnName("FK_BrandingInfoLineId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Url)
					.IsRequired()
					.IsUnicode(false);

				entity.HasOne(d => d.FkBrandingInfoLine)
					.WithMany(p => p.BrandingLineInfoAttachments)
					.HasForeignKey(d => d.FkBrandingInfoLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingLineInfoAttachments_BrandingLineInfo");
			});

			modelBuilder.Entity<BrandingLineInfoContacts>(entity =>
			{
				entity.HasIndex(e => new { e.FkAccountContactId, e.FkBrandingInfoLineId })
					.HasName("IX_BrandingLineInfoContacts")
					.IsUnique();

				entity.Property(e => e.FkAccountContactId).HasColumnName("FK_AccountContactId");

				entity.Property(e => e.FkBrandingInfoLineId).HasColumnName("FK_BrandingInfoLineId");

				entity.HasOne(d => d.FkAccountContact)
					.WithMany(p => p.BrandingLineInfoContacts)
					.HasForeignKey(d => d.FkAccountContactId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingLineInfoContacts_AccountContacts");

				entity.HasOne(d => d.FkBrandingInfoLine)
					.WithMany(p => p.BrandingLineInfoContacts)
					.HasForeignKey(d => d.FkBrandingInfoLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BrandingLineInfoContacts_BrandingLineInfo");
			});

			modelBuilder.Entity<BudgetedTurnover>(entity =>
			{
				entity.Property(e => e.Branding).HasColumnType("money");

				entity.Property(e => e.Clothing).HasColumnType("money");

				entity.Property(e => e.Gifts).HasColumnType("money");
			});

			modelBuilder.Entity<ClientContact>(entity =>
			{
				entity.Property(e => e.ContactNumber)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Email)
					.HasMaxLength(320)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ClientDelivery>(entity =>
			{
				entity.HasKey(e => e.FkAccountId);

				entity.HasIndex(e => e.FkClientContactId)
					.HasName("IX_ClientDelivery")
					.IsUnique();

				entity.Property(e => e.FkAccountId)
					.HasColumnName("FK_AccountId")
					.ValueGeneratedNever();

				entity.Property(e => e.FkClientContactId).HasColumnName("FK_ClientContactId");

				entity.Property(e => e.FkClientDeliveryAddressId).HasColumnName("FK_ClientDeliveryAddressId");

				entity.HasOne(d => d.FkClientContact)
					.WithOne(p => p.ClientDelivery)
					.HasForeignKey<ClientDelivery>(d => d.FkClientContactId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientDelivery_ClientContact");

				entity.HasOne(d => d.FkClientDeliveryAddress)
					.WithMany(p => p.ClientDelivery)
					.HasForeignKey(d => d.FkClientDeliveryAddressId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientDelivery_ClientDeliveryAddress");
			});

			modelBuilder.Entity<ClientDeliveryAddress>(entity =>
			{
				entity.Property(e => e.BranchCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FriendlyName)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.OfficeBuilding)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(5)
					.IsUnicode(false);

				entity.Property(e => e.Province)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.StreetName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.StreetNumber)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Suburb)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SuiteNo)
					.HasMaxLength(20)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ClientDocumentRequests>(entity =>
			{
				entity.HasKey(e => e.ClientRequestId);

				entity.Property(e => e.ClientRequestId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Recipient)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.ReferenceNumber)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<ClientDocumentResponses>(entity =>
			{
				entity.HasKey(e => e.ResponseId);

				entity.Property(e => e.ResponseId).ValueGeneratedNever();

				entity.Property(e => e.ClientDocumentRequestClientRequestId).HasColumnName("ClientDocumentRequest_ClientRequestId");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ReferenceNumber)
					.IsRequired()
					.HasMaxLength(10);

				entity.HasOne(d => d.ClientDocumentRequestClientRequest)
					.WithMany(p => p.ClientDocumentResponses)
					.HasForeignKey(d => d.ClientDocumentRequestClientRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ClientDocumentRequestClientDocumentResponse");
			});

			modelBuilder.Entity<CommercialBrandingDocuments>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DestinationBranchCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.InvoiceNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.SourceCompanyCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ContactNumbers>(entity =>
			{
				entity.Property(e => e.CountryCode)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Modified)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.RegionCode)
					.HasMaxLength(10)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreateInsuffiecients>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkUserTracking)
					.IsRequired()
					.HasColumnName("FK_UserTracking")
					.HasMaxLength(50);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<CreditLimitSettings>(entity =>
			{
				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditNoteLogs>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CreditNoteId).HasColumnName("CreditNoteID");

				entity.Property(e => e.CreditNoteNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CreditNoteRequestId)
					.HasColumnName("CreditNoteRequestID")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SalesOrderNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Success).HasColumnName("SUCCESS");
			});

			modelBuilder.Entity<CreditNoteProcesses>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CreditNoteNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkCreditNoteRequestId).HasColumnName("FK_CreditNoteRequestId");

				entity.Property(e => e.FkDestinationPastelCreditNoteId).HasColumnName("FK_DestinationPastelCreditNoteId");

				entity.Property(e => e.FkSourcePastelCreditNoteId).HasColumnName("FK_SourcePastelCreditNoteId");

				entity.Property(e => e.SalesOrderNumber)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditNoteRequestLogs>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Created)
					.HasColumnName("created")
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CreditNoteRequestId).HasColumnName("CreditNoteRequestID");

				entity.Property(e => e.ReferenceNumber)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CreditNoteRequestProcesses>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkCreditNoteRequestId).HasColumnName("FK_CreditNoteRequestId");

				entity.Property(e => e.ReferenceNumber)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Currency>(entity =>
			{
				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(10);

				entity.Property(e => e.DisplayFormat)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("('#')");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Symbol)
					.IsRequired()
					.HasMaxLength(5);
			});

			modelBuilder.Entity<DeliveryAddress>(entity =>
			{
				entity.Property(e => e.City)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.CompanyName)
					.HasMaxLength(500)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Country)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkAddressId).HasColumnName("FK_AddressId");

				entity.Property(e => e.OfficePark)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false)
					.HasDefaultValueSql("('')");

				entity.Property(e => e.Province)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.StreetLine1)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.StreetLine2)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Suburb)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.UnitNumber)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<DeliveryProvider>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<DeliveryProviderConfig>(entity =>
			{
				entity.Property(e => e.ApiproviderEndPoint)
					.HasColumnName("APIProviderEndPoint")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkDeliveryProviderId).HasColumnName("FK_DeliveryProviderId");

				entity.HasOne(d => d.FkDeliveryProvider)
					.WithMany(p => p.DeliveryProviderConfig)
					.HasForeignKey(d => d.FkDeliveryProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryProviderConfig_DeliveryProvider");
			});

			modelBuilder.Entity<DeliveryProviderServiceExclusions>(entity =>
			{
				entity.Property(e => e.FkDeliveryProviderId).HasColumnName("FK_DeliveryProviderId");

				entity.Property(e => e.FkItemId).HasColumnName("FK_ItemId");

				entity.Property(e => e.ServiceCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDeliveryProvider)
					.WithMany(p => p.DeliveryProviderServiceExclusions)
					.HasForeignKey(d => d.FkDeliveryProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryProviderServiceExclusions_DeliveryProvider");
			});

			modelBuilder.Entity<DeliveryProviderServiceLeadTimes>(entity =>
			{
				entity.HasKey(e => new { e.FkDeliveryProviderId, e.ServiceCode, e.Zone });

				entity.Property(e => e.FkDeliveryProviderId).HasColumnName("FK_DeliveryProviderId");

				entity.Property(e => e.ServiceCode)
					.HasMaxLength(15)
					.IsUnicode(false);

				entity.Property(e => e.Zone)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.LeadTime)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDeliveryProvider)
					.WithMany(p => p.DeliveryProviderServiceLeadTimes)
					.HasForeignKey(d => d.FkDeliveryProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK__DeliveryP__FK_De__48FB865E");
			});

			modelBuilder.Entity<DeliveryProviderServices>(entity =>
			{
				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkDeliveryProviderId).HasColumnName("FK_DeliveryProviderId");

				entity.Property(e => e.Service)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDeliveryProvider)
					.WithMany(p => p.DeliveryProviderServices)
					.HasForeignKey(d => d.FkDeliveryProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryProviderServices_DeliveryProvider");
			});

			modelBuilder.Entity<DeliveryQuote>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

				entity.Property(e => e.FkAccountContactId).HasColumnName("FK_AccountContactId");

				entity.Property(e => e.FkDeliveryProviderId).HasColumnName("FK_DeliveryProviderId");

				entity.Property(e => e.FkDeliveryQuoteAddressId).HasColumnName("FK_DeliveryQuoteAddressId");

				entity.Property(e => e.FkDeliveryQuoteDetailId).HasColumnName("FK_DeliveryQuoteDetailId");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDeliveryProvider)
					.WithMany(p => p.DeliveryQuote)
					.HasForeignKey(d => d.FkDeliveryProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryQuote_DeliveryProvider");

				entity.HasOne(d => d.FkDeliveryQuoteAddress)
					.WithMany(p => p.DeliveryQuote)
					.HasForeignKey(d => d.FkDeliveryQuoteAddressId)
					.HasConstraintName("FK_DeliveryQuote_DeliveryAddress");
			});

			modelBuilder.Entity<DeliveryQuoteDetail>(entity =>
			{
				entity.Property(e => e.Courier)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.EstdeliveryDate).HasColumnName("ESTDeliveryDate");

				entity.Property(e => e.Etadate)
					.HasColumnName("ETADate")
					.HasColumnType("datetime");

				entity.Property(e => e.FkDeliveryQuoteId).HasColumnName("FK_DeliveryQuoteId");

				entity.Property(e => e.LeadTime)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Service)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SeviceCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDeliveryQuote)
					.WithMany(p => p.DeliveryQuoteDetail)
					.HasForeignKey(d => d.FkDeliveryQuoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryQuoteDetail_DeliveryQuote");
			});

			modelBuilder.Entity<DeliveryQuoteDocuments>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkDeliveryQuoteId).HasColumnName("FK_DeliveryQuoteId");

				entity.HasOne(d => d.FkDeliveryQuote)
					.WithMany(p => p.DeliveryQuoteDocuments)
					.HasForeignKey(d => d.FkDeliveryQuoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryQuoteDocuments_DeliveryQuote");
			});

			modelBuilder.Entity<DeliveryQuoteItems>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkDeliveryQuoteId).HasColumnName("FK_DeliveryQuoteId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDeliveryQuote)
					.WithMany(p => p.DeliveryQuoteItems)
					.HasForeignKey(d => d.FkDeliveryQuoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryQuoteItems_DeliveryQuote");
			});

			modelBuilder.Entity<DeliverySuburbLookup>(entity =>
			{
				entity.Property(e => e.City)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Country)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkProviderId).HasColumnName("FK_ProviderId");

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.Province)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Suburb)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.Zone)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.HasOne(d => d.FkProvider)
					.WithMany(p => p.DeliverySuburbLookup)
					.HasForeignKey(d => d.FkProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliverySuburbLookup_DeliveryProvider");
			});

			modelBuilder.Entity<DeliveryWaybill>(entity =>
			{
				entity.Property(e => e.Courier)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DeliveryDate).HasColumnType("date");

				entity.Property(e => e.DispatchedDate).HasColumnType("datetime");

				entity.Property(e => e.Etadate)
					.HasColumnName("ETADate")
					.HasColumnType("datetime");

				entity.Property(e => e.FkAccountContactId).HasColumnName("FK_AccountContactId");

				entity.Property(e => e.FkDeliveryProviderId).HasColumnName("FK_DeliveryProviderId");

				entity.Property(e => e.FkDeliveryWaybillAddressId).HasColumnName("FK_DeliveryWaybillAddressId");

				entity.Property(e => e.FkDocumentId).HasColumnName("FK_DocumentId");

				entity.Property(e => e.FkHistoryId).HasColumnName("FK_HistoryId");

				entity.Property(e => e.FkWaybillCourierDetailsId).HasColumnName("FK_WaybillCourierDetailsId");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.Number)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.OrderNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ProviderEta)
					.HasColumnName("ProviderETA")
					.HasColumnType("datetime");

				entity.Property(e => e.ProviderNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.QuoteLeadTime)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.QuoteNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Service)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkAccountContact)
					.WithMany(p => p.DeliveryWaybill)
					.HasForeignKey(d => d.FkAccountContactId)
					.HasConstraintName("FK_DeliveryWaybill_AccountContacts");

				entity.HasOne(d => d.FkDeliveryProvider)
					.WithMany(p => p.DeliveryWaybill)
					.HasForeignKey(d => d.FkDeliveryProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryWaybill_DeliveryProvider");

				entity.HasOne(d => d.FkDeliveryWaybillAddress)
					.WithMany(p => p.DeliveryWaybill)
					.HasForeignKey(d => d.FkDeliveryWaybillAddressId)
					.HasConstraintName("FK_DeliveryWaybill_DeliveryWaybillAddress");

				entity.HasOne(d => d.FkDocument)
					.WithMany(p => p.DeliveryWaybill)
					.HasForeignKey(d => d.FkDocumentId)
					.HasConstraintName("FK_DeliveryWaybill_Documents");

				entity.HasOne(d => d.FkHistory)
					.WithMany(p => p.InverseFkHistory)
					.HasForeignKey(d => d.FkHistoryId)
					.HasConstraintName("FK_DeliveryWaybill_DeliveryWaybill");

				entity.HasOne(d => d.FkWaybillCourierDetails)
					.WithMany(p => p.DeliveryWaybill)
					.HasForeignKey(d => d.FkWaybillCourierDetailsId)
					.HasConstraintName("FK_DeliveryWaybill_DeliveryWaybillCourierDetails");
			});

			modelBuilder.Entity<DeliveryWaybillCourierDetails>(entity =>
			{
				entity.Property(e => e.ContactNumber)
					.HasMaxLength(30)
					.IsUnicode(false);

				entity.Property(e => e.Courier)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.TrackingNumber)
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<DeliveryWaybillDetail>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkDeliveryWaybillId).HasColumnName("FK_DeliveryWaybillId");

				entity.Property(e => e.FkDocumentId).HasColumnName("FK_DocumentId");

				entity.HasOne(d => d.FkDeliveryWaybill)
					.WithMany(p => p.DeliveryWaybillDetail)
					.HasForeignKey(d => d.FkDeliveryWaybillId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryWaybillDetail_DeliveryWaybill");

				entity.HasOne(d => d.FkDocument)
					.WithMany(p => p.DeliveryWaybillDetail)
					.HasForeignKey(d => d.FkDocumentId)
					.HasConstraintName("FK_DeliveryWaybillDetail_Documents");
			});

			modelBuilder.Entity<DeliveryWaybillTracking>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.FkDeliveryWaybillId).HasColumnName("FK_DeliveryWaybillId");

				entity.HasOne(d => d.FkDeliveryWaybill)
					.WithMany(p => p.DeliveryWaybillTracking)
					.HasForeignKey(d => d.FkDeliveryWaybillId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryWaybillTracking_DeliveryWaybill");
			});

			modelBuilder.Entity<Departments>(entity =>
			{
				entity.HasKey(e => e.DepartmentId);

				entity.Property(e => e.DepartmentId).HasDefaultValueSql("(newid())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<DestroyedPalletInfo>(entity =>
			{
				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.ActionarCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("date")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkPalletId).HasColumnName("Fk_PalletId");

				entity.Property(e => e.ReasonCode)
					.IsRequired()
					.HasMaxLength(10);
			});

			modelBuilder.Entity<DmDevice>(entity =>
			{
				entity.HasKey(e => e.DeviceId);

				entity.ToTable("dmDevice");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Ipaddress)
					.HasColumnName("IPAddress")
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Macaddress)
					.HasColumnName("MACAddress")
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Make).HasMaxLength(50);

				entity.Property(e => e.Model).HasMaxLength(50);

				entity.Property(e => e.OsmajorVersion).HasColumnName("OSMajorVersion");

				entity.Property(e => e.OsminorVersion).HasColumnName("OSMinorVersion");

				entity.Property(e => e.Platform).HasMaxLength(100);

				entity.Property(e => e.PurchasedDate).HasColumnType("datetime");

				entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

				entity.Property(e => e.SerialNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Udid)
					.IsRequired()
					.HasColumnName("UDID")
					.HasMaxLength(50);

				entity.Property(e => e.Wap)
					.HasColumnName("WAP")
					.HasMaxLength(100)
					.IsUnicode(false);
			});

			modelBuilder.Entity<DmDeviceHandler>(entity =>
			{
				entity.ToTable("dmDeviceHandler");

				entity.Property(e => e.Company)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.ContactNumber)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.EmailAddress)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Eta)
					.HasColumnName("ETA")
					.HasColumnType("datetime");

				entity.Property(e => e.FkDeviceId).HasColumnName("FK_DeviceId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255);

				entity.HasOne(d => d.FkDevice)
					.WithMany(p => p.DmDeviceHandler)
					.HasForeignKey(d => d.FkDeviceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_dmDeviceHandler_dmDevice");
			});

			modelBuilder.Entity<DmDeviceLogBook>(entity =>
			{
				entity.ToTable("dmDeviceLogBook");

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkDeviceId).HasColumnName("FK_DeviceId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.In).HasColumnType("datetime");

				entity.Property(e => e.Out).HasColumnType("datetime");

				entity.HasOne(d => d.FkDevice)
					.WithMany(p => p.DmDeviceLogBook)
					.HasForeignKey(d => d.FkDeviceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_dmDeviceLogBook_dmDevice");
			});

			modelBuilder.Entity<DmDeviceRotation>(entity =>
			{
				entity.ToTable("dmDeviceRotation");

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.FkDeviceId).HasColumnName("FK_DeviceId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.In).HasColumnType("datetime");

				entity.Property(e => e.Out).HasColumnType("datetime");

				entity.HasOne(d => d.FkDevice)
					.WithMany(p => p.DmDeviceRotation)
					.HasForeignKey(d => d.FkDeviceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_dmDeviceRotation_dmDevice");
			});

			modelBuilder.Entity<DmDeviceTracking>(entity =>
			{
				entity.ToTable("dmDeviceTracking");

				entity.Property(e => e.Id).ValueGeneratedOnAdd();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Description).HasMaxLength(250);

				entity.Property(e => e.FkDeviceHandlerId).HasColumnName("FK_DeviceHandlerId");

				entity.Property(e => e.FkDeviceId).HasColumnName("FK_DeviceId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkDevice)
					.WithMany(p => p.DmDeviceTracking)
					.HasForeignKey(d => d.FkDeviceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_dmDeviceTracking_dmDevice");

				entity.HasOne(d => d.IdNavigation)
					.WithOne(p => p.InverseIdNavigation)
					.HasForeignKey<DmDeviceTracking>(d => d.Id)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_dmDeviceTracking_dmDeviceTracking");
			});

			modelBuilder.Entity<DocumentAttachments>(entity =>
			{
				entity.HasKey(e => e.AttachmentId);

				entity.Property(e => e.AttachmentId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Filename)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.RelativePath)
					.IsRequired()
					.HasMaxLength(255);
			});

			modelBuilder.Entity<DocumentBoxDetail>(entity =>
			{
				entity.HasKey(e => new { e.FkDocumentBoxId, e.FkDocumentLineId });

				entity.HasIndex(e => e.FkDocumentLineId)
					.HasName("IX_DocumentBoxDetail")
					.IsUnique();

				entity.Property(e => e.FkDocumentBoxId).HasColumnName("FK_DocumentBoxId");

				entity.Property(e => e.FkDocumentLineId).HasColumnName("FK_DocumentLineId");

				entity.HasOne(d => d.FkDocumentBox)
					.WithMany(p => p.DocumentBoxDetail)
					.HasForeignKey(d => d.FkDocumentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentBoxDetail_DocumentBoxes");

				entity.HasOne(d => d.FkDocumentLine)
					.WithOne(p => p.DocumentBoxDetail)
					.HasForeignKey<DocumentBoxDetail>(d => d.FkDocumentLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentBoxDetail_Lines");
			});

			modelBuilder.Entity<DocumentBoxes>(entity =>
			{
				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkDocumentId).HasColumnName("FK_DocumentId");

				entity.Property(e => e.LocationName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDocument)
					.WithMany(p => p.DocumentBoxes)
					.HasForeignKey(d => d.FkDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentBoxes_Documents");
			});

			modelBuilder.Entity<DocumentHistory>(entity =>
			{
				entity.HasKey(e => e.HistoryId);

				entity.ToTable("Document_History");

				entity.HasIndex(e => e.DocumentNumber);

				entity.HasIndex(e => new { e.FkHistoryContributorId, e.DocumentNumber, e.DocumentVersion, e.Type })
					.HasName("<IX_HistorySearch>");

				entity.Property(e => e.AdditionalInfo).HasMaxLength(1024);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.FkDocumentId).HasColumnName("FK_Document_Id");

				entity.Property(e => e.FkHistoryContributorId).HasColumnName("FK_History_Contributor_Id");

				entity.HasOne(d => d.FkHistoryContributor)
					.WithMany(p => p.DocumentHistory)
					.HasForeignKey(d => d.FkHistoryContributorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_History_ContributorDocument_History");
			});

			modelBuilder.Entity<DocumentNotificationInfos>(entity =>
			{
				entity.HasKey(e => e.DocumentNotificationId);

				entity.Property(e => e.DocumentNotificationId).ValueGeneratedNever();

				entity.Property(e => e.DateSent).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Recipients).IsRequired();

				entity.Property(e => e.Sender)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<DocumentNumbers>(entity =>
			{
				entity.HasKey(e => e.DocumentNumberId);

				entity.HasIndex(e => new { e.DocumentNumberId, e.DocumentNumber, e.Value, e.Used, e.DateIssued, e.DocumentType })
					.HasName("IX_DocumentNumber_Type");

				entity.Property(e => e.DocumentNumberId).ValueGeneratedNever();

				entity.Property(e => e.DateIssued).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<DocumentPallet>(entity =>
			{
				entity.HasKey(e => new { e.DocumentsDocumentId, e.PalletsPalletId })
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.DocumentsDocumentId).HasColumnName("Documents_DocumentId");

				entity.Property(e => e.PalletsPalletId).HasColumnName("Pallets_PalletId");

				entity.HasOne(d => d.DocumentsDocument)
					.WithMany(p => p.DocumentPallet)
					.HasForeignKey(d => d.DocumentsDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentPallet_Document");

				entity.HasOne(d => d.PalletsPallet)
					.WithMany(p => p.DocumentPallet)
					.HasForeignKey(d => d.PalletsPalletId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentPallet_Pallet");
			});

			modelBuilder.Entity<DocumentPostProcessing>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<DocumentPostProcessingInfoes>(entity =>
			{
				entity.Property(e => e.FkProcessingId).HasColumnName("FK_ProcessingId");

				entity.Property(e => e.ProcessingKey)
					.IsRequired()
					.IsUnicode(false);

				entity.Property(e => e.ProcessingValue)
					.IsRequired()
					.IsUnicode(false);

				entity.HasOne(d => d.FkProcessing)
					.WithMany(p => p.DocumentPostProcessingInfoes)
					.HasForeignKey(d => d.FkProcessingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentPostProcessingInfoes_DocumentPostProcessing");
			});

			modelBuilder.Entity<DocumentReservedStocks>(entity =>
			{
				entity.HasKey(e => e.ReserveId);

				entity.Property(e => e.ReserveId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400);

				entity.Property(e => e.ReservedBnd).HasColumnName("ReservedBND");

				entity.Property(e => e.ReservedGlx).HasColumnName("ReservedGLX");

				entity.Property(e => e.ReservedInc).HasColumnName("ReservedINC");

				entity.Property(e => e.ReservedOvf).HasColumnName("ReservedOVF");

				entity.Property(e => e.ReservedWbn).HasColumnName("ReservedWBN");

				entity.Property(e => e.ReservedWmd).HasColumnName("ReservedWMD");
			});

			modelBuilder.Entity<Documents>(entity =>
			{
				entity.HasKey(e => e.DocumentId);

				entity.HasIndex(e => new { e.DocumentNumber, e.DocumentVersion })
					.HasName("ix_Documents_DocumentNumber_DocumentVersion")
					.IsUnique();

				entity.HasIndex(e => new { e.DocumentNumber, e.DocumentVersion, e.CustomerCode })
					.HasName("ix_Documents_CustomerCode_includes");

				entity.HasIndex(e => new { e.DocumentNumber, e.DocumentVersion, e.CustomerCode, e.DocumentDate })
					.HasName("ix_Documents_DocumentDate_includes");

				entity.HasIndex(e => new { e.DocumentNumber, e.DocumentVersion, e.DocumentType, e.CustomerReference })
					.HasName("ix_Documents_DocumentType_CustomerReference_includes");

				entity.HasIndex(e => new { e.DocumentId, e.DocumentNumber, e.DocumentDate, e.DocumentVersion, e.TotalExcl, e.TotalIncl, e.Tax, e.Status, e.Warehouse, e.CustomerReference, e.CustomerCode, e.SalesmanCode, e.Created, e.Flags, e.DocumentType })
					.HasName("ix_Documents_DocumentType_includes");

				entity.Property(e => e.DocumentId).ValueGeneratedNever();

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.CustomerReference)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.DocumentDate).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.FkBrandId).HasColumnName("FK_BrandId");

				entity.Property(e => e.SalesmanCode).HasMaxLength(20);

				entity.Property(e => e.Warehouse)
					.IsRequired()
					.HasMaxLength(3);
			});

			modelBuilder.Entity<DocumentsSkippedProcessing>(entity =>
			{
				entity.ToTable("_documentsSkippedProcessing");

				entity.HasIndex(e => new { e.Id, e.DocumentNumber, e.Processed })
					.HasName("IX_Processed_DocNumber");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DateDashboardProcessed).HasColumnType("datetime");

				entity.Property(e => e.DateProcessed).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.StartProcessDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<DocumentSyncStates>(entity =>
			{
				entity.HasKey(e => e.DocumentNumber);

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(50)
					.ValueGeneratedNever();

				entity.Property(e => e.DocumentDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<DocumentVersionInfoes>(entity =>
			{
				entity.HasKey(e => e.DocumentVersionId);

				entity.HasIndex(e => e.DocumentNumber)
					.HasName("ix_DocumentVersionInfoes_DocumentNumber");

				entity.HasIndex(e => e.ParentDocumentNumber)
					.HasName("ix_DocumentVersionInfoes_ParentDocumentNumber");

				entity.HasIndex(e => new { e.CurrentVersion, e.DocumentVersionId, e.DocumentNumber, e.PickingSlipNumber, e.DocumentBarcode, e.DocumentFlags, e.ParentDocumentNumber, e.InvoiceNumber })
					.HasName("ix_DocumentVersionInfoes_InvoiceNumber_includes");

				entity.HasIndex(e => new { e.DocumentVersionId, e.PickingSlipNumber, e.DocumentBarcode, e.DocumentFlags, e.ParentDocumentNumber, e.InvoiceNumber, e.CurrentVersion, e.DocumentNumber })
					.HasName("IX_VersionLookup");

				entity.Property(e => e.DocumentVersionId).ValueGeneratedNever();

				entity.Property(e => e.DocumentBarcode)
					.IsRequired()
					.HasMaxLength(13);

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

				entity.Property(e => e.ParentDocumentNumber).HasMaxLength(50);

				entity.Property(e => e.PickingSlipNumber).HasMaxLength(55);
			});

			modelBuilder.Entity<DocumentVolumetric>(entity =>
			{
				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EntityAttachmentLinks>(entity =>
			{
				entity.HasKey(e => e.LinkId);

				entity.HasIndex(e => e.EntityKey);

				entity.HasIndex(e => e.FkAttachmentId)
					.HasName("IX_FK_EntityAttachmentsEntityAttachmentLink");

				entity.Property(e => e.EntityKey)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.FkAttachmentId).HasColumnName("FK_AttachmentId");

				entity.HasOne(d => d.FkAttachment)
					.WithMany(p => p.EntityAttachmentLinks)
					.HasForeignKey(d => d.FkAttachmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EntityAttachmentsEntityAttachmentLink");
			});

			modelBuilder.Entity<EntityAttachments>(entity =>
			{
				entity.HasKey(e => e.AttachmentId);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Extension)
					.IsRequired()
					.HasMaxLength(10);

				entity.Property(e => e.Mimetype).HasMaxLength(100);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.RelativePath)
					.IsRequired()
					.HasMaxLength(255);
			});

			modelBuilder.Entity<EntityNotificationRecipients>(entity =>
			{
				entity.HasKey(e => new { e.RecipientEmail, e.FkNotificationId });

				entity.Property(e => e.RecipientEmail).HasMaxLength(255);

				entity.Property(e => e.FkNotificationId).HasColumnName("FK_NotificationId");

				entity.HasOne(d => d.FkNotification)
					.WithMany(p => p.EntityNotificationRecipients)
					.HasForeignKey(d => d.FkNotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EntityNotificationsEntityNotificationRecipient");
			});

			modelBuilder.Entity<EntityNotificationReferrals>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.EntityKey).HasMaxLength(50);

				entity.Property(e => e.ReferralEmail)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<EntityNotifications>(entity =>
			{
				entity.HasKey(e => e.NotificationId);

				entity.HasIndex(e => new { e.EntityKey, e.Type, e.Version })
					.HasName("IX_EntityNotifications_Key");

				entity.HasIndex(e => new { e.NotificationId, e.EntityKey, e.DateSent, e.Type })
					.HasName("ix_EntityNotifications_Type_includes");

				entity.Property(e => e.NotificationId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DateSent).HasColumnType("datetime");

				entity.Property(e => e.EntityKey)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EntityProcesses>(entity =>
			{
				entity.HasKey(e => e.ProcessId);

				entity.HasIndex(e => new { e.EntityKey, e.Version, e.Type });

				entity.Property(e => e.ProcessId).ValueGeneratedNever();

				entity.Property(e => e.DateProcessed).HasColumnType("datetime");

				entity.Property(e => e.EntityKey)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Status).HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<GenericTrackings>(entity =>
			{
				entity.HasKey(e => e.EntityId);

				entity.Property(e => e.EntityId).ValueGeneratedNever();

				entity.Property(e => e.TrackingDate).HasColumnType("datetime");
			});

			modelBuilder.Entity<HistoryContributor>(entity =>
			{
				entity.ToTable("History_Contributor");

				entity.HasIndex(e => e.Identifier)
					.HasName("UK_HistoryIdentifier")
					.IsUnique();

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Identifier)
					.IsRequired()
					.HasMaxLength(255);
			});

			modelBuilder.Entity<ImportStates>(entity =>
			{
				entity.HasKey(e => e.ImportId);

				entity.Property(e => e.ImportDate).HasColumnType("datetime");

				entity.Property(e => e.ImportKey)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ImportSource)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<InvoiceInfoes>(entity =>
			{
				entity.HasKey(e => e.DocumentNumber);

				entity.HasIndex(e => new { e.DocumentNumber, e.BranchCode })
					.HasName("ix_InvoiceInfoes_BranchCode_includes");

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(50)
					.ValueGeneratedNever();

				entity.Property(e => e.AuthorizerUsername)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BranchCode)
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.NotificationRecipientEmail).HasMaxLength(255);

				entity.Property(e => e.UserUsername)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<InvoicingSpecials>(entity =>
			{
				entity.HasKey(e => e.SpecialId);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400);

				entity.Property(e => e.SpecialDiscountProject).HasMaxLength(10);

				entity.Property(e => e.SpecialWarehouse).HasMaxLength(3);

				entity.Property(e => e.ValidFrom).HasColumnType("datetime");

				entity.Property(e => e.ValidTo).HasColumnType("datetime");
			});

			modelBuilder.Entity<ItemPalletInfo>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("_ItemPalletInfo");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(400)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<LineDatas>(entity =>
			{
				entity.HasKey(e => e.LineDataId);

				entity.HasIndex(e => e.FkLineId)
					.HasName("UK_LineData")
					.IsUnique();

				entity.Property(e => e.FkLineId).HasColumnName("FK_LineId");

				entity.HasOne(d => d.FkLine)
					.WithOne(p => p.LineDatas)
					.HasForeignKey<LineDatas>(d => d.FkLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineLineData");
			});

			modelBuilder.Entity<LineDisplay>(entity =>
			{
				entity.HasKey(e => e.DisplayLineId);

				entity.HasIndex(e => e.DocumentId)
					.HasName("ix_LineDisplay_DocumentId");

				entity.Property(e => e.Comments).IsUnicode(false);

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCodeOriginal).HasMaxLength(50);

				entity.HasOne(d => d.Document)
					.WithMany(p => p.LineDisplay)
					.HasForeignKey(d => d.DocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineDisplay_DocumentDetail");
			});

			modelBuilder.Entity<LineDisplayComponents>(entity =>
			{
				entity.HasIndex(e => new { e.FkDisplayLineId, e.Prefix })
					.HasName("IX_LineDisplayComponents")
					.IsUnique();

				entity.Property(e => e.BaseCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkDisplayLineId).HasColumnName("FK_DisplayLineId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Prefix)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDisplayLine)
					.WithMany(p => p.LineDisplayComponents)
					.HasForeignKey(d => d.FkDisplayLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineDisplayComponents_LineDisplay1");
			});

			modelBuilder.Entity<LineDisplayPartDetails>(entity =>
			{
				entity.HasKey(e => new { e.FkDisplayLineId, e.PartCode });

				entity.Property(e => e.FkDisplayLineId).HasColumnName("FK_DisplayLineId");

				entity.Property(e => e.PartCode)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PartColour)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PartDescription)
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.HasOne(d => d.FkDisplayLine)
					.WithMany(p => p.LineDisplayPartDetails)
					.HasForeignKey(d => d.FkDisplayLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineDisplayPartDetails_LineDisplay");
			});

			modelBuilder.Entity<LineLinks>(entity =>
			{
				entity.HasKey(e => new { e.FkLineId, e.FkDisplayLineId });

				entity.Property(e => e.FkLineId).HasColumnName("FK_LineId");

				entity.Property(e => e.FkDisplayLineId).HasColumnName("FK_DisplayLineId");

				entity.HasOne(d => d.FkDisplayLine)
					.WithMany(p => p.LineLinks)
					.HasForeignKey(d => d.FkDisplayLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineLinks_LineDisplay");

				entity.HasOne(d => d.FkLine)
					.WithMany(p => p.LineLinks)
					.HasForeignKey(d => d.FkLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_LineLinks_Lines");
			});

			modelBuilder.Entity<Lines>(entity =>
			{
				entity.HasKey(e => e.LineId);

				entity.HasIndex(e => e.DocumentId)
					.HasName("ix_Lines_DocumentId");

				entity.Property(e => e.LineId).ValueGeneratedNever();

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.DiscountProject)
					.HasMaxLength(5)
					.IsUnicode(false);

				entity.Property(e => e.FkBrandId).HasColumnName("FK_BrandId");

				entity.Property(e => e.FkParentLineId).HasColumnName("FK_ParentLineId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCodeOriginal).HasMaxLength(50);

				entity.Property(e => e.Shelf)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.Document)
					.WithMany(p => p.Lines)
					.HasForeignKey(d => d.DocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentDetail");
			});

			modelBuilder.Entity<LookupBrandingConversionIgnoredStocks>(entity =>
			{
				entity.HasIndex(e => e.ItemCode)
					.HasName("UK_LookupBrandingConversionItemCode")
					.IsUnique();

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<LookupClothingMensClothings>(entity =>
			{
				entity.HasIndex(e => e.MensCode)
					.HasName("UK_LookupClothingMens")
					.IsUnique();

				entity.HasIndex(e => e.WomensCode)
					.HasName("UK_LookupClothingWomens")
					.IsUnique();

				entity.Property(e => e.MensCode)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.WomensCode)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<LookupOrderTypePriorities>(entity =>
			{
				entity.HasKey(e => e.OrderType);

				entity.Property(e => e.OrderType).ValueGeneratedNever();
			});

			modelBuilder.Entity<MDocuments>(entity =>
			{
				entity.ToTable("M_Documents");

				entity.HasIndex(e => e.FkMessage)
					.HasName("IX_M_Documents")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkMessage).HasColumnName("FK_Message");

				entity.Property(e => e.Path)
					.IsRequired()
					.HasMaxLength(1000)
					.IsUnicode(false);

				entity.HasOne(d => d.FkMessageNavigation)
					.WithOne(p => p.MDocuments)
					.HasForeignKey<MDocuments>(d => d.FkMessage)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_M_Documents_M_Message1");
			});

			modelBuilder.Entity<MessageQueueItems>(entity =>
			{
				entity.HasKey(e => e.MessageQueueItemId);

				entity.HasIndex(e => new { e.MessageQueueItemId, e.RetryCount, e.Success, e.FkEntityNotificationId, e.Created, e.Status })
					.HasName("IX_MessageQueueItems_Created_Status");

				entity.Property(e => e.MessageQueueItemId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkEntityNotificationId).HasColumnName("FK_EntityNotificationId");

				entity.Property(e => e.Success).HasColumnType("datetime");
			});

			modelBuilder.Entity<MessageQueueLogs>(entity =>
			{
				entity.HasKey(e => e.MessageQueueLogId);

				entity.Property(e => e.MessageQueueLogId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkMessageQueueItemId).HasColumnName("FK_MessageQueueItemId");

				entity.Property(e => e.LogInfo).IsRequired();
			});

			modelBuilder.Entity<MMessage>(entity =>
			{
				entity.ToTable("M_Message");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.MessageHeading)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.MessageText)
					.HasMaxLength(500)
					.IsUnicode(false);
			});

			modelBuilder.Entity<MRecipientResponses>(entity =>
			{
				entity.ToTable("M_RecipientResponses");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkStore).HasColumnName("FK_Store");

				entity.HasOne(d => d.FkStoreNavigation)
					.WithMany(p => p.MRecipientResponses)
					.HasForeignKey(d => d.FkStore)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_M_RecipientResponses_M_Store1");
			});

			modelBuilder.Entity<MRecipients>(entity =>
			{
				entity.ToTable("M_Recipients");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkMessage).HasColumnName("FK_Message");

				entity.HasOne(d => d.FkMessageNavigation)
					.WithMany(p => p.MRecipients)
					.HasForeignKey(d => d.FkMessage)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_M_Recipients_M_Message");
			});

			modelBuilder.Entity<MSchedules>(entity =>
			{
				entity.ToTable("M_Schedules");

				entity.HasIndex(e => e.FkMessage)
					.HasName("IX_M_Schedules")
					.IsUnique();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Date).HasColumnType("date");

				entity.Property(e => e.DayOfWeek)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkMessage).HasColumnName("FK_Message");

				entity.Property(e => e.MonthDay)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ValidFrom).HasColumnType("datetime");

				entity.Property(e => e.ValidTo).HasColumnType("datetime");

				entity.HasOne(d => d.FkMessageNavigation)
					.WithOne(p => p.MSchedules)
					.HasForeignKey<MSchedules>(d => d.FkMessage)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_M_Schedules_M_Message1");
			});

			modelBuilder.Entity<MStore>(entity =>
			{
				entity.ToTable("M_Store");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.FkMessage).HasColumnName("FK_Message");

				entity.HasOne(d => d.FkMessageNavigation)
					.WithMany(p => p.MStore)
					.HasForeignKey(d => d.FkMessage)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_M_Store_M_Message");
			});

			modelBuilder.Entity<MTracking>(entity =>
			{
				entity.ToTable("M_Tracking");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.FkDocument).HasColumnName("FK_Document");

				entity.Property(e => e.FkMessage).HasColumnName("FK_Message");

				entity.Property(e => e.FkSchedule).HasColumnName("FK_Schedule");

				entity.Property(e => e.FkStore).HasColumnName("FK_Store");
			});

			modelBuilder.Entity<OneTimeTokens>(entity =>
			{
				entity.HasKey(e => e.TokenId);

				entity.Property(e => e.TokenId).ValueGeneratedNever();

				entity.Property(e => e.DateConsumed).HasColumnType("datetime");

				entity.Property(e => e.DateIssued).HasColumnType("datetime");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.ValidFrom).HasColumnType("datetime");

				entity.Property(e => e.ValidTo).HasColumnType("datetime");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.OneTimeTokens)
					.HasForeignKey(d => d.FkUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserOneTimeToken");
			});

			modelBuilder.Entity<PalletConfirmLocationBatches>(entity =>
			{
				entity.HasKey(e => e.BatchId);

				entity.Property(e => e.BatchId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkWarehouseId).HasColumnName("FK_WarehouseId");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(8);

				entity.HasOne(d => d.FkWarehouse)
					.WithMany(p => p.PalletConfirmLocationBatches)
					.HasForeignKey(d => d.FkWarehouseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehousePalletConfirmLocationBatch");
			});

			modelBuilder.Entity<PalletConfirmLocationExceptions>(entity =>
			{
				entity.HasKey(e => e.ExceptionId);

				entity.Property(e => e.ExceptionId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkPalletId).HasColumnName("FK_PalletId");

				entity.HasOne(d => d.FkPallet)
					.WithMany(p => p.PalletConfirmLocationExceptions)
					.HasForeignKey(d => d.FkPalletId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PalletPalletConfirmLocationException");
			});

			modelBuilder.Entity<PalletConfirmLocationMovements>(entity =>
			{
				entity.HasKey(e => e.MovementId);

				entity.Property(e => e.MovementId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkPalletId).HasColumnName("FK_PalletId");

				entity.HasOne(d => d.FkPallet)
					.WithMany(p => p.PalletConfirmLocationMovements)
					.HasForeignKey(d => d.FkPalletId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PalletPalletConfirmLocationMovement");
			});

			modelBuilder.Entity<PalletConfirmLocationRaw>(entity =>
			{
				entity.HasKey(e => e.RawId);

				entity.ToTable("PalletConfirmLocation_Raw");

				entity.Property(e => e.RawId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.EnitityBarcode)
					.IsRequired()
					.HasMaxLength(13);

				entity.Property(e => e.FkBatchId).HasColumnName("FK_BatchId");

				entity.Property(e => e.FkScannedById).HasColumnName("FK_ScannedById");

				entity.Property(e => e.LocationBarcode)
					.IsRequired()
					.HasMaxLength(13);

				entity.HasOne(d => d.FkBatch)
					.WithMany(p => p.PalletConfirmLocationRaw)
					.HasForeignKey(d => d.FkBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PalletConfirmLocationBatchPalletConfirmLocation_Raw");

				entity.HasOne(d => d.FkScannedBy)
					.WithMany(p => p.PalletConfirmLocationRaw)
					.HasForeignKey(d => d.FkScannedById)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_History_ContributorPalletConfirmLocation_Raw");
			});

			modelBuilder.Entity<PalletContents>(entity =>
			{
				entity.HasKey(e => e.ContentId);

				entity.Property(e => e.ContentId).ValueGeneratedNever();

				entity.Property(e => e.BatchNumber).HasMaxLength(50);

				entity.Property(e => e.ColourCode).HasMaxLength(6);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.SizeCode).HasMaxLength(6);

				entity.HasOne(d => d.Pallet)
					.WithMany(p => p.PalletContents)
					.HasForeignKey(d => d.PalletId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PalletPalletContent");
			});

			modelBuilder.Entity<PalletMovementErrors>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.ErrorMessage).IsRequired();

				entity.Property(e => e.FkUserTracking)
					.IsRequired()
					.HasColumnName("FK_UserTracking")
					.HasMaxLength(50);

				entity.Property(e => e.FkWarehouseCode)
					.IsRequired()
					.HasColumnName("FK_Warehouse_Code")
					.HasMaxLength(3);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(15);

				entity.Property(e => e.PalletCode)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Pallets>(entity =>
			{
				entity.HasKey(e => e.PalletId);

				entity.HasIndex(e => e.Code)
					.HasName("UK_PalletCode")
					.IsUnique();

				entity.HasIndex(e => new { e.PalletId, e.WarehouseLocatonWarehouseLocationId, e.FkWarehouseId, e.CurrentStatus })
					.HasName("IX_Pallets_CurrentStatus");

				entity.Property(e => e.PalletId).ValueGeneratedNever();

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(13);

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.FkWarehouseId).HasColumnName("FK_Warehouse_Id");

				entity.Property(e => e.WarehouseLocatonWarehouseLocationId).HasColumnName("WarehouseLocaton_WarehouseLocationId");

				entity.HasOne(d => d.FkWarehouse)
					.WithMany(p => p.Pallets)
					.HasForeignKey(d => d.FkWarehouseId)
					.HasConstraintName("FK_WarehousePallet");

				entity.HasOne(d => d.WarehouseLocatonWarehouseLocation)
					.WithMany(p => p.Pallets)
					.HasForeignKey(d => d.WarehouseLocatonWarehouseLocationId)
					.HasConstraintName("FK_PalletWarehouseLocaton");
			});

			modelBuilder.Entity<PalletTransferBatchContents>(entity =>
			{
				entity.HasKey(e => e.ContentId);

				entity.Property(e => e.ContentId).ValueGeneratedNever();

				entity.Property(e => e.FkFromWarehouseId).HasColumnName("FK_FromWarehouseId");

				entity.Property(e => e.FkPalletTransferBatchId).HasColumnName("FK_PalletTransferBatchId");

				entity.Property(e => e.FkToWarehouseId).HasColumnName("FK_ToWarehouseId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(15);

				entity.HasOne(d => d.FkPalletTransferBatch)
					.WithMany(p => p.PalletTransferBatchContents)
					.HasForeignKey(d => d.FkPalletTransferBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PalletTransferBatchPalletTransferBatchContent");
			});

			modelBuilder.Entity<PalletTransferBatches>(entity =>
			{
				entity.HasKey(e => e.BatchId);

				entity.Property(e => e.BatchId).ValueGeneratedNever();

				entity.Property(e => e.BatchNumber)
					.IsRequired()
					.HasMaxLength(10);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DateTransferred).HasColumnType("datetime");

				entity.Property(e => e.Processed).HasColumnType("datetime");
			});

			modelBuilder.Entity<PaymentInfoData>(entity =>
			{
				entity.Property(e => e.FkPaymentId).HasColumnName("FK_PaymentId");

				entity.Property(e => e.InfoKey)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.InfoValue)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkPayment)
					.WithMany(p => p.PaymentInfoData)
					.HasForeignKey(d => d.FkPaymentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PaymentInfoData_PaymentInfoes");
			});

			modelBuilder.Entity<PaymentInfoes>(entity =>
			{
				entity.Property(e => e.AdditionalReference)
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Date).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PaymentReference)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.PaymentStatus)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PaymentType)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Provider)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Source)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<PaymentInfoProcessResults>(entity =>
			{
				entity.HasIndex(e => new { e.Id, e.Created, e.ProcessResult, e.ResultMessage, e.FkPaymentId, e.ProcessType })
					.HasName("ix_PaymentInfoProcessResults_FK_PaymentId_ProcessType_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkPaymentId).HasColumnName("FK_PaymentId");

				entity.Property(e => e.ResultMessage).HasColumnType("varchar(max)");

				entity.HasOne(d => d.FkPayment)
					.WithMany(p => p.PaymentInfoProcessResults)
					.HasForeignKey(d => d.FkPaymentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PaymentInfoProcessResults_PaymentInfoes");
			});

			modelBuilder.Entity<PickingInstructions>(entity =>
			{
				entity.HasKey(e => e.InstructionId);

				entity.Property(e => e.InstructionId).ValueGeneratedNever();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(8);

				entity.Property(e => e.Entity).HasMaxLength(50);

				entity.Property(e => e.FkPickingSlipId).HasColumnName("FK_PickingSlipId");

				entity.Property(e => e.Location).HasMaxLength(50);

				entity.Property(e => e.Text).HasMaxLength(1024);

				entity.HasOne(d => d.FkPickingSlip)
					.WithMany(p => p.PickingInstructions)
					.HasForeignKey(d => d.FkPickingSlipId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PickingSlipPickingInstruction");
			});

			modelBuilder.Entity<PickingSlipMovements>(entity =>
			{
				entity.HasKey(e => e.MovementId);

				entity.Property(e => e.MovementId).ValueGeneratedNever();

				entity.Property(e => e.FkActionerId).HasColumnName("FK_Actioner_Id");

				entity.Property(e => e.FkPickingSlipId).HasColumnName("FK_PickingSlip_Id");

				entity.Property(e => e.FkReceiverId).HasColumnName("FK_Receiver_Id");

				entity.Property(e => e.MovementDate).HasColumnType("datetime");

				entity.Property(e => e.MovementKey).HasMaxLength(50);

				entity.HasOne(d => d.FkActioner)
					.WithMany(p => p.PickingSlipMovementsFkActioner)
					.HasForeignKey(d => d.FkActionerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PickingSlipMovementActioner");

				entity.HasOne(d => d.FkPickingSlip)
					.WithMany(p => p.PickingSlipMovements)
					.HasForeignKey(d => d.FkPickingSlipId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PickingSlipPickingSlipMovement");

				entity.HasOne(d => d.FkReceiver)
					.WithMany(p => p.PickingSlipMovementsFkReceiver)
					.HasForeignKey(d => d.FkReceiverId)
					.HasConstraintName("FK_PickingSlipMovementReceivers");
			});

			modelBuilder.Entity<PickingSlipPrintStatus>(entity =>
			{
				entity.HasKey(e => e.PickingSlipNumber);

				entity.Property(e => e.PickingSlipNumber)
					.HasMaxLength(55)
					.ValueGeneratedNever();

				entity.Property(e => e.AdminTimeDelay).HasColumnType("datetime");

				entity.Property(e => e.DateCancelled).HasColumnType("datetime");

				entity.Property(e => e.DateDelayLifted).HasColumnType("datetime");

				entity.Property(e => e.DatePrintDelayed).HasColumnType("datetime");

				entity.Property(e => e.DatePrintQueued).HasColumnType("datetime");

				entity.Property(e => e.DatePrinted).HasColumnType("datetime");

				entity.Property(e => e.PrintDelayReasonCode).HasMaxLength(3);

				entity.HasOne(d => d.PrintDelayReasonCodeNavigation)
					.WithMany(p => p.PickingSlipPrintStatus)
					.HasForeignKey(d => d.PrintDelayReasonCode)
					.HasConstraintName("FK_PickingSlipPrintStatusPrintDelayedReason");
			});

			modelBuilder.Entity<PickingSlipReservedStocks>(entity =>
			{
				entity.HasKey(e => e.ReserveId);

				entity.Property(e => e.ReserveId).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkPickingSlipId).HasColumnName("FK_PickingSlip_Id");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ReservedBnd).HasColumnName("ReservedBND");

				entity.Property(e => e.ReservedGlx).HasColumnName("ReservedGLX");

				entity.Property(e => e.ReservedInc).HasColumnName("ReservedINC");

				entity.Property(e => e.ReservedOvf).HasColumnName("ReservedOVF");

				entity.Property(e => e.ReservedWbn).HasColumnName("ReservedWBN");

				entity.Property(e => e.ReservedWmd).HasColumnName("ReservedWMD");

				entity.HasOne(d => d.FkPickingSlip)
					.WithMany(p => p.PickingSlipReservedStocks)
					.HasForeignKey(d => d.FkPickingSlipId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PickingSlipPickingSlipReservedStock");
			});

			modelBuilder.Entity<PickingSlips>(entity =>
			{
				entity.HasKey(e => e.PickingSlipId);

				entity.HasIndex(e => e.Barcode);

				entity.HasIndex(e => e.DocumentDocumentId)
					.HasName("IX_FK_DocumentPickingSlip");

				entity.HasIndex(e => e.PickingSlipNumber);

				entity.Property(e => e.PickingSlipId).ValueGeneratedNever();

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(13);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DocumentDocumentId).HasColumnName("Document_DocumentId");

				entity.Property(e => e.PickingSlipNumber)
					.IsRequired()
					.HasMaxLength(55);

				entity.HasOne(d => d.DocumentDocument)
					.WithMany(p => p.PickingSlips)
					.HasForeignKey(d => d.DocumentDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentPickingSlip");
			});

			modelBuilder.Entity<PodCollectionInstructionContainer>(entity =>
			{
				entity.ToTable("podCollectionInstructionContainer");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.CustomerName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkInstructionId).HasColumnName("FK_InstructionId");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkInstruction)
					.WithMany(p => p.PodCollectionInstructionContainer)
					.HasForeignKey(d => d.FkInstructionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podCollectionInstructionContainer_podCollectionIntruction");
			});

			modelBuilder.Entity<PodCollectionInstructionLocation>(entity =>
			{
				entity.ToTable("podCollectionInstructionLocation");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkInstructionId).HasColumnName("FK_InstructionId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkInstruction)
					.WithMany(p => p.PodCollectionInstructionLocation)
					.HasForeignKey(d => d.FkInstructionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podCollectionInstructionLocation_podCollectionIntruction");
			});

			modelBuilder.Entity<PodCollectionIntruction>(entity =>
			{
				entity.ToTable("podCollectionIntruction");

				entity.HasIndex(e => new { e.FkPodCollectionNoteId, e.Type, e.Sequence, e.Status })
					.HasName("ix_podCollectionIntruction_FK_podCollectionNoteId_Type_Sequence_Status");

				entity.HasIndex(e => new { e.Id, e.Created, e.FkParentIntructionId, e.Type, e.Sequence, e.OpenTimestamp, e.FkUserId, e.CloseTimestamp, e.Status, e.Flags, e.FkPodCollectionNoteId })
					.HasName("ix_podCollectionIntruction_FK_podCollectionNoteId_includes");

				entity.Property(e => e.CloseTimestamp).HasColumnType("datetime");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkParentIntructionId).HasColumnName("FK_ParentIntructionId");

				entity.Property(e => e.FkPodCollectionNoteId).HasColumnName("FK_podCollectionNoteId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.OpenTimestamp).HasColumnType("datetime");

				entity.HasOne(d => d.FkParentIntruction)
					.WithMany(p => p.InverseFkParentIntruction)
					.HasForeignKey(d => d.FkParentIntructionId)
					.HasConstraintName("FK_podCollectionIntruction_podCollectionIntruction");

				entity.HasOne(d => d.FkPodCollectionNote)
					.WithMany(p => p.PodCollectionIntruction)
					.HasForeignKey(d => d.FkPodCollectionNoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podCollectionIntruction_podCollectionNote");
			});

			modelBuilder.Entity<PodCollectionNote>(entity =>
			{
				entity.ToTable("podCollectionNote");

				entity.HasIndex(e => e.Number)
					.HasName("ix_podCollectionNote_Number");

				entity.Property(e => e.CollectionBranchCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.ConfirmationSlipNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Courier)
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.DispatchStart).HasColumnType("datetime");

				entity.Property(e => e.FkCollectionClerk).HasColumnName("FK_CollectionClerk");

				entity.Property(e => e.FkDispatcher).HasColumnName("FK_Dispatcher");

				entity.Property(e => e.FkStagingLocationId).HasColumnName("FK_StagingLocationId");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkCollectionClerkNavigation)
					.WithMany(p => p.PodCollectionNote)
					.HasForeignKey(d => d.FkCollectionClerk)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podCollectionNote_Users");
			});

			modelBuilder.Entity<PodCollectionNoteBoxInfo>(entity =>
			{
				entity.ToTable("podCollectionNoteBoxInfo");

				entity.HasIndex(e => e.FkPodCollectionNoteId)
					.HasName("ix_podCollectionNoteBoxInfo_FK_podCollectionNoteId");

				entity.Property(e => e.CollectionShelf)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkPodCollectionNoteId).HasColumnName("FK_podCollectionNoteId");

				entity.Property(e => e.FkWmsDocumentBoxId).HasColumnName("FK_wmsDocumentBoxId");

				entity.HasOne(d => d.FkPodCollectionNote)
					.WithMany(p => p.PodCollectionNoteBoxInfo)
					.HasForeignKey(d => d.FkPodCollectionNoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podCollectionNoteBoxInfo_podCollectionNote");

				entity.HasOne(d => d.FkWmsDocumentBox)
					.WithMany(p => p.PodCollectionNoteBoxInfo)
					.HasForeignKey(d => d.FkWmsDocumentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podCollectionNoteBoxInfo_wmsDocumentBoxes");
			});

			modelBuilder.Entity<PodCollectionNoteDocument>(entity =>
			{
				entity.ToTable("podCollectionNoteDocument");

				entity.HasIndex(e => new { e.DocumentNumber, e.Flags, e.FkPodCollectionNoteId })
					.HasName("ix_podCollectionNoteDocument_FK_podCollectionNoteId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkPodCollectionNoteId).HasColumnName("FK_podCollectionNoteId");

				entity.Property(e => e.Waybill)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkPodCollectionNote)
					.WithMany(p => p.PodCollectionNoteDocument)
					.HasForeignKey(d => d.FkPodCollectionNoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podCollectionNoteDocument_podCollectionNote");
			});

			modelBuilder.Entity<PodCollectionNoteWaybill>(entity =>
			{
				entity.ToTable("podCollectionNoteWaybill");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkPodCollectionNoteId).HasColumnName("FK_podCollectionNoteId");

				entity.Property(e => e.WaybillProviderNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkPodCollectionNote)
					.WithMany(p => p.PodCollectionNoteWaybill)
					.HasForeignKey(d => d.FkPodCollectionNoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PodCollectionNoteWaybill_podCollectionNote");
			});

			modelBuilder.Entity<PodDispatchBuzzer>(entity =>
			{
				entity.ToTable("podDispatchBuzzer");

				entity.HasIndex(e => new { e.BuzzerNumber, e.Warehouse })
					.HasName("IX_DispatchBuzzer")
					.IsUnique();

				entity.Property(e => e.BuzzerNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Warehouse)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<PodDispatchBuzzerAllocation>(entity =>
			{
				entity.ToTable("podDispatchBuzzerAllocation");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkBuzzerId).HasColumnName("FK_BuzzerId");

				entity.Property(e => e.FkPodCollectionNoteId).HasColumnName("FK_podCollectionNoteId");

				entity.HasOne(d => d.FkBuzzer)
					.WithMany(p => p.PodDispatchBuzzerAllocation)
					.HasForeignKey(d => d.FkBuzzerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DispatchBuzzerAllocation_DispatchBuzzer");

				entity.HasOne(d => d.FkPodCollectionNote)
					.WithMany(p => p.PodDispatchBuzzerAllocation)
					.HasForeignKey(d => d.FkPodCollectionNoteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podDispatchBuzzerAllocation_podCollectionNote");
			});

			modelBuilder.Entity<PodDispatchBuzzerAllocationTracking>(entity =>
			{
				entity.ToTable("podDispatchBuzzerAllocationTracking");

				entity.HasIndex(e => new { e.Created, e.FkUserId, e.FkBuzzerAllocationId, e.TypeCode })
					.HasName("ix_podDispatchBuzzerAllocationTracking_FK_BuzzerAllocationId_TypeCode_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkBuzzerAllocationId).HasColumnName("FK_BuzzerAllocationId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkBuzzerAllocation)
					.WithMany(p => p.PodDispatchBuzzerAllocationTracking)
					.HasForeignKey(d => d.FkBuzzerAllocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_podDispatchBuzzerAllocationTracking_podDispatchBuzzerAllocation1");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.PodDispatchBuzzerAllocationTracking)
					.HasForeignKey(d => d.FkUserId)
					.HasConstraintName("FK_podDispatchBuzzerAllocationTracking_Users");
			});

			modelBuilder.Entity<PrintDelayedReasons>(entity =>
			{
				entity.HasKey(e => e.ReasonCode);

				entity.Property(e => e.ReasonCode)
					.HasMaxLength(3)
					.ValueGeneratedNever();

				entity.Property(e => e.Reason).IsRequired();
			});

			modelBuilder.Entity<Printers>(entity =>
			{
				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PrintFolder)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Status).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.Printers)
					.HasForeignKey(d => d.FkBranchId)
					.HasConstraintName("FK_Printers_Branches");
			});

			modelBuilder.Entity<ProductPurchaseRecords>(entity =>
			{
				entity.HasKey(e => e.PurchaseId);

				entity.Property(e => e.PurchaseId).ValueGeneratedNever();

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<QuoteDocuments>(entity =>
			{
				entity.HasKey(e => e.QuoteDocumentId);

				entity.HasIndex(e => e.DocumentNumber);

				entity.HasIndex(e => e.DocumentType)
					.HasName("ix_QuoteDocuments_DocumentType");

				entity.HasIndex(e => new { e.QuoteDocumentId, e.DocumentNumber, e.DocumentDate, e.DocumentType, e.DocumentCreatetor, e.CustomerCode })
					.HasName("NonClusteredIndex-20121127-105713");

				entity.Property(e => e.QuoteDocumentId).ValueGeneratedNever();

				entity.Property(e => e.AccountManager).HasMaxLength(50);

				entity.Property(e => e.CustomerCode)
					.IsRequired()
					.HasMaxLength(255);

				entity.Property(e => e.DocumentCreatetor)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.DocumentDate).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Email).HasMaxLength(255);

				entity.Property(e => e.Message).HasMaxLength(400);
			});

			modelBuilder.Entity<QuoteLines>(entity =>
			{
				entity.HasKey(e => e.QuoteLineId);

				entity.HasIndex(e => e.QuoteDocumentQuoteDocumentId)
					.HasName("IX_FK_QuoteDocumentQuoteLine");

				entity.Property(e => e.QuoteLineId).ValueGeneratedNever();

				entity.Property(e => e.Comment).HasMaxLength(500);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<ReservationInfoes>(entity =>
			{
				entity.HasKey(e => e.DocumentNumber);

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(50)
					.ValueGeneratedNever();

				entity.Property(e => e.CustomerEmail)
					.IsRequired()
					.HasMaxLength(255);
			});

			modelBuilder.Entity<ReservedStockAdjustmentTransactions>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FromWarehouse)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.MiniPallet)
					.HasMaxLength(250)
					.IsUnicode(false);

				entity.Property(e => e.Picker)
					.HasMaxLength(250)
					.IsUnicode(false);

				entity.Property(e => e.ToWarehouse)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ReservedStocks>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.Property(e => e.ItemCode)
					.HasMaxLength(50)
					.ValueGeneratedNever();

				entity.Property(e => e.ReservedBnd).HasColumnName("ReservedBND");

				entity.Property(e => e.ReservedGlx).HasColumnName("ReservedGLX");

				entity.Property(e => e.ReservedInc).HasColumnName("ReservedINC");

				entity.Property(e => e.ReservedOvf).HasColumnName("ReservedOVF");

				entity.Property(e => e.ReservedWbn).HasColumnName("ReservedWBN");

				entity.Property(e => e.ReservedWmd).HasColumnName("ReservedWMD");
			});

			modelBuilder.Entity<Rework>(entity =>
			{
				entity.HasIndex(e => new { e.DocumentNumber, e.JobCardId, e.Status, e.Type })
					.HasName("ix_Rework_DocumentNumber_JobCardId_Status_Type");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkSkippedUserId).HasColumnName("FK_SkippedUserId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.JobCardNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.LinkUserDate).HasColumnType("datetime");

				entity.Property(e => e.SkippedDate).HasColumnType("datetime");

				entity.Property(e => e.SkippedReason)
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ReworkBoxes>(entity =>
			{
				entity.HasKey(e => new { e.FkWmsDocucmentBoxId, e.FkReworkId });

				entity.Property(e => e.FkWmsDocucmentBoxId).HasColumnName("FK_wmsDocucmentBoxId");

				entity.Property(e => e.FkReworkId).HasColumnName("FK_ReworkId");

				entity.HasOne(d => d.FkRework)
					.WithMany(p => p.ReworkBoxes)
					.HasForeignKey(d => d.FkReworkId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkBoxes_Rework");

				entity.HasOne(d => d.FkWmsDocucmentBox)
					.WithMany(p => p.ReworkBoxes)
					.HasForeignKey(d => d.FkWmsDocucmentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkBoxes_wmsDocumentBoxes1");
			});

			modelBuilder.Entity<ReworkDocuments>(entity =>
			{
				entity.HasKey(e => new { e.FkWmsDocumentId, e.FkReworkId });

				entity.Property(e => e.FkWmsDocumentId).HasColumnName("FK_wmsDocumentId");

				entity.Property(e => e.FkReworkId).HasColumnName("FK_ReworkId");

				entity.HasOne(d => d.FkRework)
					.WithMany(p => p.ReworkDocuments)
					.HasForeignKey(d => d.FkReworkId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkDocuments_Rework");

				entity.HasOne(d => d.FkWmsDocument)
					.WithMany(p => p.ReworkDocuments)
					.HasForeignKey(d => d.FkWmsDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkDocuments_wmsDocuments");
			});

			modelBuilder.Entity<ReworkInstructionBoxes>(entity =>
			{
				entity.Property(e => e.BoxBarcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BoxName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkReworkInstructionMasterBoxId).HasColumnName("FK_ReworkInstructionMasterBoxId");

				entity.HasOne(d => d.FkReworkInstructionMasterBox)
					.WithMany(p => p.ReworkInstructionBoxes)
					.HasForeignKey(d => d.FkReworkInstructionMasterBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkInstructionBoxes_ReworkInstructionMasterBoxes");
			});

			modelBuilder.Entity<ReworkInstructionData>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkReworkInstructionId).HasColumnName("FK_ReworkInstructionId");

				entity.Property(e => e.StringValue)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.StringValue2)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkReworkInstruction)
					.WithMany(p => p.ReworkInstructionData)
					.HasForeignKey(d => d.FkReworkInstructionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkInstructionData_ReworkInstruction");
			});

			modelBuilder.Entity<ReworkInstructionLines>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkReworkInstructionMasterLineId).HasColumnName("FK_ReworkInstructionMasterLineId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Reference)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkReworkInstructionMasterLine)
					.WithMany(p => p.ReworkInstructionLines)
					.HasForeignKey(d => d.FkReworkInstructionMasterLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkInstructionLines_ReworkInstructionMasterLines");
			});

			modelBuilder.Entity<ReworkInstructionMasterBoxes>(entity =>
			{
				entity.Property(e => e.BoxBarcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BoxName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkReworkInstructionId).HasColumnName("FK_ReworkInstructionId");

				entity.HasOne(d => d.FkReworkInstruction)
					.WithMany(p => p.ReworkInstructionMasterBoxes)
					.HasForeignKey(d => d.FkReworkInstructionId)
					.HasConstraintName("FK_ReworkInstructionMasterBoxes_ReworkInstructions");
			});

			modelBuilder.Entity<ReworkInstructionMasterLines>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkReworkInstructionId).HasColumnName("FK_ReworkInstructionId");

				entity.Property(e => e.FkReworkInstructionMasterBoxId).HasColumnName("FK_ReworkInstructionMasterBoxId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Reference)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkReworkInstruction)
					.WithMany(p => p.ReworkInstructionMasterLines)
					.HasForeignKey(d => d.FkReworkInstructionId)
					.HasConstraintName("FK_ReworkInstructionMasterLines_ReworkInstructions");

				entity.HasOne(d => d.FkReworkInstructionMasterBox)
					.WithMany(p => p.ReworkInstructionMasterLines)
					.HasForeignKey(d => d.FkReworkInstructionMasterBoxId)
					.HasConstraintName("FK_ReworkInstructionMasterLines_ReworkInstructionMasterBoxes");
			});

			modelBuilder.Entity<ReworkInstructions>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkBusyWithUserId).HasColumnName("FK_BusyWithUserId");

				entity.Property(e => e.FkCompletedByUserId).HasColumnName("FK_CompletedByUserId");

				entity.Property(e => e.FkOpenByUserId).HasColumnName("FK_OpenByUserId");

				entity.Property(e => e.FkReworkId).HasColumnName("FK_ReworkId");

				entity.Property(e => e.Name)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkRework)
					.WithMany(p => p.ReworkInstructions)
					.HasForeignKey(d => d.FkReworkId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReworkInstructions_Rework");
			});

			modelBuilder.Entity<ReworkReport>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Location)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.OrderNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<RushDocumentDetail>(entity =>
			{
				entity.HasIndex(e => e.DocumentNumber)
					.HasName("IX_RushDocumentDetail")
					.IsUnique();

				entity.Property(e => e.CollectionDate).HasColumnType("date");

				entity.Property(e => e.CourierName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkRushAccount).HasColumnName("FK_RushAccount");

				entity.Property(e => e.Service)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Waybill)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ScannedConveyerParcels>(entity =>
			{
				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Document)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Error)
					.IsRequired()
					.HasMaxLength(64)
					.IsUnicode(false);
			});

			modelBuilder.Entity<SecurityLevels>(entity =>
			{
				entity.HasKey(e => e.SecurityLevelId);

				entity.Property(e => e.SecurityLevelId).ValueGeneratedNever();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<SecurityLevelSecurityPermission>(entity =>
			{
				entity.HasKey(e => new { e.SecurityLevelsSecurityLevelId, e.SecurityPermissionsSecurityPermissionId })
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.SecurityLevelsSecurityLevelId).HasColumnName("SecurityLevels_SecurityLevelId");

				entity.Property(e => e.SecurityPermissionsSecurityPermissionId).HasColumnName("SecurityPermissions_SecurityPermissionId");

				entity.HasOne(d => d.SecurityLevelsSecurityLevel)
					.WithMany(p => p.SecurityLevelSecurityPermission)
					.HasForeignKey(d => d.SecurityLevelsSecurityLevelId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SecurityLevelSecurityPermission_SecurityLevel");

				entity.HasOne(d => d.SecurityPermissionsSecurityPermission)
					.WithMany(p => p.SecurityLevelSecurityPermission)
					.HasForeignKey(d => d.SecurityPermissionsSecurityPermissionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SecurityLevelSecurityPermission_SecurityPermission");
			});

			modelBuilder.Entity<SecurityPermissions>(entity =>
			{
				entity.HasKey(e => e.SecurityPermissionId);

				entity.Property(e => e.SecurityPermissionId).ValueGeneratedNever();

				entity.Property(e => e.Category)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<SentClientNotifications>(entity =>
			{
				entity.HasKey(e => e.NotificationId);

				entity.Property(e => e.NotificationId).HasDefaultValueSql("(newid())");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.EntityIdentifier)
					.IsRequired()
					.HasMaxLength(20);

				entity.Property(e => e.SentBy)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.SentToEmails)
					.IsRequired()
					.HasMaxLength(1024);

				entity.Property(e => e.SentToIdentifier)
					.IsRequired()
					.HasMaxLength(10);
			});

			modelBuilder.Entity<ServerDetails>(entity =>
			{
				entity.Property(e => e.CommonDatabaseName)
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.DatabaseName)
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.Ip)
					.HasColumnName("IP")
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.Password)
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.PastelAuthKey)
					.HasMaxLength(64)
					.IsUnicode(false);

				entity.Property(e => e.PastelSerialNumber)
					.HasMaxLength(12)
					.IsUnicode(false);

				entity.Property(e => e.Url)
					.HasColumnName("URL")
					.HasMaxLength(128)
					.IsUnicode(false);

				entity.Property(e => e.Username)
					.HasMaxLength(128)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ShipmentCommercialBrandingDocumentLines>(entity =>
			{
				entity.Property(e => e.FkCommerBrandingDocumentId).HasColumnName("FK_CommerBrandingDocumentId");

				entity.Property(e => e.FkShipmentCommercialBrandingDocumentId).HasColumnName("FK_ShipmentCommercialBrandingDocumentId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkCommerBrandingDocument)
					.WithMany(p => p.ShipmentCommercialBrandingDocumentLines)
					.HasForeignKey(d => d.FkCommerBrandingDocumentId)
					.HasConstraintName("FK_ShipmentCommercialBrandingDocumentLines_CommercialBrandingDocument");

				entity.HasOne(d => d.FkShipmentCommercialBrandingDocument)
					.WithMany(p => p.ShipmentCommercialBrandingDocumentLines)
					.HasForeignKey(d => d.FkShipmentCommercialBrandingDocumentId)
					.HasConstraintName("FK_ShipmentCommercialBrandingDocumentLines_ShipmentCommercialBrandingDocuments");
			});

			modelBuilder.Entity<ShipmentCommercialBrandingDocuments>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.DestinationBranchCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.FkCommerBrandingDocumentId).HasColumnName("FK_CommerBrandingDocumentId");

				entity.Property(e => e.FkShipmentId).HasColumnName("FK_ShipmentId");

				entity.Property(e => e.ParentDocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.SourceCompanyCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.HasOne(d => d.FkCommerBrandingDocument)
					.WithMany(p => p.ShipmentCommercialBrandingDocuments)
					.HasForeignKey(d => d.FkCommerBrandingDocumentId)
					.HasConstraintName("FK_ShipmentCommercialBrandingDocuments_CommercialBrandingDocument");

				entity.HasOne(d => d.FkShipment)
					.WithMany(p => p.ShipmentCommercialBrandingDocuments)
					.HasForeignKey(d => d.FkShipmentId)
					.HasConstraintName("FK_ShipmentCommercialBrandingDocuments_Shipments");
			});

			modelBuilder.Entity<ShipmentDetail>(entity =>
			{
				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkShipmentId).HasColumnName("FK_ShipmentId");

				entity.Property(e => e.FkWmsDocumentBoxId).HasColumnName("FK_wmsDocumentBoxId");

				entity.HasOne(d => d.FkShipment)
					.WithMany(p => p.ShipmentDetail)
					.HasForeignKey(d => d.FkShipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShipmentDetail_Shipments");

				entity.HasOne(d => d.FkWmsDocumentBox)
					.WithMany(p => p.ShipmentDetail)
					.HasForeignKey(d => d.FkWmsDocumentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShipmentDetail_wmsDocumentBoxes");
			});

			modelBuilder.Entity<ShipmentNumber>(entity =>
			{
				entity.Property(e => e.BranchCode)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ShipmentProcessTracking>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Description).IsUnicode(false);

				entity.Property(e => e.FkShipmentId).HasColumnName("FK_ShipmentId");

				entity.HasOne(d => d.FkShipment)
					.WithMany(p => p.ShipmentProcessTracking)
					.HasForeignKey(d => d.FkShipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShipmentProcessTracking_Shipments");
			});

			modelBuilder.Entity<ShipmentReservesRecycle>(entity =>
			{
				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkShipmentId).HasColumnName("FK_ShipmentId");

				entity.Property(e => e.InterBranchStockReservationDocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkShipment)
					.WithMany(p => p.ShipmentReservesRecycle)
					.HasForeignKey(d => d.FkShipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShipmentReservesRecycle_Shipments");
			});

			modelBuilder.Entity<Shipments>(entity =>
			{
				entity.Property(e => e.CommercialDocumentNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.CommercialInvoiceNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.DestinationBranchCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.FkCreatedUserId).HasColumnName("FK_CreatedUserId");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Ponumber)
					.HasColumnName("PONumber")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.SourceCompanyCode)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ShippingDestinations>(entity =>
			{
				entity.HasKey(e => e.ShippingDestinationId);

				entity.Property(e => e.City)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkShippingServiceId).HasColumnName("FK_ShippingService_Id");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.PostalCode)
					.IsRequired()
					.HasMaxLength(6);

				entity.Property(e => e.Province).IsRequired();

				entity.Property(e => e.Region)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.FkShippingService)
					.WithMany(p => p.ShippingDestinations)
					.HasForeignKey(d => d.FkShippingServiceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShippingServiceShippingDestination");
			});

			modelBuilder.Entity<ShippingProviderConfigurations>(entity =>
			{
				entity.HasKey(e => e.ConfigurationId);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkShippingProviderId).HasColumnName("FK_ShippingProvider_Id");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Value)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.FkShippingProvider)
					.WithMany(p => p.ShippingProviderConfigurations)
					.HasForeignKey(d => d.FkShippingProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShippingProviderShippingProviderConfiguration");
			});

			modelBuilder.Entity<ShippingProviders>(entity =>
			{
				entity.HasKey(e => e.ShippingProviderId);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<ShippingRates>(entity =>
			{
				entity.HasKey(e => e.RateId);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkShippingDestinationId).HasColumnName("FK_ShippingDestination_Id");

				entity.HasOne(d => d.FkShippingDestination)
					.WithMany(p => p.ShippingRates)
					.HasForeignKey(d => d.FkShippingDestinationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShippingDestinationShippingRate");
			});

			modelBuilder.Entity<ShippingServices>(entity =>
			{
				entity.HasKey(e => e.ShippingServiceId);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkShippingProviderId).HasColumnName("FK_ShippingProvider_Id");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(100);

				entity.HasOne(d => d.FkShippingProvider)
					.WithMany(p => p.ShippingServices)
					.HasForeignKey(d => d.FkShippingProviderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ShippingProviderShippingService");
			});

			modelBuilder.Entity<SpecialDates>(entity =>
			{
				entity.HasKey(e => e.SpecialDateId);

				entity.HasIndex(e => new { e.Year, e.SpecialDateValue })
					.HasName("NonClusteredIndex-20121210-122534")
					.IsUnique();

				entity.Property(e => e.SpecialDateId).ValueGeneratedNever();

				entity.Property(e => e.Name).IsRequired();

				entity.Property(e => e.SpecialDateValue).HasColumnType("datetime");
			});

			modelBuilder.Entity<SrReceiptCompletedLines>(entity =>
			{
				entity.ToTable("SR_ReceiptCompletedLines");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkReceiptId).HasColumnName("FK_ReceiptId");

				entity.Property(e => e.FkSrReceiptLineId).HasColumnName("FK_SR_ReceiptLineId");

				entity.Property(e => e.FkStockItemUomtemplateId).HasColumnName("FK_Stock_ItemUOMTemplateId");

				entity.HasOne(d => d.FkReceipt)
					.WithMany(p => p.SrReceiptCompletedLines)
					.HasForeignKey(d => d.FkReceiptId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SR_ReceiptCompletedLines_SR_Receipt");

				entity.HasOne(d => d.FkSrReceiptLine)
					.WithMany(p => p.SrReceiptCompletedLines)
					.HasForeignKey(d => d.FkSrReceiptLineId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SR_ReceiptCompletedLines_SR_ReceiptLines");
			});

			modelBuilder.Entity<SrReceiptLines>(entity =>
			{
				entity.ToTable("SR_ReceiptLines");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkReceiptId).HasColumnName("FK_ReceiptId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkReceipt)
					.WithMany(p => p.SrReceiptLines)
					.HasForeignKey(d => d.FkReceiptId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SR_ReceiptLines_SR_Receipt");
			});

			modelBuilder.Entity<SrReceipts>(entity =>
			{
				entity.ToTable("SR_Receipts");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<SrReceiptTracking>(entity =>
			{
				entity.ToTable("SR_ReceiptTracking");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FkSrReceiptId).HasColumnName("FK_SR_ReceiptId");

				entity.Property(e => e.FkSrReceiptLineId).HasColumnName("FK_SR_ReceiptLineId");

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.HasOne(d => d.FkSrReceipt)
					.WithMany(p => p.SrReceiptTracking)
					.HasForeignKey(d => d.FkSrReceiptId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SR_ReceiptTracking_SR_Receipt");

				entity.HasOne(d => d.FkSrReceiptLine)
					.WithMany(p => p.SrReceiptTracking)
					.HasForeignKey(d => d.FkSrReceiptLineId)
					.HasConstraintName("FK_SR_ReceiptTracking_SR_ReceiptLines");
			});

			modelBuilder.Entity<StockTakeBatches>(entity =>
			{
				entity.HasKey(e => e.BatchId);

				entity.Property(e => e.BatchId).ValueGeneratedNever();

				entity.Property(e => e.Closed).HasColumnType("datetime");

				entity.Property(e => e.Number)
					.IsRequired()
					.HasMaxLength(8)
					.IsUnicode(false);

				entity.Property(e => e.Started).HasColumnType("datetime");
			});

			modelBuilder.Entity<StockTakeRecords>(entity =>
			{
				entity.HasKey(e => e.RecordId);

				entity.Property(e => e.RecordId).ValueGeneratedNever();

				entity.Property(e => e.ExpectedItem)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.FkStockTakeBatchId).HasColumnName("FK_StockTakeBatchId");

				entity.Property(e => e.ResolvedComment)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

				entity.Property(e => e.ScannedItem)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.HasOne(d => d.FkStockTakeBatch)
					.WithMany(p => p.StockTakeRecords)
					.HasForeignKey(d => d.FkStockTakeBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockTakeBatchStockTakeRecord");
			});

			modelBuilder.Entity<StockTakeUnProcessedBatchEntries>(entity =>
			{
				entity.HasKey(e => e.BatchEntryId);

				entity.Property(e => e.BatchEntryId).ValueGeneratedNever();

				entity.Property(e => e.DateScanned).HasColumnType("datetime");

				entity.Property(e => e.EntryKey)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.FkStockTakeBatchId).HasColumnName("FK_StockTakeBatchId");

				entity.HasOne(d => d.FkStockTakeBatch)
					.WithMany(p => p.StockTakeUnProcessedBatchEntries)
					.HasForeignKey(d => d.FkStockTakeBatchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockTakeBatchStockTakeUnProcessedBatchEntry");
			});

			modelBuilder.Entity<SuggestedReOrderPallets>(entity =>
			{
				entity.HasKey(e => new { e.WarehouseReOrderId, e.PalletId })
					.ForSqlServerIsClustered(false);

				entity.HasIndex(e => e.PalletId)
					.HasName("IX_FK_PalletSuggestedReOrderPallet");

				entity.HasOne(d => d.Pallet)
					.WithMany(p => p.SuggestedReOrderPallets)
					.HasForeignKey(d => d.PalletId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PalletSuggestedReOrderPallet");

				entity.HasOne(d => d.WarehouseReOrder)
					.WithMany(p => p.SuggestedReOrderPallets)
					.HasForeignKey(d => d.WarehouseReOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehouseReorderSuggestedReOrderPallet");
			});

			modelBuilder.Entity<SwadSummary>(entity =>
			{
				entity.Property(e => e.DimError).HasColumnName("Dim_Error");

				entity.Property(e => e.ReadError).HasColumnName("Read_Error");

				entity.Property(e => e.WeightError).HasColumnName("Weight_Error");
			});

			modelBuilder.Entity<SyncDataErrorDetail>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Detail)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkSyncDataErrorId).HasColumnName("FK_SyncDataErrorId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Value)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkSyncDataError)
					.WithMany(p => p.SyncDataErrorDetail)
					.HasForeignKey(d => d.FkSyncDataErrorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SyncDataErrorDetail_SyncDataErrors");
			});

			modelBuilder.Entity<SyncDataErrorRecipients>(entity =>
			{
				entity.Property(e => e.Email)
					.IsRequired()
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.FkSyncDataErrorId).HasColumnName("FK_SyncDataErrorId");

				entity.HasOne(d => d.FkSyncDataError)
					.WithMany(p => p.SyncDataErrorRecipients)
					.HasForeignKey(d => d.FkSyncDataErrorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SyncDataErrorRecipients_SyncDataErrors");
			});

			modelBuilder.Entity<SyncDataErrors>(entity =>
			{
				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Detail)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SyncSource)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.TypeKey)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<TaxRates>(entity =>
			{
				entity.Property(e => e.CompanyCode)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Modified).HasColumnType("datetime");

				entity.Property(e => e.PastelLookup)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.XfxHostId).HasColumnName("XFX_HostId");
			});

			modelBuilder.Entity<TempNotCreatable>(entity =>
			{
				entity.ToTable("_TempNotCreatable");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(15)
					.IsUnicode(false);

				entity.Property(e => e.Upc).HasColumnName("UPC");
			});

			modelBuilder.Entity<TempPalletCodes>(entity =>
			{
				entity.HasKey(e => e.Code);

				entity.ToTable("_TempPalletCodes");

				entity.Property(e => e.Code)
					.HasMaxLength(12)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<TempPrices>(entity =>
			{
				entity.HasKey(e => e.ItemCode);

				entity.ToTable("_tempPrices");

				entity.Property(e => e.ItemCode)
					.HasMaxLength(20)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<TurnOverTest>(entity =>
			{
				entity.HasKey(e => e.DocumentNumber);

				entity.ToTable("_TurnOverTest");

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(50)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<TurnoverTransactionDetails>(entity =>
			{
				entity.Property(e => e.FkLineId).HasColumnName("FK_Line_Id");

				entity.Property(e => e.FkTurnoverId).HasColumnName("FK_Turnover_Id");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<TurnoverTransactions>(entity =>
			{
				entity.HasKey(e => e.TurnOverId);

				entity.ToTable("_TurnoverTransactions");

				entity.Property(e => e.DateAdded).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(10);
			});

			modelBuilder.Entity<TurnoverTransactions1>(entity =>
			{
				entity.HasKey(e => e.TurnOverId);

				entity.ToTable("TurnoverTransactions");

				entity.HasIndex(e => new { e.TurnOverId, e.DocumentNumber, e.DocumentVersion })
					.HasName("IX_TurnOver_Documents");

				entity.HasIndex(e => new { e.DocumentNumber, e.DocumentVersion, e.Flags, e.Type })
					.HasName("ix_TurnoverTransactions_Type_includes");

				entity.HasIndex(e => new { e.DocumentNumber, e.DocumentVersion, e.Flags, e.Type, e.DateAdded })
					.HasName("ix_TurnoverTransactions_Type_DateAdded_includes");

				entity.HasIndex(e => new { e.DocumentNumber, e.DocumentVersion, e.GiftsExcl, e.ClothingExcl, e.BrandingExcl, e.CostGifts, e.CostClothing, e.HeadwearExcl, e.CostHeadwearExcl, e.DateAdded, e.Type })
					.HasName("ix_TurnoverTransactions_DateAdded_Type_includes");

				entity.Property(e => e.AudDate)
					.HasColumnName("audDate")
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CostHeadwearExcl).HasDefaultValueSql("((0))");

				entity.Property(e => e.DateAdded).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.HeadwearExcl).HasDefaultValueSql("((0))");
			});

			modelBuilder.Entity<TurnoverTransfers>(entity =>
			{
				entity.HasKey(e => e.TransferId);

				entity.Property(e => e.DateTransferFrom).HasColumnType("datetime");

				entity.Property(e => e.DateTransferTo).HasColumnType("datetime");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<UserBranches>(entity =>
			{
				entity.HasKey(e => new { e.FkUserId, e.FkBranchId });

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.FkBranchId).HasColumnName("FK_BranchId");

				entity.HasOne(d => d.FkBranch)
					.WithMany(p => p.UserBranches)
					.HasForeignKey(d => d.FkBranchId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserBranches_Branches");

				entity.HasOne(d => d.FkUser)
					.WithMany(p => p.UserBranches)
					.HasForeignKey(d => d.FkUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserBranches_Users");
			});

			modelBuilder.Entity<UserDepartment>(entity =>
			{
				entity.HasKey(e => new { e.UsersUserId, e.DepartmentsDepartmentId })
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.UsersUserId).HasColumnName("Users_UserId");

				entity.Property(e => e.DepartmentsDepartmentId).HasColumnName("Departments_DepartmentId");

				entity.HasOne(d => d.DepartmentsDepartment)
					.WithMany(p => p.UserDepartment)
					.HasForeignKey(d => d.DepartmentsDepartmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserDepartment_Department");

				entity.HasOne(d => d.UsersUser)
					.WithMany(p => p.UserDepartment)
					.HasForeignKey(d => d.UsersUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserDepartment_User");
			});

			modelBuilder.Entity<UserLink>(entity =>
			{
				entity.HasKey(e => new { e.FkPrimaryUserId, e.FkLinkUserId, e.Type });

				entity.Property(e => e.FkPrimaryUserId).HasColumnName("FK_PrimaryUserId");

				entity.Property(e => e.FkLinkUserId).HasColumnName("FK_LinkUserId");
			});

			modelBuilder.Entity<Users>(entity =>
			{
				entity.HasKey(e => e.UserId);

				entity.HasIndex(e => new { e.Firstname, e.Lastname, e.PhoneDirect, e.PhoneMobile, e.PrimaryEmail, e.SecondaryEmail, e.Fax2Email, e.EmployeeCode, e.Username })
					.HasName("ix_Users_Username_includes");

				entity.Property(e => e.UserId).ValueGeneratedNever();

				entity.Property(e => e.Barcode).HasMaxLength(13);

				entity.Property(e => e.EmployeeCode)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Fax2Email).HasMaxLength(20);

				entity.Property(e => e.Firstname)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Lastname)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.PhoneDirect)
					.HasColumnName("Phone_Direct")
					.HasMaxLength(20);

				entity.Property(e => e.PhoneMobile)
					.HasColumnName("Phone_Mobile")
					.HasMaxLength(20);

				entity.Property(e => e.PrimaryEmail).HasMaxLength(100);

				entity.Property(e => e.SalesmanCode)
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.ScaleClientUrl)
					.HasColumnName("SCALE_ClientUrl")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ScaleDeviceScanSuffix).HasColumnName("SCALE_DeviceScanSuffix");

				entity.Property(e => e.ScaleDomain)
					.HasColumnName("SCALE_Domain")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ScalePassword)
					.HasColumnName("SCALE_Password")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ScaleServer)
					.HasColumnName("SCALE_Server")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ScaleUsername)
					.HasColumnName("SCALE_Username")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SecondaryEmail).HasColumnType("nvarchar(max)");

				entity.Property(e => e.TrackingCode).HasMaxLength(50);

				entity.Property(e => e.Username)
					.IsRequired()
					.HasMaxLength(25);

				entity.HasOne(d => d.SecurityLevelSecurityLevel)
					.WithMany(p => p.Users)
					.HasForeignKey(d => d.SecurityLevelSecurityLevelId)
					.HasConstraintName("FK_UserSecurityLevel");

				entity.HasOne(d => d.UserUser)
					.WithMany(p => p.InverseUserUser)
					.HasForeignKey(d => d.UserUserId)
					.HasConstraintName("FK_UserUser");
			});

			modelBuilder.Entity<UserSecurityPermission>(entity =>
			{
				entity.HasKey(e => new { e.UsersUserId, e.SecurityPermissionsSecurityPermissionId })
					.ForSqlServerIsClustered(false);

				entity.Property(e => e.UsersUserId).HasColumnName("Users_UserId");

				entity.Property(e => e.SecurityPermissionsSecurityPermissionId).HasColumnName("SecurityPermissions_SecurityPermissionId");

				entity.HasOne(d => d.SecurityPermissionsSecurityPermission)
					.WithMany(p => p.UserSecurityPermission)
					.HasForeignKey(d => d.SecurityPermissionsSecurityPermissionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserSecurityPermission_SecurityPermission");

				entity.HasOne(d => d.UsersUser)
					.WithMany(p => p.UserSecurityPermission)
					.HasForeignKey(d => d.UsersUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserSecurityPermission_User");
			});

			modelBuilder.Entity<UtiBondedIntegrationAudit>(entity =>
			{
				entity.ToTable("UTI_BondedIntegrationAudit");

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.FileLocation)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<WarehouseEntityMovements>(entity =>
			{
				entity.HasKey(e => e.MovementId);

				entity.HasIndex(e => new { e.EntityId, e.MovementDate, e.LocationFromId, e.LocationToId, e.MovementCode })
					.HasName("IX_WarehouseEntityMovements_MovementCode");

				entity.Property(e => e.MovementId).ValueGeneratedNever();

				entity.Property(e => e.EntityType).IsRequired();

				entity.Property(e => e.MovementActionarCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.MovementCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.MovementDate).HasColumnType("datetime");

				entity.Property(e => e.MovementDetails).IsRequired();
			});

			modelBuilder.Entity<WarehouseLocations>(entity =>
			{
				entity.HasKey(e => e.WarehouseLocationId);

				entity.Property(e => e.WarehouseLocationId).ValueGeneratedNever();

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(13);

				entity.Property(e => e.Bay)
					.IsRequired()
					.HasMaxLength(10);

				entity.Property(e => e.Floor)
					.IsRequired()
					.HasMaxLength(10);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);

				entity.HasOne(d => d.WarehouseWarehouse)
					.WithMany(p => p.WarehouseLocations)
					.HasForeignKey(d => d.WarehouseWarehouseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehouseWarehouseLocaton");
			});

			modelBuilder.Entity<WarehouseMinimumReorders>(entity =>
			{
				entity.HasKey(e => e.ReorderId);

				entity.Property(e => e.ReorderId).HasDefaultValueSql("(newid())");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<WarehouseNotifications>(entity =>
			{
				entity.HasKey(e => e.NotificationId);

				entity.Property(e => e.NotificationId).HasDefaultValueSql("(newid())");

				entity.Property(e => e.RecipientEmail).HasMaxLength(1024);

				entity.HasOne(d => d.Warehouse)
					.WithMany(p => p.WarehouseNotifications)
					.HasForeignKey(d => d.WarehouseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehouseNotificationRecipients");
			});

			modelBuilder.Entity<WarehouseReorders>(entity =>
			{
				entity.HasKey(e => e.ReOrderId);

				entity.Property(e => e.ReOrderId).ValueGeneratedNever();

				entity.Property(e => e.DateIssued).HasColumnType("datetime");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<WarehouseReplenishments>(entity =>
			{
				entity.HasKey(e => e.ReplenishmentId);

				entity.Property(e => e.ReplenishmentId).ValueGeneratedNever();
			});

			modelBuilder.Entity<Warehouses>(entity =>
			{
				entity.HasKey(e => e.WarehouseId);

				entity.Property(e => e.WarehouseId).ValueGeneratedNever();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(3);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<WarehouseStockStorageMovements>(entity =>
			{
				entity.HasKey(e => e.MovementId);

				entity.Property(e => e.MovementId).ValueGeneratedNever();

				entity.Property(e => e.FkExternalDocumentId).HasColumnName("FK_ExternalDocument_Id");

				entity.Property(e => e.FkHistoryId).HasColumnName("FK_History_Id");

				entity.Property(e => e.FkPalletId).HasColumnName("FK_Pallet_Id");

				entity.Property(e => e.FkStockStorageId).HasColumnName("FK_StockStorage_Id");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.MovementDate).HasColumnType("datetime");

				entity.HasOne(d => d.FkHistory)
					.WithMany(p => p.WarehouseStockStorageMovements)
					.HasForeignKey(d => d.FkHistoryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_History_ContributorWarehouseStockStorageMovement");

				entity.HasOne(d => d.FkPallet)
					.WithMany(p => p.WarehouseStockStorageMovements)
					.HasForeignKey(d => d.FkPalletId)
					.HasConstraintName("FK_PalletWarehouseStockStorageMovement");

				entity.HasOne(d => d.FkStockStorage)
					.WithMany(p => p.WarehouseStockStorageMovements)
					.HasForeignKey(d => d.FkStockStorageId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehouseStockStorageWarehouseStockStorageMovement");
			});

			modelBuilder.Entity<WarehouseStockStorages>(entity =>
			{
				entity.HasKey(e => e.StorageId);

				entity.HasIndex(e => new { e.ItemCode, e.FkWarehouseId, e.Qc })
					.HasName("UK_WarehouseStockStorages")
					.IsUnique();

				entity.Property(e => e.StorageId).ValueGeneratedNever();

				entity.Property(e => e.FkWarehouseId).HasColumnName("FK_Warehouse_Id");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Qc).HasColumnName("QC");

				entity.HasOne(d => d.FkWarehouse)
					.WithMany(p => p.WarehouseStockStorages)
					.HasForeignKey(d => d.FkWarehouseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WarehouseWarehouseStockStorage");
			});

			modelBuilder.Entity<WdbActiveJobcards>(entity =>
			{
				entity.HasKey(e => e.JobCardNumber);

				entity.ToTable("wdbActiveJobcards");

				entity.Property(e => e.JobCardNumber)
					.HasMaxLength(55)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.AccountNumber)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.ActionDate).HasColumnType("date");

				entity.Property(e => e.Brand)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.CustomerReference)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.DocumentDate).HasColumnType("date");

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.DueDate).HasColumnType("date");

				entity.Property(e => e.JobCardDate).HasColumnType("date");

				entity.Property(e => e.JobCardStatusText)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PrintDepartment)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.PrintProcessCode)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.PrintProcessDescription)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.PrintStockItem)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);
			});

			modelBuilder.Entity<WdbActiveOrders>(entity =>
			{
				entity.HasKey(e => e.DocumentNumber);

				entity.ToTable("wdbActiveOrders");

				entity.HasIndex(e => new { e.DocumentNumber, e.OrderId, e.AccountName, e.CustomerReference, e.DocumentDate, e.InvoiceNumber, e.DocumentStatusText, e.DocumentStatus, e.FirstStockLine, e.LineCount, e.TotalExcl, e.TotalIncl, e.CurrentWarehouse, e.DestinationWarehouse, e.CurrentWarehouseName, e.DestinationWarehouseName, e.TotalBoxes, e.DocumentFlags, e.AccountNumber })
					.HasName("ix_wdbActiveOrders_AccountNumber_includes");

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(50)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.AccountName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.AccountNumber)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Brand)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.CurrentWarehouse)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.CurrentWarehouseName)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.CustomerReference)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.DeliveryStatusText)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DestinationWarehouse)
					.IsRequired()
					.HasMaxLength(3)
					.IsUnicode(false);

				entity.Property(e => e.DestinationWarehouseName)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.DocumentDate).HasColumnType("date");

				entity.Property(e => e.DocumentStatusText)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FirstStockLine)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.InvoiceNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.TotalBoxes).HasDefaultValueSql("((0))");
			});

			modelBuilder.Entity<WdbRecentCreditNotes>(entity =>
			{
				entity.HasKey(e => e.DocumentNumber);

				entity.ToTable("wdbRecentCreditNotes");

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(50)
					.IsUnicode(false)
					.ValueGeneratedNever();

				entity.Property(e => e.AccountNumber)
					.IsRequired()
					.HasMaxLength(20)
					.IsUnicode(false);

				entity.Property(e => e.Brand)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.CustomerReference)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.DocumentDate).HasColumnType("date");

				entity.Property(e => e.FirstLineItem)
					.IsRequired()
					.HasMaxLength(400)
					.IsUnicode(false);

				entity.Property(e => e.LinkDocumentNumber)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<WdbResync>(entity =>
			{
				entity.HasKey(e => e.CustomerCode);

				entity.ToTable("_wdbResync");

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(20)
					.IsUnicode(false)
					.ValueGeneratedNever();
			});

			modelBuilder.Entity<WmsDocumentBoxDetail>(entity =>
			{
				entity.ToTable("wmsDocumentBoxDetail");

				entity.HasIndex(e => new { e.ItemCode, e.Quantity, e.FkWmsDocumentBoxId })
					.HasName("ix_wmsDocumentBoxDetail_FK_wmsDocumentBoxId_includes");

				entity.HasIndex(e => new { e.Id, e.FkWmsDocumentBoxId, e.Created, e.ItemCode, e.Quantity, e.Type, e.Status, e.Flags, e.FkWmsDocumentBoxMasterDetailId })
					.HasName("ix_wmsDocumentBoxDetail_FK_WmsDocumentBoxMasterDetailId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkWmsDocumentBoxId).HasColumnName("FK_wmsDocumentBoxId");

				entity.Property(e => e.FkWmsDocumentBoxMasterDetailId).HasColumnName("FK_WmsDocumentBoxMasterDetailId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkWmsDocumentBox)
					.WithMany(p => p.WmsDocumentBoxDetail)
					.HasForeignKey(d => d.FkWmsDocumentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentBoxDetail_wmsDocumentBoxes");

				entity.HasOne(d => d.FkWmsDocumentBoxMasterDetail)
					.WithMany(p => p.InverseFkWmsDocumentBoxMasterDetail)
					.HasForeignKey(d => d.FkWmsDocumentBoxMasterDetailId)
					.HasConstraintName("FK_wmsDocumentBoxDetail_wmsDocumentBoxDetail");
			});

			modelBuilder.Entity<WmsDocumentBoxes>(entity =>
			{
				entity.ToTable("wmsDocumentBoxes");

				entity.HasIndex(e => new { e.Id, e.Flags, e.LocationName })
					.HasName("ix_wmsDocumentBoxes_LocationName_includes");

				entity.HasIndex(e => new { e.Id, e.FkWmsDocumentBoxMasterId, e.Created, e.Flags, e.Barcode })
					.HasName("ix_wmsDocumentBoxes_Barcode_includes");

				entity.HasIndex(e => new { e.Id, e.Name, e.FkLocationId, e.Type, e.Status, e.Flags, e.SwadinfoCounter, e.FkWmsDocumentBoxMasterId, e.Barcode })
					.HasName("ix_wmsDocumentBoxes_FK_WmsDocumentBoxMasterId_Barcode_includes");

				entity.HasIndex(e => new { e.Id, e.Created, e.Barcode, e.Name, e.Number, e.FkLocationId, e.LocationName, e.BoxSource, e.Type, e.Status, e.Flags, e.SwadinfoCounter, e.FkWmsDocumentBoxMasterId })
					.HasName("ix_wmsDocumentBoxes_FK_WmsDocumentBoxMasterId_includes");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkLocationId).HasColumnName("FK_LocationId");

				entity.Property(e => e.FkWmsDocumentBoxMasterId).HasColumnName("FK_WmsDocumentBoxMasterId");

				entity.Property(e => e.LocationName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.SwadinfoCounter).HasColumnName("SWADInfoCounter");

				entity.Property(e => e.TempFkWmsDocumentId).HasColumnName("TempFK_WmsDocumentId");

				entity.HasOne(d => d.FkWmsDocumentBoxMaster)
					.WithMany(p => p.InverseFkWmsDocumentBoxMaster)
					.HasForeignKey(d => d.FkWmsDocumentBoxMasterId)
					.HasConstraintName("FK_wmsDocumentBoxes_wmsDocumentBoxes");
			});

			modelBuilder.Entity<WmsDocumentBoxInfo>(entity =>
			{
				entity.ToTable("wmsDocumentBoxInfo");

				entity.HasIndex(e => e.FkWmsDocumentBoxId)
					.HasName("ix_wmsDocumentBoxInfo_FK_wmsDocumentBoxId");

				entity.Property(e => e.FkWmsDocumentBoxId).HasColumnName("FK_wmsDocumentBoxId");

				entity.Property(e => e.HeightUnit)
					.HasColumnName("Height_Unit")
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("('cm')");

				entity.Property(e => e.LengthUnit)
					.HasColumnName("Length_Unit")
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("('cm')");

				entity.Property(e => e.WeightUnit)
					.HasColumnName("Weight_Unit")
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("('kg')");

				entity.Property(e => e.WidthUnit)
					.HasColumnName("Width_Unit")
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasDefaultValueSql("('cm')");

				entity.HasOne(d => d.FkWmsDocumentBox)
					.WithMany(p => p.WmsDocumentBoxInfo)
					.HasForeignKey(d => d.FkWmsDocumentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentBoxInfo_wmsDocumentBoxes");
			});

			modelBuilder.Entity<WmsDocumentBoxLinks>(entity =>
			{
				entity.HasKey(e => new { e.FkWmsDocumentId, e.FkWmsDocumentBoxId });

				entity.ToTable("wmsDocumentBoxLinks");

				entity.HasIndex(e => new { e.FkWmsDocumentId, e.FkWmsDocumentBoxId })
					.HasName("ix_wmsDocumentBoxLinks_FK_WmsDocumentBoxId_includes");

				entity.Property(e => e.FkWmsDocumentId).HasColumnName("FK_WmsDocumentId");

				entity.Property(e => e.FkWmsDocumentBoxId).HasColumnName("FK_WmsDocumentBoxId");

				entity.HasOne(d => d.FkWmsDocumentBox)
					.WithMany(p => p.WmsDocumentBoxLinks)
					.HasForeignKey(d => d.FkWmsDocumentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentBoxLinks_wmsDocumentBoxes");

				entity.HasOne(d => d.FkWmsDocument)
					.WithMany(p => p.WmsDocumentBoxLinks)
					.HasForeignKey(d => d.FkWmsDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentBoxLinks_wmsDocuments");
			});

			modelBuilder.Entity<WmsDocumentBoxMovements>(entity =>
			{
				entity.ToTable("wmsDocumentBoxMovements");

				entity.Property(e => e.BoxBarcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BoxDocumentNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BoxName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.BoxWmsDocumentNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.CurrentLocaitonBarcode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CurrentLocationBranchCode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.CurrentLocationName)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ToParentLocationBarcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ToParentLocationBranchCode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ToParentLocationInstruction)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ToParentLocationInstructionColor)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ToParentLocationInstructionNumber)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.ToParentLocationName)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<WmsDocumentBoxTracking>(entity =>
			{
				entity.HasKey(e => new { e.FkWmsDocumentBoxId, e.FkWmsTrackingId });

				entity.ToTable("wmsDocumentBoxTracking");

				entity.HasIndex(e => e.FkWmsTrackingId)
					.HasName("IX_wmsDocumentBoxTracking")
					.IsUnique();

				entity.Property(e => e.FkWmsDocumentBoxId).HasColumnName("FK_wmsDocumentBoxId");

				entity.Property(e => e.FkWmsTrackingId).HasColumnName("FK_wmsTrackingId");

				entity.HasOne(d => d.FkWmsDocumentBox)
					.WithMany(p => p.WmsDocumentBoxTracking)
					.HasForeignKey(d => d.FkWmsDocumentBoxId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentBoxTracking_wmsDocumentBoxes");

				entity.HasOne(d => d.FkWmsTracking)
					.WithOne(p => p.WmsDocumentBoxTracking)
					.HasForeignKey<WmsDocumentBoxTracking>(d => d.FkWmsTrackingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentBoxTracking_wmsTracking");
			});

			modelBuilder.Entity<WmsDocumentImportStatus>(entity =>
			{
				entity.HasKey(e => new { e.DocumentNumber, e.DocumentVersion });

				entity.ToTable("WMS_DocumentImport_Status");

				entity.Property(e => e.DocumentNumber)
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.WmsImport).HasColumnName("WMS_Import");

				entity.Property(e => e.WmsImportDate)
					.HasColumnName("WMS_ImportDate")
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.WmsPickComplete).HasColumnName("WMS_PickComplete");

				entity.Property(e => e.WmsPickCompleteDate)
					.HasColumnName("WMS_PickCompleteDate")
					.HasColumnType("datetime");

				entity.Property(e => e.WmsPickStartDate)
					.HasColumnName("WMS_PickStartDate")
					.HasColumnType("datetime");

				entity.Property(e => e.WmsPickStarted).HasColumnName("WMS_PickStarted");
			});

			modelBuilder.Entity<WmsDocumentLines>(entity =>
			{
				entity.ToTable("wmsDocumentLines");

				entity.HasIndex(e => new { e.ItemCode, e.PickedQuantity, e.FkWmsDocumentId })
					.HasName("ix_wmsDocumentLines_FK_wmsDocumentId_includes");

				entity.HasIndex(e => new { e.Id, e.FkWmsDocumentId, e.ItemCode, e.Created, e.PickedQuantity, e.Quantity, e.Type, e.Status, e.Flags, e.FkWmsDocumentMasterLineId })
					.HasName("ix_wmsDocumentLines_FK_wmsDocumentMasterLineId_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkWmsDocumentId).HasColumnName("FK_wmsDocumentId");

				entity.Property(e => e.FkWmsDocumentMasterLineId).HasColumnName("FK_wmsDocumentMasterLineId");

				entity.Property(e => e.ItemCode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.HasOne(d => d.FkWmsDocument)
					.WithMany(p => p.WmsDocumentLines)
					.HasForeignKey(d => d.FkWmsDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentLines_wmsDocuments");

				entity.HasOne(d => d.FkWmsDocumentMasterLine)
					.WithMany(p => p.InverseFkWmsDocumentMasterLine)
					.HasForeignKey(d => d.FkWmsDocumentMasterLineId)
					.HasConstraintName("FK_wmsDocumentLines_wmsDocumentLines");
			});

			modelBuilder.Entity<WmsDocumentLinks>(entity =>
			{
				entity.HasKey(e => new { e.FkWmsDocumentParentId, e.FkWmsDocumentId });

				entity.HasIndex(e => e.FkWmsDocumentId)
					.HasName("ix_WmsDocumentLinks_FK_WmsDocumentId");

				entity.Property(e => e.FkWmsDocumentParentId).HasColumnName("FK_WmsDocumentParentId");

				entity.Property(e => e.FkWmsDocumentId).HasColumnName("FK_WmsDocumentId");

				entity.HasOne(d => d.FkWmsDocument)
					.WithMany(p => p.WmsDocumentLinksFkWmsDocument)
					.HasForeignKey(d => d.FkWmsDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WmsDocumentLinks_wmsDocuments1");

				entity.HasOne(d => d.FkWmsDocumentParent)
					.WithMany(p => p.WmsDocumentLinksFkWmsDocumentParent)
					.HasForeignKey(d => d.FkWmsDocumentParentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_WmsDocumentLinks_wmsDocuments");
			});

			modelBuilder.Entity<WmsDocuments>(entity =>
			{
				entity.ToTable("wmsDocuments");

				entity.HasIndex(e => e.Guid)
					.HasName("ix_wmsDocuments_Guid");

				entity.HasIndex(e => new { e.Id, e.DocumentNumber, e.Type })
					.HasName("ix_wmsDocuments_DocumentNumber_Type_includes");

				entity.HasIndex(e => new { e.Version, e.ParentDocumentNumber, e.Type })
					.HasName("IX_wmsDocuments_CurrentVersion");

				entity.HasIndex(e => new { e.Id, e.FkDocumentId, e.Status, e.Flags, e.Type })
					.HasName("ix_wmsDocuments_Type_includes");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.CustomerCode)
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.DocumentNumber)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkDocumentId).HasColumnName("FK_DocumentId");

				entity.Property(e => e.FkJobCardId).HasColumnName("FK_JobCardId");

				entity.Property(e => e.FkWmsDocumentParentId).HasColumnName("FK_WmsDocumentParentId");

				entity.Property(e => e.ParentDocumentNumber)
					.IsRequired()
					.HasMaxLength(10)
					.IsUnicode(false);
			});

			modelBuilder.Entity<WmsDocumentTracking>(entity =>
			{
				entity.HasKey(e => new { e.FkWmsDocumentId, e.FkWmsTrackingId });

				entity.ToTable("wmsDocumentTracking");

				entity.HasIndex(e => e.FkWmsTrackingId)
					.HasName("IX_wmsDocumentTracking")
					.IsUnique();

				entity.Property(e => e.FkWmsDocumentId).HasColumnName("FK_wmsDocumentId");

				entity.Property(e => e.FkWmsTrackingId).HasColumnName("FK_wmsTrackingId");

				entity.HasOne(d => d.FkWmsDocument)
					.WithMany(p => p.WmsDocumentTracking)
					.HasForeignKey(d => d.FkWmsDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentTracking_wmsDocuments");

				entity.HasOne(d => d.FkWmsTracking)
					.WithOne(p => p.WmsDocumentTracking)
					.HasForeignKey<WmsDocumentTracking>(d => d.FkWmsTrackingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsDocumentTracking_wmsTracking");
			});

			modelBuilder.Entity<WmsStagingLocations>(entity =>
			{
				entity.ToTable("wmsStagingLocations");

				entity.Property(e => e.Barcode)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkLocationId).HasColumnName("FK_LocationId");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);
			});

			modelBuilder.Entity<WmsStagingLocationSessionBoxes>(entity =>
			{
				entity.ToTable("wmsStagingLocationSessionBoxes");

				entity.HasIndex(e => new { e.FkWmsDocumentBoxId, e.FkWmsStagingLocationSessionId })
					.HasName("IX_wmsStagingLocationSessionBoxes_1")
					.IsUnique();

				entity.Property(e => e.FkWmsDocumentBoxId).HasColumnName("FK_wmsDocumentBoxId");

				entity.Property(e => e.FkWmsStagingLocationSessionId).HasColumnName("FK_wmsStagingLocationSessionId");

				entity.HasOne(d => d.FkWmsStagingLocationSession)
					.WithMany(p => p.WmsStagingLocationSessionBoxes)
					.HasForeignKey(d => d.FkWmsStagingLocationSessionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsStagingLocationSessionBoxes_wmsStagingLocationSessions");
			});

			modelBuilder.Entity<WmsStagingLocationSessions>(entity =>
			{
				entity.ToTable("wmsStagingLocationSessions");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.FkFromLocationId).HasColumnName("FK_FromLocationId");

				entity.Property(e => e.FkToParentLocationId).HasColumnName("FK_ToParentLocationId");

				entity.Property(e => e.FkWmsStagingLocationId).HasColumnName("FK_wmsStagingLocationId");

				entity.HasOne(d => d.FkWmsStagingLocation)
					.WithMany(p => p.WmsStagingLocationSessions)
					.HasForeignKey(d => d.FkWmsStagingLocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsStagingLocationSessions_wmsStagingLocations");
			});

			modelBuilder.Entity<WmsStagingLocationSessionTracking>(entity =>
			{
				entity.ToTable("wmsStagingLocationSessionTracking");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.FkWmsStagingLocationSessionBoxId).HasColumnName("FK_wmsStagingLocationSessionBoxId");

				entity.Property(e => e.FkWmsStagingLocationSessionId).HasColumnName("FK_wmsStagingLocationSessionId");

				entity.HasOne(d => d.FkWmsStagingLocationSessionBox)
					.WithMany(p => p.WmsStagingLocationSessionTracking)
					.HasForeignKey(d => d.FkWmsStagingLocationSessionBoxId)
					.HasConstraintName("FK_wmsStagingLocationSessionTracking_wmsStagingLocationSessionBoxes");

				entity.HasOne(d => d.FkWmsStagingLocationSession)
					.WithMany(p => p.WmsStagingLocationSessionTracking)
					.HasForeignKey(d => d.FkWmsStagingLocationSessionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_wmsStagingLocationSessionTracking_wmsStagingLocationSessions");
			});

			modelBuilder.Entity<WmsTracking>(entity =>
			{
				entity.ToTable("wmsTracking");

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.FkUserId).HasColumnName("FK_UserId");

				entity.Property(e => e.FkUserName)
					.HasColumnName("FK_UserName")
					.HasMaxLength(255)
					.IsUnicode(false);
			});
		}
	}
}
