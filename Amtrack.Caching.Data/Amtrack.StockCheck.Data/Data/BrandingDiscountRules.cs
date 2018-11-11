using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingDiscountRules
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string BrandingCode { get; set; }
        public string ItemCode { get; set; }
        public int PositionNo { get; set; }
        public int? Scount { get; set; }
        public int UnitQty { get; set; }
        public int NumberOfColours { get; set; }
        public double? NewDiscount { get; set; }
        public double? NewPrice { get; set; }
        public string NewBrandingCode { get; set; }
        public string ProjectCode { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
    }
}
