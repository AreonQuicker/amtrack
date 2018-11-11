using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteRequest
    {
        public CreditNoteRequest()
        {
            CreditNoteAuthorizer = new HashSet<CreditNoteAuthorizer>();
            CreditNoteCreditNoteRequest = new HashSet<CreditNoteCreditNoteRequest>();
            CreditNoteRequestDetail = new HashSet<CreditNoteRequestDetail>();
            CreditNoteRequestNotes = new HashSet<CreditNoteRequestNotes>();
            CreditNoteRequestOrder = new HashSet<CreditNoteRequestOrder>();
            CreditNoteRequestPaymentApprovedNotes = new HashSet<CreditNoteRequestPaymentApprovedNotes>();
            CreditNoteRequestTracking = new HashSet<CreditNoteRequestTracking>();
            CreditNoteRequester = new HashSet<CreditNoteRequester>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string RequestNumber { get; set; }
        public string RequestReason { get; set; }
        public double? CancelationFee { get; set; }
        public int? Flags { get; set; }
        public long? FkApprovalManagerId { get; set; }
        public string ProjectCode { get; set; }

        public ICollection<CreditNoteAuthorizer> CreditNoteAuthorizer { get; set; }
        public ICollection<CreditNoteCreditNoteRequest> CreditNoteCreditNoteRequest { get; set; }
        public ICollection<CreditNoteRequestDetail> CreditNoteRequestDetail { get; set; }
        public ICollection<CreditNoteRequestNotes> CreditNoteRequestNotes { get; set; }
        public ICollection<CreditNoteRequestOrder> CreditNoteRequestOrder { get; set; }
        public ICollection<CreditNoteRequestPaymentApprovedNotes> CreditNoteRequestPaymentApprovedNotes { get; set; }
        public ICollection<CreditNoteRequestTracking> CreditNoteRequestTracking { get; set; }
        public ICollection<CreditNoteRequester> CreditNoteRequester { get; set; }
    }
}
