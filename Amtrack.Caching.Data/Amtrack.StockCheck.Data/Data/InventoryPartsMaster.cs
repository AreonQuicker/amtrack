using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventoryPartsMaster
    {
        public InventoryPartsMaster()
        {
            InventoryPart = new HashSet<InventoryPart>();
            InventorySupplement = new HashSet<InventorySupplement>();
        }

        public int Id { get; set; }
        public int? FkSetId { get; set; }
        public string Lookup { get; set; }
        public string PartBase { get; set; }
        public long Flags { get; set; }

        public InventorySet FkSet { get; set; }
        public ICollection<InventoryPart> InventoryPart { get; set; }
        public ICollection<InventorySupplement> InventorySupplement { get; set; }
    }
}
