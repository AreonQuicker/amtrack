using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandItemCuring
    {
        public Guid ItemCuringId { get; set; }
        public Guid BrandMethodDepartmentId { get; set; }
        public Guid BrandItemItemId { get; set; }
        public Guid BrandCuringCuringId { get; set; }

        public BrandCuring BrandCuringCuring { get; set; }
        public BrandItems BrandItemItem { get; set; }
        public BrandDepartments BrandMethodDepartment { get; set; }
    }
}
