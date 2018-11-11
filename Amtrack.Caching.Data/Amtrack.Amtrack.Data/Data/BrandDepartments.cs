using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandDepartments
    {
        public BrandDepartments()
        {
            BrandGroupCuring = new HashSet<BrandGroupCuring>();
            BrandGroupQuantities = new HashSet<BrandGroupQuantities>();
            BrandItemCuring = new HashSet<BrandItemCuring>();
            BrandItemQuantities = new HashSet<BrandItemQuantities>();
            BrandItemTypeQuantities = new HashSet<BrandItemTypeQuantities>();
        }

        public Guid DepartmentId { get; set; }
        public string Name { get; set; }

        public ICollection<BrandGroupCuring> BrandGroupCuring { get; set; }
        public ICollection<BrandGroupQuantities> BrandGroupQuantities { get; set; }
        public ICollection<BrandItemCuring> BrandItemCuring { get; set; }
        public ICollection<BrandItemQuantities> BrandItemQuantities { get; set; }
        public ICollection<BrandItemTypeQuantities> BrandItemTypeQuantities { get; set; }
    }
}
