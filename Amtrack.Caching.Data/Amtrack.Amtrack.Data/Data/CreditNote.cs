using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNote
    {
        public CreditNote()
        {
            CreditNoteAttachments = new HashSet<CreditNoteAttachments>();
            CreditNoteCreditNoteRequest = new HashSet<CreditNoteCreditNoteRequest>();
            CreditNoteDetail = new HashSet<CreditNoteDetail>();
            CreditNoteOrder = new HashSet<CreditNoteOrder>();
            CreditNotePackaging = new HashSet<CreditNotePackaging>();
            CreditNoteShelvedStock = new HashSet<CreditNoteShelvedStock>();
            CreditNoteTracking = new HashSet<CreditNoteTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Barcode { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalExcl { get; set; }
        public double TotalIncl { get; set; }
        public double VatAmount { get; set; }
        public int Status { get; set; }
        public int? Flags { get; set; }
        public string WarehouseNumber { get; set; }
        public string PastelInvoiceNumber { get; set; }

        public CreditNoteAccount CreditNoteAccount { get; set; }
        public ICollection<CreditNoteAttachments> CreditNoteAttachments { get; set; }
        public ICollection<CreditNoteCreditNoteRequest> CreditNoteCreditNoteRequest { get; set; }
        public ICollection<CreditNoteDetail> CreditNoteDetail { get; set; }
        public ICollection<CreditNoteOrder> CreditNoteOrder { get; set; }
        public ICollection<CreditNotePackaging> CreditNotePackaging { get; set; }
        public ICollection<CreditNoteShelvedStock> CreditNoteShelvedStock { get; set; }
        public ICollection<CreditNoteTracking> CreditNoteTracking { get; set; }
    }
}
