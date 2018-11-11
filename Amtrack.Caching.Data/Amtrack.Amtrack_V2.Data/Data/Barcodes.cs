using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Barcodes
    {
        public Guid BarcodeId { get; set; }
        public string Code { get; set; }
        public bool Used { get; set; }
    }
}
