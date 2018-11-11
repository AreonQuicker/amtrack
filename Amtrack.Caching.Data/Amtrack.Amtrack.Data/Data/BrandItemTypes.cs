using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandItemTypes
    {
        public BrandItemTypes()
        {
            BrandItemTypeQuantities = new HashSet<BrandItemTypeQuantities>();
        }

        public Guid ItemTypeId { get; set; }
        public string Name { get; set; }
        public string RegEx { get; set; }
        public short Priority { get; set; }

        public ICollection<BrandItemTypeQuantities> BrandItemTypeQuantities { get; set; }
    }
}
