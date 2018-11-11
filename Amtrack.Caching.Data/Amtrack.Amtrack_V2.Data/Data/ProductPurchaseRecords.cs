using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ProductPurchaseRecords
    {
        public Guid PurchaseId { get; set; }
        public string DocumentNumber { get; set; }
        public double DollarCost { get; set; }
        public string ItemCode { get; set; }
    }
}
