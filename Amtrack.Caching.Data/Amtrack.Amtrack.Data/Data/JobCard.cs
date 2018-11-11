using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCard
    {
        public JobCard()
        {
            BatchedJobCards = new HashSet<BatchedJobCards>();
            JobCardAccountContacts = new HashSet<JobCardAccountContacts>();
            JobCardAttachments = new HashSet<JobCardAttachments>();
            JobCardCustomerNotes = new HashSet<JobCardCustomerNotes>();
            JobCardLayouts = new HashSet<JobCardLayouts>();
            JobCardLeadtimeTracking = new HashSet<JobCardLeadtimeTracking>();
            JobCardNotes = new HashSet<JobCardNotes>();
            JobCardQuery = new HashSet<JobCardQuery>();
            JobCardSpecialInstructions = new HashSet<JobCardSpecialInstructions>();
            JobCardTracking = new HashSet<JobCardTracking>();
            LeadTimesJobCard = new HashSet<LeadTimesJobCard>();
            LineJobCards = new HashSet<LineJobCards>();
            LinkLineJobCards = new HashSet<LinkLineJobCards>();
            LinkedReturnStock = new HashSet<LinkedReturnStock>();
            LqAllocation = new HashSet<LqAllocation>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Number { get; set; }
        public bool IsSampleRequired { get; set; }
        public bool IsRepeatJob { get; set; }
        public bool IsLogoRedrawRequired { get; set; }
        public string SizeAndPosition { get; set; }
        public string Colours { get; set; }
        public string SpecialInstructions { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
        public int? Flag { get; set; }
        public string CancelledReason { get; set; }
        public string ContactPerson { get; set; }
        public string LogoName { get; set; }
        public string RepeatJobInvoiceNumber { get; set; }
        public long? PreviousJobCard { get; set; }
        public string RepeatJobCardLayoutReference { get; set; }

        public JobCardEmbroideryQuoteRequest JobCardEmbroideryQuoteRequest { get; set; }
        public JobCardEx JobCardEx { get; set; }
        public JobCardEx2 JobCardEx2 { get; set; }
        public JobCardPrintingProcess JobCardPrintingProcess { get; set; }
        public JobCardQueue JobCardQueue { get; set; }
        public JobCardsForPrintLines JobCardsForPrintLines { get; set; }
        public LocationJobCards LocationJobCards { get; set; }
        public LqQueue LqQueue { get; set; }
        public PrintJobs PrintJobs { get; set; }
        public ICollection<BatchedJobCards> BatchedJobCards { get; set; }
        public ICollection<JobCardAccountContacts> JobCardAccountContacts { get; set; }
        public ICollection<JobCardAttachments> JobCardAttachments { get; set; }
        public ICollection<JobCardCustomerNotes> JobCardCustomerNotes { get; set; }
        public ICollection<JobCardLayouts> JobCardLayouts { get; set; }
        public ICollection<JobCardLeadtimeTracking> JobCardLeadtimeTracking { get; set; }
        public ICollection<JobCardNotes> JobCardNotes { get; set; }
        public ICollection<JobCardQuery> JobCardQuery { get; set; }
        public ICollection<JobCardSpecialInstructions> JobCardSpecialInstructions { get; set; }
        public ICollection<JobCardTracking> JobCardTracking { get; set; }
        public ICollection<LeadTimesJobCard> LeadTimesJobCard { get; set; }
        public ICollection<LineJobCards> LineJobCards { get; set; }
        public ICollection<LinkLineJobCards> LinkLineJobCards { get; set; }
        public ICollection<LinkedReturnStock> LinkedReturnStock { get; set; }
        public ICollection<LqAllocation> LqAllocation { get; set; }
    }
}
