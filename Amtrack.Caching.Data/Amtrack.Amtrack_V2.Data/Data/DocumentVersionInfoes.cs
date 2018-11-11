using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentVersionInfoes
    {
        public short CurrentVersion { get; set; }
        public Guid DocumentVersionId { get; set; }
        public string DocumentNumber { get; set; }
        public string PickingSlipNumber { get; set; }
        public string DocumentBarcode { get; set; }
        public long DocumentFlags { get; set; }
        public string ParentDocumentNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public long? DocumentFlags2 { get; set; }
    }
}
