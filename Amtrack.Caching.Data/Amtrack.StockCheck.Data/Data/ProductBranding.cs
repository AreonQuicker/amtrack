using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class ProductBranding
    {
        public string ProductCode { get; set; }
        public Guid BrandingGuid { get; set; }
        public int Sequence { get; set; }
    }
}
