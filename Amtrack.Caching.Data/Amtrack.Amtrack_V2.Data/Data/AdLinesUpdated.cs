using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AdLinesUpdated
    {
        public int Id { get; set; }
        public DateTime ActionDate { get; set; }
        public Guid LineId { get; set; }
        public int QtyBefore { get; set; }
        public int QtyAfter { get; set; }
    }
}
