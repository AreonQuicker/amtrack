using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemBrandMatrix
    {
        public int FkItemId { get; set; }
        public int FkBrandId { get; set; }

        public StockBrands FkBrand { get; set; }
        public StockItemMaster FkItem { get; set; }
    }
}
