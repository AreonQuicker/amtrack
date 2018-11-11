using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandItemQuantities
    {
        public Guid ItemQuantityId { get; set; }
        public Guid BrandDepartmentDepartmentId { get; set; }
        public Guid BrandItemItemId { get; set; }
        public Guid BrandQuantityQuantityId { get; set; }

        public BrandDepartments BrandDepartmentDepartment { get; set; }
        public BrandItems BrandItemItem { get; set; }
        public BrandQuantities BrandQuantityQuantity { get; set; }
    }
}
