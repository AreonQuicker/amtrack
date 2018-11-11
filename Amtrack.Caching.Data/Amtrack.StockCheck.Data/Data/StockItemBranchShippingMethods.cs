using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemBranchShippingMethods
    {
        public long Id { get; set; }
        public long FkBranchId { get; set; }
        public long FkShippingMethodId { get; set; }
        public int FkItemId { get; set; }
        public long Flags { get; set; }

        public StockItemMaster FkItem { get; set; }
    }
}
