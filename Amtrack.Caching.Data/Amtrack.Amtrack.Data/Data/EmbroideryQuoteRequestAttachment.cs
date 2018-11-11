using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class EmbroideryQuoteRequestAttachment
    {
        public long Id { get; set; }
        public long EmbroideryRequestId { get; set; }
        public int PositionNo { get; set; }
        public DateTime Created { get; set; }
        public string Filename { get; set; }
        public long AuthorId { get; set; }

        public EmbroideryQuoteRequest EmbroideryRequest { get; set; }
    }
}
