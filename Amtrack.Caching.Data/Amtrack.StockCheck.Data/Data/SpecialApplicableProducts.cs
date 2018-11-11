using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class SpecialApplicableProducts
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public int FkSpecialId { get; set; }

        public Specials FkSpecial { get; set; }
    }
}
