using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PalletConfirmLocationBatches
    {
        public PalletConfirmLocationBatches()
        {
            PalletConfirmLocationRaw = new HashSet<PalletConfirmLocationRaw>();
        }

        public Guid BatchId { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; }
        public int Flags { get; set; }
        public Guid FkWarehouseId { get; set; }

        public Warehouses FkWarehouse { get; set; }
        public ICollection<PalletConfirmLocationRaw> PalletConfirmLocationRaw { get; set; }
    }
}
