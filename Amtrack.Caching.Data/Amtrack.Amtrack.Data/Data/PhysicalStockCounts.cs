using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PhysicalStockCounts
    {
        public PhysicalStockCounts()
        {
            PhysicalStockCountRecipients = new HashSet<PhysicalStockCountRecipients>();
            PhysicalStockCountVariances = new HashSet<PhysicalStockCountVariances>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public long Owner { get; set; }
        public string ItemCode { get; set; }
        public long Flags { get; set; }

        public ICollection<PhysicalStockCountRecipients> PhysicalStockCountRecipients { get; set; }
        public ICollection<PhysicalStockCountVariances> PhysicalStockCountVariances { get; set; }
    }
}
