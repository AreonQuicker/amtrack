using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingExceptions
    {
        public string ItemCode { get; set; }
        public Guid BrandingGuid { get; set; }
        public int Colours { get; set; }
    }
}
