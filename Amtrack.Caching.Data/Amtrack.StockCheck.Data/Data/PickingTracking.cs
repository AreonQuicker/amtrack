using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class PickingTracking
    {
        public long Id { get; set; }
        public DateTime AdtionDate { get; set; }
        public string WarehouseCode { get; set; }
        public string ItemCode { get; set; }
        public int Adjust { get; set; }
        public bool Qc { get; set; }
        public string AdjustReason { get; set; }
        public long? AmtrackUserId { get; set; }
    }
}
