using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemCosts
    {
        public int Id { get; set; }
        public int FkItemId { get; set; }
        public string CompanyCode { get; set; }
        public double AverageCost { get; set; }
        public double LatestCost { get; set; }
        public int Flags { get; set; }

        public StockItemMaster FkItem { get; set; }
    }
}
