using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class TurnoverTransactions1
    {
        public long TurnOverId { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public DateTime DateAdded { get; set; }
        public double TotalExcl { get; set; }
        public double TotalExclDiff { get; set; }
        public short Type { get; set; }
        public double GiftsExcl { get; set; }
        public double ClothingExcl { get; set; }
        public double BrandingExcl { get; set; }
        public double OtherExcl { get; set; }
        public long Flags { get; set; }
        public double CostGifts { get; set; }
        public double CostClothing { get; set; }
        public double CostBranding { get; set; }
        public double CostOther { get; set; }
        public double CostTotal { get; set; }
        public double? HeadwearExcl { get; set; }
        public double? CostHeadwearExcl { get; set; }
        public DateTime? AudDate { get; set; }
    }
}
