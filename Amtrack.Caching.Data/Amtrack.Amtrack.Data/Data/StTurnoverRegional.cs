using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StTurnoverRegional
    {
        public DateTime Date { get; set; }
        public double GiftsExcl { get; set; }
        public double ClothingExcl { get; set; }
        public double HeadwearExcl { get; set; }
        public double BrandingExcl { get; set; }
        public double CostGiftsExcl { get; set; }
        public double CostClothingExcl { get; set; }
        public double CostHeadwearExcl { get; set; }
        public double NetGiftsExcl { get; set; }
        public double NetClothingExcl { get; set; }
        public double NetHeadwearExcl { get; set; }
        public double NetBrandingExcl { get; set; }
        public int Region { get; set; }
        public string Province { get; set; }
    }
}
