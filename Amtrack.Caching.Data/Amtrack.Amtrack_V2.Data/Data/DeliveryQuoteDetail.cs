using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryQuoteDetail
    {
        public int Id { get; set; }
        public int FkDeliveryQuoteId { get; set; }
        public DateTime Created { get; set; }
        public string Courier { get; set; }
        public string Service { get; set; }
        public string SeviceCode { get; set; }
        public double Price { get; set; }
        public TimeSpan Time { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public bool IsSelected { get; set; }
        public int? EstdeliveryDate { get; set; }
        public DateTime? Etadate { get; set; }
        public string LeadTime { get; set; }

        public DeliveryQuote FkDeliveryQuote { get; set; }
    }
}
