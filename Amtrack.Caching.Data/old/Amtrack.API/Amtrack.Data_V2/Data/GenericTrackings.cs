using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class GenericTrackings
    {
        public Guid EntityId { get; set; }
        public DateTime TrackingDate { get; set; }
        public int TrackingType { get; set; }
        public string TrackingExtra { get; set; }
        public Guid UserId { get; set; }
    }
}
