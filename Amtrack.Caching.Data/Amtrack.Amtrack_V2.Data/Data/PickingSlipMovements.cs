using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PickingSlipMovements
    {
        public Guid MovementId { get; set; }
        public DateTime MovementDate { get; set; }
        public short MovementType { get; set; }
        public string MovementKey { get; set; }
        public Guid FkPickingSlipId { get; set; }
        public int FkActionerId { get; set; }
        public int? FkReceiverId { get; set; }

        public HistoryContributor FkActioner { get; set; }
        public PickingSlips FkPickingSlip { get; set; }
        public HistoryContributor FkReceiver { get; set; }
    }
}
