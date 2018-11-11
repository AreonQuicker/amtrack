using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Inventory
    {
        public Inventory()
        {
            InventoryStock = new HashSet<InventoryStock>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public WarehouseInventory WarehouseInventory { get; set; }
        public ICollection<InventoryStock> InventoryStock { get; set; }
    }
}
