using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WarehouseStockStorageMovements
    {
        public Guid MovementId { get; set; }
        public DateTime MovementDate { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public short Type { get; set; }
        public int FkHistoryId { get; set; }
        public Guid? FkPalletId { get; set; }
        public Guid FkStockStorageId { get; set; }
        public long? FkExternalDocumentId { get; set; }

        public HistoryContributor FkHistory { get; set; }
        public Pallets FkPallet { get; set; }
        public WarehouseStockStorages FkStockStorage { get; set; }
    }
}
