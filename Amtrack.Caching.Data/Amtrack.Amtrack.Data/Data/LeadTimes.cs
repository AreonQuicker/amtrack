using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LeadTimes
    {
        public int Id { get; set; }
        public int PrintDepartmentId { get; set; }
        public int Colors { get; set; }
        public double Quantity { get; set; }
        public int LeadTime { get; set; }
    }
}
