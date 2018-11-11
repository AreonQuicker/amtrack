using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LayoutArtistBusyWith
    {
        public long LayoutArtistId { get; set; }
        public long JobCardId { get; set; }
        public DateTime LayoutStarted { get; set; }
        public DateTime? LayoutFinished { get; set; }
        public long? OldLayoutArtistId { get; set; }
    }
}
