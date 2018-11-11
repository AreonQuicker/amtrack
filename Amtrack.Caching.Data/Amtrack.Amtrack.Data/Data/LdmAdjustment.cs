using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmAdjustment
    {
        public int Id { get; set; }
        public int? FkDepartmentId { get; set; }
        public int? FkGroupId { get; set; }
        public int Adjustment { get; set; }
        public int Override { get; set; }
        public int Flags { get; set; }

        public LdmDepartments FkDepartment { get; set; }
        public LdmGroups FkGroup { get; set; }
    }
}
