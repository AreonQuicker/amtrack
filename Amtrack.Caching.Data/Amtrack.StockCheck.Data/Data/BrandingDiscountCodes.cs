using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingDiscountCodes
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string BrandingCode { get; set; }
        public string ProductCode { get; set; }
        public string Comment { get; set; }
        public bool ApplyRule { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
    }
}
