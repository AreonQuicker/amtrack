using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PhysicalStockCountRecipients
    {
        public int Id { get; set; }
        public long RecipientId { get; set; }
        public int PhysicalStockCountId { get; set; }

        public PhysicalStockCounts PhysicalStockCount { get; set; }
    }
}
