using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqQueueAccess
    {
        public long Id { get; set; }
        public string Queue { get; set; }
        public DateTime AccessDate { get; set; }
        public long FkAccessedById { get; set; }
        public long FkForUserId { get; set; }
        public int FkShiftId { get; set; }
        public bool Active { get; set; }
        public long Flags { get; set; }

        public User FkAccessedBy { get; set; }
        public User FkForUser { get; set; }
        public LqShifts FkShift { get; set; }
    }
}
