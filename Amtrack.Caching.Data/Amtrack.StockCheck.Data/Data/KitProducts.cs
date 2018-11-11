using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class KitProducts
    {
        public string MasterCode { get; set; }
        public string ItemCode { get; set; }
        public string ColourCode { get; set; }
        public int DisplaySequence { get; set; }
    }
}
