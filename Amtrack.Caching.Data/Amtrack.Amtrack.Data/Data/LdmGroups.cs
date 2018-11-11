using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmGroups
    {
        public LdmGroups()
        {
            LdmAdjustment = new HashSet<LdmAdjustment>();
            LdmGroupItems = new HashSet<LdmGroupItems>();
            LdmGroupLeadtimes = new HashSet<LdmGroupLeadtimes>();
        }

        public int Id { get; set; }
        public int FkDepartmentId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public string FltPrefix { get; set; }
        public int? FltInventoryType { get; set; }
        public string FltPrintCode { get; set; }
        public long Flags { get; set; }

        public LdmDepartments FkDepartment { get; set; }
        public ICollection<LdmAdjustment> LdmAdjustment { get; set; }
        public ICollection<LdmGroupItems> LdmGroupItems { get; set; }
        public ICollection<LdmGroupLeadtimes> LdmGroupLeadtimes { get; set; }
    }
}
