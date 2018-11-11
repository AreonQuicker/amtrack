using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PalletContents
    {
        public Guid ContentId { get; set; }
        public string ItemCode { get; set; }
        public string ColourCode { get; set; }
        public string SizeCode { get; set; }
        public int Quantity { get; set; }
        public Guid PalletId { get; set; }
        public string BatchNumber { get; set; }
        public long Flags { get; set; }
        public int UnitsPerCarton { get; set; }
        public short Cartons { get; set; }

        public Pallets Pallet { get; set; }
    }
}
