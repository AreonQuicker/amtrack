using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqQueueNotes
    {
        public long Id { get; set; }
        public long FkEventId { get; set; }
        public string Note { get; set; }
        public long Flags { get; set; }

        public LqQueueTracking FkEvent { get; set; }
    }
}
