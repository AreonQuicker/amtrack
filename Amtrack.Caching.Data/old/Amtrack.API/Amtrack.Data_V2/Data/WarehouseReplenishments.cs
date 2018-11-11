using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WarehouseReplenishments
    {
        public Guid ReplenishmentId { get; set; }
        public int Sequence { get; set; }
        public Guid ReceivingWarehouseId { get; set; }
        public Guid ReplenismentWarehouseId { get; set; }
    }
}
