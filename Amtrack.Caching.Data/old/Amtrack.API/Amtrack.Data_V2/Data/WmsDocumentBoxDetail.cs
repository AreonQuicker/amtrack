using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentBoxDetail
    {
        public WmsDocumentBoxDetail()
        {
            InverseFkWmsDocumentBoxMasterDetail = new HashSet<WmsDocumentBoxDetail>();
        }

        public long Id { get; set; }
        public long FkWmsDocumentBoxId { get; set; }
        public DateTime Created { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public long? FkWmsDocumentBoxMasterDetailId { get; set; }

        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
        public WmsDocumentBoxDetail FkWmsDocumentBoxMasterDetail { get; set; }
        public ICollection<WmsDocumentBoxDetail> InverseFkWmsDocumentBoxMasterDetail { get; set; }
    }
}
