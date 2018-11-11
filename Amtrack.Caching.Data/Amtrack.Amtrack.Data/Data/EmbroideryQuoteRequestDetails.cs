using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class EmbroideryQuoteRequestDetails
    {
        public long EmbroideryRequestId { get; set; }
        public int PositionNo { get; set; }
        public int? Stitches { get; set; }
        public decimal? Price { get; set; }

        public EmbroideryQuoteRequest EmbroideryRequest { get; set; }
    }
}
