using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SrReceiptCompletedLines
    {
        public long Id { get; set; }
        public long FkReceiptId { get; set; }
        public long FkSrReceiptLineId { get; set; }
        public DateTime Created { get; set; }
        public int Quantity { get; set; }
        public int TotalQuantity { get; set; }
        public int FkStockItemUomtemplateId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public SrReceipts FkReceipt { get; set; }
        public SrReceiptLines FkSrReceiptLine { get; set; }
    }
}
