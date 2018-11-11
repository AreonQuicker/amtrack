using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingOptioncolourRestrictions
    {
        public int Id { get; set; }
        public int FkOptionId { get; set; }
        public string Colour { get; set; }
        public int Flags { get; set; }

        public BrandingPositionOptions FkOption { get; set; }
    }
}
