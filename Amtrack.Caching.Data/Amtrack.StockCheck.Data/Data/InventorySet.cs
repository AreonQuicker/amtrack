using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventorySet
    {
        public InventorySet()
        {
            InventoryPart = new HashSet<InventoryPart>();
            InventoryPartsMaster = new HashSet<InventoryPartsMaster>();
            InventorySupplement = new HashSet<InventorySupplement>();
        }

        public int Id { get; set; }
        public string Lookup { get; set; }
        public long Flags { get; set; }

        public ICollection<InventoryPart> InventoryPart { get; set; }
        public ICollection<InventoryPartsMaster> InventoryPartsMaster { get; set; }
        public ICollection<InventorySupplement> InventorySupplement { get; set; }
    }
}
