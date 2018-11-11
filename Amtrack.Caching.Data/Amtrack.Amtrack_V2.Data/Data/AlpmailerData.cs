using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AlpmailerData
    {
        public int Id { get; set; }
        public int FkMailerId { get; set; }
        public string CustomerCode { get; set; }
        public short Type { get; set; }
        public double GiftsSpend { get; set; }
        public double ClothingSpend { get; set; }
        public double HeadwearSpend { get; set; }
        public double BrandingSpend { get; set; }
        public double TotalSpend { get; set; }
        public double GiftsAlp { get; set; }
        public double ClothingAlp { get; set; }
        public double HeadwearAlp { get; set; }
        public double BrandingAlp { get; set; }
        public double TotalAlp { get; set; }
    }
}
