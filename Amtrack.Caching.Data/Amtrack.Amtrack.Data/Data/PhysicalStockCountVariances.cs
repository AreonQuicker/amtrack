using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PhysicalStockCountVariances
    {
        public int Id { get; set; }
        public int Variance { get; set; }
        public DateTime DateCounted { get; set; }
        public long CountedBy { get; set; }
        public short Warehouse { get; set; }
        public long Flags { get; set; }
        public DateTime DateAdjusted { get; set; }
        public int PhysicalStockCountId { get; set; }

        public PhysicalStockCounts PhysicalStockCount { get; set; }
    }
}
