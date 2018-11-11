using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class SrReceiptTracking
    {
        public long Id { get; set; }
        public long FkSrReceiptId { get; set; }
        public long? FkSrReceiptLineId { get; set; }
        public DateTime Created { get; set; }
        public int Type { get; set; }
        public long? FkUserId { get; set; }

        public SrReceipts FkSrReceipt { get; set; }
        public SrReceiptLines FkSrReceiptLine { get; set; }
    }
}
