namespace Amtrack.Logger
{
	/// <summary>
	/// Every Logger Used in Amtrack needs to be registered here.
	/// Logger names are formatted {Server/Application}.{Module}
	/// </summary>
	public static class LoggerNames
	{
		// AmtrackWebSync
		public const string AmtrackWebSync_Service = "AmtrackWebSync.Service";
		public const string AmtrackWebSync_Branding = "AmtrackWebSync.Branding";
		public const string AmtrackWebSync_BrandingPositions = "AmtrackWebSync.BrandingPositions";
		public const string AmtrackWebSync_BrandingSpecials = "AmtrackWebSync.BrandingSpecials";
		public const string AmtrackWebSync_Images = "AmtrackWebSync.Images";
		public const string AmtrackWebSync_BrandingGuides = "AmtrackWebSync.BrandingGuides";
		public const string AmtrackWebSync_AccountStatus = "AmtrackWebSync.AccountStatus";
		public const string AmtrackWebSync_StockLevel = "AmtrackWebSync.StockLevel";
		public const string AmtrackWebSync_RelatedProducts = "AmtrackWebSync.RelatedProducts";
		public const string AmtrackWebSync_Volumetrics = "AmtrackWebSync.Volumetrics";
		public const string AmtrackWebSync_ClientBranding = "AmtrackWebSync.ClientBranding";

		// Document Processor
		public const string DocumentProcessor_Service = "DocumentProcessor.Service";
		public const string DocumentProcessor_SalesorderProcessing = "DocumentProcessor.SalesorderProcessing";
		public const string DocumentProcessor_CreditNoteProcessing = "DocumentProcessor.CreditNoteProcessing";
		public const string DocumentProcessor_ClientLayoutUploadClient = "DocumentProcessor.ClientLayoutUploadClient";
		public const string DocumentProcessor_DashboardStateClient = "DocumentProcessor.DashboardStateClient";
		public const string DocumentProcessor_DocumentProcessorClient = "DocumentProcessor.DocumentProcessorClient";
		public const string DocumentProcessor_WMSDocumentReleaseProcessingClient = "DocumentProcessor.WMSDocumentReleaseProcessingClient";
		public const string DocumentProcessor_InventoryJournalClient = "DocumentProcessor.InventoryJournalClient";
		public const string DocumentProcessor_PODCollectionQueueProcessingClient = "DocumentProcessor._PODCollectionQueueProcessingClient";
		public const string DocumentProcessor_StockAdjustmentQueueProcessingClient = "DocumentProcessor.StockAdjustmentQueueProcessingClient";
		public const string DocumentProcessor_WarehouseTransferQueueProcessingClient = "DocumentProcessor.WarehouseTransferQueueProcessingClient";
		public const string DocumentProcessor_JobCardLeadtimeProcessingClient = "DocumentProcessor.JobCardLeadtimeProcessingClient";

		public const string DocumentProcessor_BrandingConversionALClient = "DocumentProcessor.BrandingConversionALClient";
		public const string DocumentProcessor_DocumentProcessController = "DocumentProcessor.DocumentProcessController";
		public const string DocumentProcessor_DocumentReleaseQueueClient = "DocumentProcessor.DocumentReleaseQueueClient";
		public const string DocumentProcessor_QueueProcessorClient = "DocumentProcessor.QueueProcessorClient.{0}";

		public const string DocumentProcessor_OrderProcessingQueueManager = "DocumentProcessor.OrderProcessingQueueManager";
		public const string DocumentProcessor_PaymentProcessor = "DocumentProcessor.PaymentProcessor";
		public const string DocumentProcessor_PickingSlipPrintProcessingClient = "DocumentProcessor.PickingSlipPrintProcessingClient";
		public const string DocumentProcessor_PickingSlipProcessingClient = "DocumentProcessor.PickingSlipProcessingClient";
		public const string DocumentProcessor_ReservePickingSlipProcessingClient = "DocumentProcessor.ReservePickingSlipProcessingClient";
		public const string DocumentProcessor_TurnoverCalculator = "DocumentProcessor.TurnoverCalculator";
		public const string DocumentProcessor_ShipmentProcessorClient = "DocumentProcessor.ShipmentProcessorClient";
		public const string DocumentProcessor_ShipmentProcessor = "DocumentProcessor.ShipmentProcessor";

		// Barcode
		public const string Barcode_Authorizer = "Barcode.Authorizer";
		public const string Barcode_Generator = "Barcode.Generator";
		public const string Barcode_Service = "Barcode.Service";

		// Integration Processor
		public const string IntegrationProcessor_BondStoreMessageQueueProcessor = "IntegrationProcessor.BondStoreMessageQueueProcessor";
		public const string IntegrationProcessor_DashboardUpdateMessageProcessor = "IntegrationProcessor.DashboardUpdateMessageProcessor";
		public const string IntegrationProcessor_InventoryVPQueueProcessor = "IntegrationProcessor.InventoryVPQueueProcessor";
		public const string IntegrationProcessor_ItemBalanceMessageQueueProcessor = "IntegrationProcessor.ItemBalanceMessageQueueProcessor";
		public const string IntegrationProcessor_MessageProcessorController = "IntegrationProcessor.MessageProcessorController";
		public const string IntegrationProcessor_MessageQueueProcessorController = "IntegrationProcessor.MessageQueueProcessorController";
		public const string IntegrationProcessor_ScaleDatabaseQueueProcessor = "IntegrationProcessor.ScaleDatabaseQueueProcessor";
		public const string IntegrationProcessor_Service = "IntegrationProcessor.Service";
		public const string IntegrationProcessor_SWADInfoProcessor = "IntegrationProcessor.SWADInfoProcessor";

		// Messages
		public const string Messages_MessageHandler = "Messages.MessageHandler";
		public const string Messages_MessageQueueHandler = "Messages.MessageQueueHandler";
		public const string Messages_Service = "Messages.Service";

		// Pastel Push
		public const string PastelPush_Service = "PastelPush.Service";
		public const string PastelPush_PastelContext = "PastelPush.PastelContext";
		public const string PastelPush_PastelReaderContext = "PastelPush.PastelReaderContext";
		public const string PastelPush_OrderStateSyncClient = "PastelPush.OrderStateSyncClient";
		public const string PastelPush_OrderStateSyncThresholdClient = "PastelPush.OrderStateSyncThresholdClient";
		public const string PastelPush_BatchClient = "PastelPush.BatchClient";

		// LayoutGenerator
		public const string LayoutGenerator_Service = "LayoutGenerator.Service";
		public const string LayoutGenerator_GeneratorQueue = "LayoutGenerator.GeneratorQueue";
		public const string LayoutGenerator_QueueItemProcessor = "LayoutGenerator.QueueItemProcessor";
		public const string LayoutGenerator_Tester = "LayoutGenerator.Tester";

		// MessageQueue
		public const string MessageQueue_Service = "MessageQueue.Service";
		public const string MessageQueue_MessageQueueClient = "MessageQueue_MessageQueueClient";

		// Notification
		public const string Notification_EntityNotifications = "Notification.EntityNotifications";
		public const string Notification_OpenHamperNotification = "Notification.OpenHamperNotification";
		public const string Notification_OpenOrderQueries = "Notification.OpenOrderQueries";
		public const string Notification_OrderCreditLimitReminders = "Notification.OrderCreditLimitReminders";
		public const string Notification_PaymentNotifications = "Notification.PaymentNotifications";
		public const string Notification_ProcessController = "Notification.ProcessController";
		public const string Notification_ProductStoreNotification = "Notification.ProductStoreNotification";
		public const string Notification_ReportMailer = "Notification.ReportMailer";
		public const string Notification_Reserves_StockArrived = "Notification.Reserves_StockArrived";
		public const string Notification_Reserves_Expired = "Notification.Reserves_Expired";
		public const string Notification_Reserves_Cancel = "Notification.Reserves_Cancel";
		public const string Notification_Reserves_Delete = "Notification.Reserves_Delete";
		public const string Notification_Reserves_OnlineOrders = "Notification.Reserves_OnlineOrders";
		public const string NotificationServices_Service = "NotificationServices.Service";
		public const string NotificationServices_40K = "NotificationServices.40K";
		public const string NotificationServices_AccountCreditLimitProcessingAndReminders = "NotificationServices.AccountCreditLimitProcessingAndReminders";
		public const string NotificationServices_BackgroundThreads = "NotificationServices.BackgroundThreads";
		public const string NotificationServices_BranchDeliveryMasterBatch = "NotificationServices.BranchDeliveryMasterBatch";
		public const string NotificationServices_BranchNoResponseNotification = "NotificationServices.BranchNoResponseNotification";
		public const string NotificationServices_CustomerBirthdayNotification = "NotificationServices.CustomerBirthdayNotification";
		public const string NotificationServices_CustomerTeirNotification = "NotificationServices.CustomerTeirNotification";
		public const string NotificationServices_DocumentProcessExceptions = "NotificationServices.DocumentProcessExceptions";
		public const string NotificationServices_EmailNotifications = "NotificationServices.EmailNotifications";
		public const string NotificationServices_JobCardNotifications = "NotificationServices.JobCardNotifications";
		public const string NotificationServices_NewStockOnArrivalNotifications = "NotificationServices.NewStockOnArrivalNotifications";
		public const string NotificationServices_StockAdjustmentNotifications = "NotificationServices.StockAdjustmentNotifications";
		public const string NotificationServices_ThirdPartyBranchReminders = "NotificationServices.ThirdPartyBranchReminders";
		public const string NotificationServices_InventoryTransactions = "NotificationServices.InventoryTransactions";
		public const string NotificationServices_DataSyncErrorNotification = "NotificationServices.DataSyncErrorNotification";
		public const string NotificationServices_EmbTbaNotification = "NotificationServices.EmbTbaNotification";

		//BranchDeliveries Services
		public const string BranchDelivery_Service = "BranchDelivery.Service";
		public const string BranchDelivery_FileImporter = "BranchDelivery.FileImporter";
		public const string BranchDelivery_FolderMonitor = "BranchDelivery.FolderMonitor";
		public const string BranchDelivery_MonitorController = "BranchDelivery.MonitorController";
		public const string BranchDelivery_DeliveryMonitor = "BranchDelivery.DeliveryMonitor";

		//Amtrack Mobile
		public const string AmtrackWebServices_AmtrackMobile = "Amtrack.WebServices.AmtrackMobile";
		public const string AmtrackWebServices_Amtrack = "Amtrack.WebServices.Amtrack";
		public const string AmtrackWebServices_CollectionPOD = "Amtrack.WebServices.CollectionPOD";
		public const string AmtrackWebServices_WidgetServices = "Amtrack.WebServices.WidgetServices";
		public const string AmtrackWebServices_OnlineOrdering = "Amtrack.WebServices.OnlineOrdering";
		public const string Amtrack_WebUI = "Amtrack.WebUI";

		//Amrod API
		public const string Amrod_API = "Amrod.API";

		//Amtrack API
		public const string Amtrack_API = "Amtrack.API";

		//Tool
		public const string AmtrackTools_ProductionTimeSheetsImport = "AmtrackTools.ProductionTimeSheetsImport";

		//Credits
		public const string Entities_CreditNoteController = "Entities.CreditNoteController";


		//Web.api
		public const string AmtrackWebApi_TimeTrackingController = "org.amrodgroup.amtrack.web.api_TimeTrackingController";

		// Order Controller
		public const string Amtrack_OrderTracking = "Amtrack.OrderTracking";
		//Messaging
		public const string AmtrackMessaging_MailService = "Amtrack.Messaging.Mail.Service";

		//Integration
		public const string Amtrack_Integration_HTTP_NucleusAPIClient = "Amtrack.Integration.HTTP.Clients.NucleusAPIClient";

		// AmtrackCache
		public const string Amtrack_Cache = "Amtrack.Cache";
	}
}
