using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Pallets
    {
        public Pallets()
        {
            DocumentPallet = new HashSet<DocumentPallet>();
            PalletConfirmLocationExceptions = new HashSet<PalletConfirmLocationExceptions>();
            PalletConfirmLocationMovements = new HashSet<PalletConfirmLocationMovements>();
            PalletContents = new HashSet<PalletContents>();
            SuggestedReOrderPallets = new HashSet<SuggestedReOrderPallets>();
            WarehouseStockStorageMovements = new HashSet<WarehouseStockStorageMovements>();
        }

        public Guid PalletId { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public int CurrentStatus { get; set; }
        public Guid? WarehouseLocatonWarehouseLocationId { get; set; }
        public Guid? ShippingDocumentId { get; set; }
        public long Flags { get; set; }
        public Guid? FkWarehouseId { get; set; }

        public Warehouses FkWarehouse { get; set; }
        public WarehouseLocations WarehouseLocatonWarehouseLocation { get; set; }
        public ICollection<DocumentPallet> DocumentPallet { get; set; }
        public ICollection<PalletConfirmLocationExceptions> PalletConfirmLocationExceptions { get; set; }
        public ICollection<PalletConfirmLocationMovements> PalletConfirmLocationMovements { get; set; }
        public ICollection<PalletContents> PalletContents { get; set; }
        public ICollection<SuggestedReOrderPallets> SuggestedReOrderPallets { get; set; }
        public ICollection<WarehouseStockStorageMovements> WarehouseStockStorageMovements { get; set; }
    }
}
