using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WdbActiveOrders
    {
        public string DocumentNumber { get; set; }
        public long OrderId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string CustomerReference { get; set; }
        public DateTime DocumentDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string DocumentStatusText { get; set; }
        public long DocumentStatus { get; set; }
        public string FirstStockLine { get; set; }
        public int LineCount { get; set; }
        public double TotalExcl { get; set; }
        public double TotalIncl { get; set; }
        public string CurrentWarehouse { get; set; }
        public string DestinationWarehouse { get; set; }
        public string CurrentWarehouseName { get; set; }
        public string DestinationWarehouseName { get; set; }
        public int? TotalBoxes { get; set; }
        public long? DocumentFlags { get; set; }
        public long? DocumentExtraFlags { get; set; }
        public bool? IsDeliveryOrder { get; set; }
        public bool? IsPartOfDelivery { get; set; }
        public int? DeliveryStatus { get; set; }
        public string DeliveryStatusText { get; set; }
        public string Brand { get; set; }
    }
}
