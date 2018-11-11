using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandQuantities
    {
        public BrandQuantities()
        {
            BrandGroupQuantities = new HashSet<BrandGroupQuantities>();
            BrandItemQuantities = new HashSet<BrandItemQuantities>();
            BrandItemTypeQuantities = new HashSet<BrandItemTypeQuantities>();
        }

        public Guid QuantityId { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public short Days { get; set; }

        public ICollection<BrandGroupQuantities> BrandGroupQuantities { get; set; }
        public ICollection<BrandItemQuantities> BrandItemQuantities { get; set; }
        public ICollection<BrandItemTypeQuantities> BrandItemTypeQuantities { get; set; }
    }
}
