using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StSales
    {
        public DateTime Date { get; set; }
        public int BulkOrderCount { get; set; }
        public int SampleOrderCount { get; set; }
        public double BulkOrderTotalExcl { get; set; }
        public double SampleOrderTotalExcl { get; set; }
        public int BulkCreditCount { get; set; }
        public int SampleCreditCount { get; set; }
        public double BulkCreditTotalExcl { get; set; }
        public double SampleCreditTotalExcl { get; set; }
        public int JobCardsCreated { get; set; }
        public int UniqueCustomerCount { get; set; }
        public int UnitsSoldCount { get; set; }
        public int UnitsBrandedCount { get; set; }
        public double DiscGiftSalesExcl { get; set; }
        public double DiscClothingSalesExcl { get; set; }
        public int UniqueSku { get; set; }
    }
}
