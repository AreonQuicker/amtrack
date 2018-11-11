using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DmDeviceTracking
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int Type { get; set; }
        public int Subtype { get; set; }
        public int Flags { get; set; }
        public string Description { get; set; }
        public int FkDeviceId { get; set; }
        public long FkUserId { get; set; }
        public int? FkDeviceHandlerId { get; set; }

        public DmDevice FkDevice { get; set; }
        public DmDeviceTracking IdNavigation { get; set; }
        public DmDeviceTracking InverseIdNavigation { get; set; }
    }
}
