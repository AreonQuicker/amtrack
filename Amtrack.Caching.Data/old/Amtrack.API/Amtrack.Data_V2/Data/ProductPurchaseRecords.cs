using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ProductPurchaseRecords
    {
        public Guid PurchaseId { get; set; }
        public string DocumentNumber { get; set; }
        public double DollarCost { get; set; }
        public string ItemCode { get; set; }
    }
}
