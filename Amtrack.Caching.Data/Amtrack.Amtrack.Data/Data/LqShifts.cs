using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqShifts
    {
        public LqShifts()
        {
            LqQueueAccess = new HashSet<LqQueueAccess>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public long Flags { get; set; }

        public ICollection<LqQueueAccess> LqQueueAccess { get; set; }
    }
}
