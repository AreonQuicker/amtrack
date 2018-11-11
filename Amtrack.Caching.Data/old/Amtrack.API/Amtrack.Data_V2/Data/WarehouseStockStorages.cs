using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WarehouseStockStorages
    {
        public WarehouseStockStorages()
        {
            WarehouseStockStorageMovements = new HashSet<WarehouseStockStorageMovements>();
        }

        public Guid StorageId { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public long Flags { get; set; }
        public Guid FkWarehouseId { get; set; }
        public bool Qc { get; set; }

        public Warehouses FkWarehouse { get; set; }
        public ICollection<WarehouseStockStorageMovements> WarehouseStockStorageMovements { get; set; }
    }
}
