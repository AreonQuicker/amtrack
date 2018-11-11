using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WarehouseLocations
    {
        public WarehouseLocations()
        {
            Pallets = new HashSet<Pallets>();
        }

        public Guid WarehouseLocationId { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int Isle { get; set; }
        public string Bay { get; set; }
        public string Floor { get; set; }
        public short Capacity { get; set; }
        public short Type { get; set; }
        public Guid WarehouseWarehouseId { get; set; }
        public int Flags { get; set; }

        public Warehouses WarehouseWarehouse { get; set; }
        public ICollection<Pallets> Pallets { get; set; }
    }
}
