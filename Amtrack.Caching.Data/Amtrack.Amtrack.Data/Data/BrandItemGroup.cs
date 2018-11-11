using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandItemGroup
    {
        public BrandItemGroup()
        {
            BrandGroupCuring = new HashSet<BrandGroupCuring>();
            BrandGroupItem = new HashSet<BrandGroupItem>();
            BrandGroupQuantities = new HashSet<BrandGroupQuantities>();
        }

        public Guid GroupId { get; set; }
        public string Name { get; set; }

        public ICollection<BrandGroupCuring> BrandGroupCuring { get; set; }
        public ICollection<BrandGroupItem> BrandGroupItem { get; set; }
        public ICollection<BrandGroupQuantities> BrandGroupQuantities { get; set; }
    }
}
