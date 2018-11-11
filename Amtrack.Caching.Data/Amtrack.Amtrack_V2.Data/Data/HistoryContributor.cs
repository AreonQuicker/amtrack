using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class HistoryContributor
    {
        public HistoryContributor()
        {
            AsmDeviceNotes = new HashSet<AsmDeviceNotes>();
            DocumentHistory = new HashSet<DocumentHistory>();
            PalletConfirmLocationRaw = new HashSet<PalletConfirmLocationRaw>();
            PickingSlipMovementsFkActioner = new HashSet<PickingSlipMovements>();
            PickingSlipMovementsFkReceiver = new HashSet<PickingSlipMovements>();
            WarehouseStockStorageMovements = new HashSet<WarehouseStockStorageMovements>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }
        public string Identifier { get; set; }
        public long Flags { get; set; }

        public ICollection<AsmDeviceNotes> AsmDeviceNotes { get; set; }
        public ICollection<DocumentHistory> DocumentHistory { get; set; }
        public ICollection<PalletConfirmLocationRaw> PalletConfirmLocationRaw { get; set; }
        public ICollection<PickingSlipMovements> PickingSlipMovementsFkActioner { get; set; }
        public ICollection<PickingSlipMovements> PickingSlipMovementsFkReceiver { get; set; }
        public ICollection<WarehouseStockStorageMovements> WarehouseStockStorageMovements { get; set; }
    }
}
