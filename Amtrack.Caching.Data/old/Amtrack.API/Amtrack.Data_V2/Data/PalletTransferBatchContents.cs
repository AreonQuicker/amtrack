using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PalletTransferBatchContents
    {
        public Guid ContentId { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public Guid FkFromWarehouseId { get; set; }
        public Guid FkToWarehouseId { get; set; }
        public long Flags { get; set; }
        public Guid FkPalletTransferBatchId { get; set; }

        public PalletTransferBatches FkPalletTransferBatch { get; set; }
    }
}
