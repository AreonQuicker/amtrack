using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class MSchedules
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkMessage { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public long ExpiredTime { get; set; }
        public string DayOfWeek { get; set; }
        public string MonthDay { get; set; }
        public long? IntervalTimespan { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }

        public MMessage FkMessageNavigation { get; set; }
    }
}
