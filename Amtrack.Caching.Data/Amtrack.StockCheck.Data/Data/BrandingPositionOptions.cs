using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BrandingPositionOptions
    {
        public BrandingPositionOptions()
        {
            BrandingOptioncolourRestrictions = new HashSet<BrandingOptioncolourRestrictions>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkPositionId { get; set; }
        public int DisplayIndex { get; set; }
        public Guid BrandingGuid { get; set; }
        public int? NumberOfColours { get; set; }
        public double SizeW { get; set; }
        public double SizeH { get; set; }
        public int Flags { get; set; }
        public string Comment { get; set; }
        public bool IsLogo24Position { get; set; }
        public int MaxBrandQuantity { get; set; }
        public int MinBrandQuantity { get; set; }

        public BrandingPositions FkPosition { get; set; }
        public ICollection<BrandingOptioncolourRestrictions> BrandingOptioncolourRestrictions { get; set; }
    }
}
