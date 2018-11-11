using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class SpecialFreeBrandingCodesLookUp
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string BrandingCode { get; set; }
        public string ReplacementCode { get; set; }
        public int Flags { get; set; }
    }
}
