using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentLines
    {
        public WmsDocumentLines()
        {
            InverseFkWmsDocumentMasterLine = new HashSet<WmsDocumentLines>();
        }

        public long Id { get; set; }
        public long FkWmsDocumentId { get; set; }
        public long? FkWmsDocumentMasterLineId { get; set; }
        public string ItemCode { get; set; }
        public DateTime Created { get; set; }
        public int? PickedQuantity { get; set; }
        public int Quantity { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public WmsDocuments FkWmsDocument { get; set; }
        public WmsDocumentLines FkWmsDocumentMasterLine { get; set; }
        public ICollection<WmsDocumentLines> InverseFkWmsDocumentMasterLine { get; set; }
    }
}
