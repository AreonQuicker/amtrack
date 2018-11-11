using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardDates
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public long FkJobCardId { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateCleared { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? LeadTime { get; set; }
        public DateTime? DueDate { get; set; }
        public int? ProductionLeadTime { get; set; }
        public DateTime? ProductionDueDate { get; set; }
    }
}
