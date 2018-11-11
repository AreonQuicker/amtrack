using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PalletConfirmLocationExceptions
    {
        public Guid ExceptionId { get; set; }
        public Guid FkPalletId { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }

        public Pallets FkPallet { get; set; }
    }
}
