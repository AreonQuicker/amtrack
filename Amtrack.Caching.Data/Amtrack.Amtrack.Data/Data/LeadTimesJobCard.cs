using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LeadTimesJobCard
    {
        public long JobCardId { get; set; }
        public long PrintProcessId { get; set; }
        public int? LeadTime { get; set; }
        public long AssignedBy { get; set; }
        public int Flag { get; set; }
        public string Notes { get; set; }
        public DateTime? Created { get; set; }

        public User AssignedByNavigation { get; set; }
        public JobCard JobCard { get; set; }
        public PrintProcess PrintProcess { get; set; }
    }
}
