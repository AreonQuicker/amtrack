using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DmDeviceRotation
    {
        public DateTime In { get; set; }
        public DateTime Out { get; set; }
        public int FkDeviceId { get; set; }
        public Guid FkUserId { get; set; }
        public long Id { get; set; }

        public DmDevice FkDevice { get; set; }
    }
}
