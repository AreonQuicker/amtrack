using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingPositions
    {
        public BrandingPositions()
        {
            BrandingPositionDetail = new HashSet<BrandingPositionDetail>();
            BrandingPositionOptions = new HashSet<BrandingPositionOptions>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string ItemCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Flags { get; set; }
        public int PositionMultiplier { get; set; }

        public ICollection<BrandingPositionDetail> BrandingPositionDetail { get; set; }
        public ICollection<BrandingPositionOptions> BrandingPositionOptions { get; set; }
    }
}
