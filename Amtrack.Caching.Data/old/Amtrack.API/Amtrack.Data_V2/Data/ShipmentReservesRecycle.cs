using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ShipmentReservesRecycle
    {
        public int Id { get; set; }
        public int FkShipmentId { get; set; }
        public string DocumentNumber { get; set; }
        public string InterBranchStockReservationDocumentNumber { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public Shipments FkShipment { get; set; }
    }
}
