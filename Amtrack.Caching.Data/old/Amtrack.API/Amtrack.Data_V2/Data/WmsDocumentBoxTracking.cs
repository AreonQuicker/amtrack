using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentBoxTracking
    {
        public long FkWmsDocumentBoxId { get; set; }
        public long FkWmsTrackingId { get; set; }

        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
        public WmsTracking FkWmsTracking { get; set; }
    }
}
