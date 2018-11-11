using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StatsFinancial
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public double TGifts { get; set; }
        public double TClothing { get; set; }
        public double TBranding { get; set; }
        public double NtGifts { get; set; }
        public double NtClothing { get; set; }
        public double NtBranding { get; set; }
        public double CosGifts { get; set; }
        public double CosClothing { get; set; }
        public double CosBranding { get; set; }
        public double THeadwear { get; set; }
        public double NtHeadwear { get; set; }
        public double CosHeadwear { get; set; }
    }
}
