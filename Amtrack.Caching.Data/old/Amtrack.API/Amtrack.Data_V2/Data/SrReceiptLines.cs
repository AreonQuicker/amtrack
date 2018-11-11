using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SrReceiptLines
    {
        public SrReceiptLines()
        {
            SrReceiptCompletedLines = new HashSet<SrReceiptCompletedLines>();
            SrReceiptTracking = new HashSet<SrReceiptTracking>();
        }

        public long Id { get; set; }
        public long FkReceiptId { get; set; }
        public DateTime Created { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public SrReceipts FkReceipt { get; set; }
        public ICollection<SrReceiptCompletedLines> SrReceiptCompletedLines { get; set; }
        public ICollection<SrReceiptTracking> SrReceiptTracking { get; set; }
    }
}
