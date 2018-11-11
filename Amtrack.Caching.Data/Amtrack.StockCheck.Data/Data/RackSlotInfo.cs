using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class RackSlotInfo
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public int SlotWidthCm { get; set; }
        public int SlotDepthCm { get; set; }
        public int SlotHeightCm { get; set; }
        public int PalletHeightCm { get; set; }
        public int ProdHeightCm { get; set; }
    }
}
