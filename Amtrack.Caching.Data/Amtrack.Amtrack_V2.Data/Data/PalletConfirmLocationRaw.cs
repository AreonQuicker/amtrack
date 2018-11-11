using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PalletConfirmLocationRaw
    {
        public Guid RawId { get; set; }
        public DateTime Created { get; set; }
        public string LocationBarcode { get; set; }
        public string EnitityBarcode { get; set; }
        public bool IsValidPalletBarcode { get; set; }
        public bool IsValidLocationBarcode { get; set; }
        public int FkScannedById { get; set; }
        public Guid FkBatchId { get; set; }
        public int Flags { get; set; }

        public PalletConfirmLocationBatches FkBatch { get; set; }
        public HistoryContributor FkScannedBy { get; set; }
    }
}
