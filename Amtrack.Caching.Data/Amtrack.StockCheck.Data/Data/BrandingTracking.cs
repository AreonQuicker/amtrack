using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingTracking
    {
        public long Id { get; set; }
        public long? Fk { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string ItemCode { get; set; }
        public long UserId { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
    }
}
