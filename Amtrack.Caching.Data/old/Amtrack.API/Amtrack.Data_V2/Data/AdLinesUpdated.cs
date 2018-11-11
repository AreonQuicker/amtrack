using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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
