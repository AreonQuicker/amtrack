using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class EmbroideryQuoteRequest
    {
        public EmbroideryQuoteRequest()
        {
            EmbroideryQuoteRequestAttachment = new HashSet<EmbroideryQuoteRequestAttachment>();
            EmbroideryQuoteRequestDetails = new HashSet<EmbroideryQuoteRequestDetails>();
            EmbroideryQuoteRequestPositionDetail = new HashSet<EmbroideryQuoteRequestPositionDetail>();
            EmbroideryQuoteRequestTracking = new HashSet<EmbroideryQuoteRequestTracking>();
            JobCardEmbroideryQuoteRequest = new HashSet<JobCardEmbroideryQuoteRequest>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long Author { get; set; }
        public long CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public int? Status { get; set; }
        public int Flags { get; set; }
        public string PriceCode { get; set; }

        public User AuthorNavigation { get; set; }
        public Account Customer { get; set; }
        public ICollection<EmbroideryQuoteRequestAttachment> EmbroideryQuoteRequestAttachment { get; set; }
        public ICollection<EmbroideryQuoteRequestDetails> EmbroideryQuoteRequestDetails { get; set; }
        public ICollection<EmbroideryQuoteRequestPositionDetail> EmbroideryQuoteRequestPositionDetail { get; set; }
        public ICollection<EmbroideryQuoteRequestTracking> EmbroideryQuoteRequestTracking { get; set; }
        public ICollection<JobCardEmbroideryQuoteRequest> JobCardEmbroideryQuoteRequest { get; set; }
    }
}
