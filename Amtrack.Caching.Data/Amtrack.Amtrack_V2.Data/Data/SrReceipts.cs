using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class SrReceipts
    {
        public SrReceipts()
        {
            SrReceiptCompletedLines = new HashSet<SrReceiptCompletedLines>();
            SrReceiptLines = new HashSet<SrReceiptLines>();
            SrReceiptTracking = new HashSet<SrReceiptTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<SrReceiptCompletedLines> SrReceiptCompletedLines { get; set; }
        public ICollection<SrReceiptLines> SrReceiptLines { get; set; }
        public ICollection<SrReceiptTracking> SrReceiptTracking { get; set; }
    }
}
