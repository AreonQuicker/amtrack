using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class SpecialsBrandingDetails
    {
        public int Id { get; set; }
        public int FkSpecialId { get; set; }
        public short BrandingPositionType { get; set; }
        public string BrandingMethod { get; set; }
        public string BrandingReplacementCode { get; set; }
        public short? NumberOfColours { get; set; }
        public int? MinQuantity { get; set; }
        public double BrandingPrice { get; set; }
        public int Flags { get; set; }

        public Specials FkSpecial { get; set; }
    }
}
