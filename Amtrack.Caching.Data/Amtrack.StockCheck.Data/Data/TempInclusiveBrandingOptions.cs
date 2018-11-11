using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class TempInclusiveBrandingOptions
    {
        public long ItemMasterId { get; set; }
        public string BaseCode { get; set; }
        public bool Sp { get; set; }
        public bool Emb { get; set; }
        public bool Lg { get; set; }
        public bool Boss { get; set; }
    }
}
