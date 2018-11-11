using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ReportOverride
    {
        public int OrderId { get; set; }
        public string ReportId { get; set; }
        public bool RemoveFromReport { get; set; }
        public int? PositionOverride { get; set; }
        public string DisplayOverride { get; set; }
        public bool Flash { get; set; }
        public long? UserId { get; set; }
    }
}
