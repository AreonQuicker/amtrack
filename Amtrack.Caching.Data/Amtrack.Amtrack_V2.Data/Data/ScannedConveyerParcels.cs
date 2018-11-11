using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ScannedConveyerParcels
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Barcode { get; set; }
        public string Error { get; set; }
        public string Document { get; set; }
    }
}
