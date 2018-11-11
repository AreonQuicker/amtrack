using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandCuring
    {
        public BrandCuring()
        {
            BrandGroupCuring = new HashSet<BrandGroupCuring>();
            BrandItemCuring = new HashSet<BrandItemCuring>();
        }

        public Guid CuringId { get; set; }
        public short Days { get; set; }

        public ICollection<BrandGroupCuring> BrandGroupCuring { get; set; }
        public ICollection<BrandItemCuring> BrandItemCuring { get; set; }
    }
}
