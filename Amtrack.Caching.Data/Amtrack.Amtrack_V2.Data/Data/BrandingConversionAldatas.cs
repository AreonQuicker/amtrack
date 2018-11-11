using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BrandingConversionAldatas
    {
        public long Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanCodeOverride { get; set; }
        public string ItemCode { get; set; }
        public string BrandingCode { get; set; }
        public int StockQuantity { get; set; }
        public int BrandingQuantity { get; set; }
        public short NumOfPositions { get; set; }
        public string LinkDocumentNumber { get; set; }
        public long Flags { get; set; }
        public int TotalBrandingUnits { get; set; }
        public DateTime? AudTimestamp { get; set; }
    }
}
