using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingPositionDetail
    {
        public int Id { get; set; }
        public int FkPositionId { get; set; }
        public string BrandingCode { get; set; }
        public string BrandingName { get; set; }
        public Guid BrandingGuid { get; set; }
        public int? BrandingMultiplier { get; set; }

        public BrandingPositions FkPosition { get; set; }
    }
}
