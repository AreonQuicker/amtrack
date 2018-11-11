using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WarehouseMinimumReorders
    {
        public Guid ReorderId { get; set; }
        public Guid WarehouseId { get; set; }
        public string ItemCode { get; set; }
        public long ReorderLevel { get; set; }
    }
}
