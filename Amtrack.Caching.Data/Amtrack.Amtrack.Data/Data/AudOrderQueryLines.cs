using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AudOrderQueryLines
    {
        public long Aid { get; set; }
        public DateTime Actiondate { get; set; }
        public long FkQueryId { get; set; }
        public string ItemCode { get; set; }
        public int TotalUnits { get; set; }
        public int UnitsRequested { get; set; }
        public string FkDocumentNumber { get; set; }
    }
}
