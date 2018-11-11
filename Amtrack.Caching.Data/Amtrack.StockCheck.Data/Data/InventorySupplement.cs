using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventorySupplement
    {
        public int Id { get; set; }
        public int? FkMasterId { get; set; }
        public int? FkSetId { get; set; }
        public string Supplement { get; set; }
        public long Flags { get; set; }

        public InventoryPartsMaster FkMaster { get; set; }
        public InventorySet FkSet { get; set; }
    }
}
