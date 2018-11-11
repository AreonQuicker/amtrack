using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandGroupQuantities
    {
        public Guid GroupQuantityId { get; set; }
        public Guid BrandMethodDepartmentId { get; set; }
        public Guid BrandItemGroupGroupId { get; set; }
        public Guid BrandQuantityQuantityId { get; set; }

        public BrandItemGroup BrandItemGroupGroup { get; set; }
        public BrandDepartments BrandMethodDepartment { get; set; }
        public BrandQuantities BrandQuantityQuantity { get; set; }
    }
}
