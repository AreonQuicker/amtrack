using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PalletConfirmLocationMovements
    {
        public Guid MovementId { get; set; }
        public Guid FkPalletId { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }
        public Guid? FromId { get; set; }
        public Guid? ToId { get; set; }

        public Pallets FkPallet { get; set; }
    }
}
