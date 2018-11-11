using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandItems
    {
        public BrandItems()
        {
            BrandItemCuring = new HashSet<BrandItemCuring>();
            BrandItemQuantities = new HashSet<BrandItemQuantities>();
        }

        public Guid ItemId { get; set; }
        public string BaseCode { get; set; }

        public ICollection<BrandItemCuring> BrandItemCuring { get; set; }
        public ICollection<BrandItemQuantities> BrandItemQuantities { get; set; }
    }
}
