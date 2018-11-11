using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BrandingConversionDatas
    {
        public long Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string DocumentNumber { get; set; }
        public string ItemCode { get; set; }
        public double StockTotal { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanCodeOverride { get; set; }
        public short ItemCount { get; set; }
        public short BrandingCount { get; set; }
        public long Flags { get; set; }
        public short DocumentVersion { get; set; }
        public string LinkDocumentNumber { get; set; }
        public double BrandingTotal { get; set; }
        public string BrandingCode { get; set; }
        public DateTime? Created { get; set; }
    }
}
