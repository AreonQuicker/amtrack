using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class EmbroideryQuoteRequestTracking
    {
        public long QuoteRequestId { get; set; }
        public int PositionNo { get; set; }
        public long TrackingId { get; set; }

        public EmbroideryQuoteRequest QuoteRequest { get; set; }
        public Tracking Tracking { get; set; }
    }
}
