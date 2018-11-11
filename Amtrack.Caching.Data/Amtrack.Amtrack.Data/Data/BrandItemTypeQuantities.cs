using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandItemTypeQuantities
    {
        public Guid BrandMethodId { get; set; }
        public Guid BrandItemTypeId { get; set; }
        public Guid ItemTypeQuantityId { get; set; }
        public Guid BrandQuantityQuantityId { get; set; }

        public BrandItemTypes BrandItemType { get; set; }
        public BrandDepartments BrandMethod { get; set; }
        public BrandQuantities BrandQuantityQuantity { get; set; }
    }
}
