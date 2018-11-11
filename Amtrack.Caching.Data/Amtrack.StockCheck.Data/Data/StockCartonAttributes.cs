using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockCartonAttributes
    {
        public string BaseItemCode { get; set; }
        public string ItemCode { get; set; }
        public int? CataloguePageNumber { get; set; }
        public int? QuantityPerCarton { get; set; }
        public double? CartonWeight { get; set; }
        public string CartonDimensions { get; set; }
        public double? DimWidth { get; set; }
        public double? DimHeight { get; set; }
        public double? DimDepth { get; set; }
    }
}
