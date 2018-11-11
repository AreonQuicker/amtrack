using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WarehouseReplenishments
    {
        public Guid ReplenishmentId { get; set; }
        public int Sequence { get; set; }
        public Guid ReceivingWarehouseId { get; set; }
        public Guid ReplenismentWarehouseId { get; set; }
    }
}
