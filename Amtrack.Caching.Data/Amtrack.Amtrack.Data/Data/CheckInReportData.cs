using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CheckInReportData
    {
        public long Id { get; set; }
        public string DocumentNumber { get; set; }
        public int DocumentStatus { get; set; }
        public int DocuementType { get; set; }
        public DateTime DateTime { get; set; }
    }
}
