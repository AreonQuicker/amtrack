using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsDocuments
    {
        public WmsDocuments()
        {
            ReworkDocuments = new HashSet<ReworkDocuments>();
            WmsDocumentBoxLinks = new HashSet<WmsDocumentBoxLinks>();
            WmsDocumentLines = new HashSet<WmsDocumentLines>();
            WmsDocumentLinksFkWmsDocument = new HashSet<WmsDocumentLinks>();
            WmsDocumentLinksFkWmsDocumentParent = new HashSet<WmsDocumentLinks>();
            WmsDocumentTracking = new HashSet<WmsDocumentTracking>();
        }

        public long Id { get; set; }
        public string ParentDocumentNumber { get; set; }
        public Guid FkDocumentId { get; set; }
        public long? FkJobCardId { get; set; }
        public DateTime Created { get; set; }
        public short Version { get; set; }
        public long? FkWmsDocumentParentId { get; set; }
        public string DocumentNumber { get; set; }
        public int DocumentType { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
        public string CustomerCode { get; set; }
        public Guid? Guid { get; set; }

        public ICollection<ReworkDocuments> ReworkDocuments { get; set; }
        public ICollection<WmsDocumentBoxLinks> WmsDocumentBoxLinks { get; set; }
        public ICollection<WmsDocumentLines> WmsDocumentLines { get; set; }
        public ICollection<WmsDocumentLinks> WmsDocumentLinksFkWmsDocument { get; set; }
        public ICollection<WmsDocumentLinks> WmsDocumentLinksFkWmsDocumentParent { get; set; }
        public ICollection<WmsDocumentTracking> WmsDocumentTracking { get; set; }
    }
}
