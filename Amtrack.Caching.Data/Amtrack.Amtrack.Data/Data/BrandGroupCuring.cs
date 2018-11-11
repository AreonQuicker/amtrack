using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandGroupCuring
    {
        public Guid GroupCurintId { get; set; }
        public Guid BrandMethodDepartmentId { get; set; }
        public Guid BrandItemGroupGroupId { get; set; }
        public Guid BrandCuringCuringId { get; set; }

        public BrandCuring BrandCuringCuring { get; set; }
        public BrandItemGroup BrandItemGroupGroup { get; set; }
        public BrandDepartments BrandMethodDepartment { get; set; }
    }
}
