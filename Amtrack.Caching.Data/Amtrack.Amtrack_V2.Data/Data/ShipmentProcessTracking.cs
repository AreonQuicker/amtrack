using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ShipmentProcessTracking
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkShipmentId { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }

        public Shipments FkShipment { get; set; }
    }
}
