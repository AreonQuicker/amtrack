using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PalletTransferBatches
    {
        public PalletTransferBatches()
        {
            PalletTransferBatchContents = new HashSet<PalletTransferBatchContents>();
        }

        public Guid BatchId { get; set; }
        public string BatchNumber { get; set; }
        public DateTime Created { get; set; }
        public long Flags { get; set; }
        public DateTime? DateTransferred { get; set; }
        public DateTime? Processed { get; set; }

        public ICollection<PalletTransferBatchContents> PalletTransferBatchContents { get; set; }
    }
}
