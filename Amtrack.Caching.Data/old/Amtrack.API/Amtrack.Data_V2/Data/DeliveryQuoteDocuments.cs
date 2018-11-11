using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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
