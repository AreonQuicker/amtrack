using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class RackSlotClassificationTracking
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public long FkRackSlotClassificationId { get; set; }
        public long FkUserId { get; set; }
        public string ItemCode { get; set; }
        public int OldType { get; set; }
        public int OldTi { get; set; }
        public int OldHi { get; set; }
        public int OldBoxesPerLocation { get; set; }
        public long OldUnitsPerLocation { get; set; }
        public decimal OldWeightKgperLocation { get; set; }
        public int OldCartonQty { get; set; }
        public int OldMezzLevel { get; set; }
        public int NewType { get; set; }
        public int NewTi { get; set; }
        public int NewHi { get; set; }
        public int NewBoxesPerLocation { get; set; }
        public long NewUnitsPerLocation { get; set; }
        public decimal NewWeightKgperLocation { get; set; }
        public int NewCartonQty { get; set; }
        public int NewMezzLevel { get; set; }
    }
}
