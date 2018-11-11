using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryQuoteDocuments
    {
        public int Id { get; set; }
        public int FkDeliveryQuoteId { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }

        public DeliveryQuote FkDeliveryQuote { get; set; }
    }
}
