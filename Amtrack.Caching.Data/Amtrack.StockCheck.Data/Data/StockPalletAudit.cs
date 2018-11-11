using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockPalletAudit
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public string StoreCode { get; set; }
        public DateTime Created { get; set; }
        public int AdjustInWarehouseLevel { get; set; }
        public int AdjustInLocatonLevel { get; set; }
        public int AdjustToBePlacedLevel { get; set; }
        public int AdjustInTransitTo { get; set; }
        public int AdjustInTransitFrom { get; set; }
        public int? AdjustInQclevel { get; set; }
        public string AdjustDocumentNumber { get; set; }
        public int? AdjustPicking { get; set; }
    }
}
