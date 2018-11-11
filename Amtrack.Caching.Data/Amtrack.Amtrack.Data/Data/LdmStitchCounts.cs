using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmStitchCounts
    {
        public int Id { get; set; }
        public int FkDepartmentId { get; set; }
        public int QtyMin { get; set; }
        public int QtyMax { get; set; }
        public int Leadtime { get; set; }

        public LdmDepartments FkDepartment { get; set; }
    }
}
