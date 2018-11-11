using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentsSkippedProcessing
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public int Type { get; set; }
        public bool Processed { get; set; }
        public DateTime? StartProcessDate { get; set; }
        public DateTime? DateProcessed { get; set; }
        public bool? DashboardProcessed { get; set; }
        public DateTime? DateDashboardProcessed { get; set; }
    }
}
