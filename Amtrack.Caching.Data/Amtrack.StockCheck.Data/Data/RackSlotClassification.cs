using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class RackSlotClassification
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ItemCode { get; set; }
        public int Type { get; set; }
        public int Ti { get; set; }
        public int Hi { get; set; }
        public int BoxesPerLocation { get; set; }
        public long UnitsPerLocation { get; set; }
        public decimal WeightKgperLocation { get; set; }
        public int CartonQty { get; set; }
        public int MezzLevel { get; set; }
        public bool IsChecked { get; set; }
    }
}
