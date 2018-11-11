using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PalletMovementErrors
    {
        public long Id { get; set; }
        public string PalletCode { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }
        public string FkWarehouseCode { get; set; }
        public string FkUserTracking { get; set; }
        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
    }
}
