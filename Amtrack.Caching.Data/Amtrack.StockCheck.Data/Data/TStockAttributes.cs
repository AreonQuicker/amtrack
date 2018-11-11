using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class TStockAttributes
    {
        public string BaseItemCode { get; set; }
        public string ItemCode { get; set; }
        public string Size { get; set; }
        public string CataloguePageNumber { get; set; }
        public string QuantityPerCarton { get; set; }
        public string CartonWeight { get; set; }
        public string CartonDimenstions { get; set; }
        public string W { get; set; }
        public string H { get; set; }
        public string D { get; set; }
        public string HalfChest { get; set; }
        public string HalfBottom { get; set; }
        public string Cbl { get; set; }
        public string SleeveLength { get; set; }
    }
}
