using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ReportMailerSchedule
    {
        public int Id { get; set; }
        public int Reportid { get; set; }
        public byte Day { get; set; }
        public int? Frequency { get; set; }
        public DateTime? Runtime { get; set; }

        public ReportMailers Report { get; set; }
    }
}
