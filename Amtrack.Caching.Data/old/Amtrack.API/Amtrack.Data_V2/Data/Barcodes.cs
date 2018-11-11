using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Barcodes
    {
        public Guid BarcodeId { get; set; }
        public string Code { get; set; }
        public bool Used { get; set; }
    }
}
