using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StockCheckTracking
    {
        public long StockCheckTrackingId { get; set; }
        public string CustomerCode { get; set; }
        public string ProductCode { get; set; }
        public DateTime ActionDate { get; set; }
        public long? DataSize { get; set; }
    }
}
