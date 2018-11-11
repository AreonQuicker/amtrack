using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardEmbroideryQuoteRequest
    {
        public long JobCardId { get; set; }
        public long EmbroideryRequestId { get; set; }
        public int? PositionNo { get; set; }

        public EmbroideryQuoteRequest EmbroideryRequest { get; set; }
        public JobCard JobCard { get; set; }
    }
}
