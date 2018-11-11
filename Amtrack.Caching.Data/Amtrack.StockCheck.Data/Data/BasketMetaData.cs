using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BasketMetaData
    {
        public long LocationId { get; set; }
        public string LocationName { get; set; }
        public double? BasketCube { get; set; }
        public double? BasketDimsW { get; set; }
        public double? BasketDimsH { get; set; }
        public double? BasketDimsD { get; set; }
        public string BasketSplit { get; set; }
        public double? BasketSplitValue { get; set; }
        public string BasketStockItem { get; set; }
        public double? BasketLevelTrig { get; set; }
        public int? BasketCurrentLevel { get; set; }
        public double? BasketCurrentLevelPc { get; set; }
        public double? BasketMaxLevel { get; set; }
        public int? BasketReplenUnits { get; set; }
        public int? BasketReplenBoxes { get; set; }
        public byte BasketReplenStatus { get; set; }
    }
}
