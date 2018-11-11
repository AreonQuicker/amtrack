using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmAdjustmentTrackings
    {
        public long Id { get; set; }
        public long FkUserId { get; set; }
        public int FkDepartmentId { get; set; }
        public int Adjustment { get; set; }
        public int Override { get; set; }
        public DateTime Created { get; set; }

        public LdmDepartments FkDepartment { get; set; }
        public User FkUser { get; set; }
    }
}
