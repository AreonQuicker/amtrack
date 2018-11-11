using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Warehouses
    {
        public Warehouses()
        {
            PalletConfirmLocationBatches = new HashSet<PalletConfirmLocationBatches>();
            Pallets = new HashSet<Pallets>();
            WarehouseLocations = new HashSet<WarehouseLocations>();
            WarehouseNotifications = new HashSet<WarehouseNotifications>();
            WarehouseStockStorages = new HashSet<WarehouseStockStorages>();
        }

        public Guid WarehouseId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Flags { get; set; }

        public ICollection<PalletConfirmLocationBatches> PalletConfirmLocationBatches { get; set; }
        public ICollection<Pallets> Pallets { get; set; }
        public ICollection<WarehouseLocations> WarehouseLocations { get; set; }
        public ICollection<WarehouseNotifications> WarehouseNotifications { get; set; }
        public ICollection<WarehouseStockStorages> WarehouseStockStorages { get; set; }
    }
}
