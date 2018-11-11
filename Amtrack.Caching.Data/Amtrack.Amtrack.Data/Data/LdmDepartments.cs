using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmDepartments
    {
        public LdmDepartments()
        {
            LdmAdjustment = new HashSet<LdmAdjustment>();
            LdmAdjustmentTrackings = new HashSet<LdmAdjustmentTrackings>();
            LdmGroups = new HashSet<LdmGroups>();
            LdmPersonalization = new HashSet<LdmPersonalization>();
            LdmStitchCounts = new HashSet<LdmStitchCounts>();
        }

        public int Id { get; set; }
        public long FkPrintDepartmentId { get; set; }
        public long Flags { get; set; }

        public PrintDepartment FkPrintDepartment { get; set; }
        public ICollection<LdmAdjustment> LdmAdjustment { get; set; }
        public ICollection<LdmAdjustmentTrackings> LdmAdjustmentTrackings { get; set; }
        public ICollection<LdmGroups> LdmGroups { get; set; }
        public ICollection<LdmPersonalization> LdmPersonalization { get; set; }
        public ICollection<LdmStitchCounts> LdmStitchCounts { get; set; }
    }
}
