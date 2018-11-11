using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class QuoteLines
    {
        public Guid QuoteLineId { get; set; }
        public string ItemCode { get; set; }
        public Guid QuoteDocumentQuoteDocumentId { get; set; }
        public int SequenceCode { get; set; }
        public double? Price { get; set; }
        public string Comment { get; set; }
    }
}
