using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ShipmentDetail
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkWmsDocumentBoxId { get; set; }
        public int FkShipmentId { get; set; }
        public double BoxValue { get; set; }
        public double BoxSize { get; set; }

        public Shipments FkShipment { get; set; }
        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
    }
}
