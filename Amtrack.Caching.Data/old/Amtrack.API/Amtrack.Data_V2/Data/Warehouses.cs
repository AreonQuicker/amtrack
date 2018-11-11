using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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
