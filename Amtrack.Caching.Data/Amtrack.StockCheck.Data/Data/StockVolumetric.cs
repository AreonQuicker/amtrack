using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockVolumetric
    {
        public int Id { get; set; }
        public int FkBatchId { get; set; }
        public string BaseItemCode { get; set; }
        public string Size { get; set; }
        public double? MWidth { get; set; }
        public double? MHeight { get; set; }
        public double? MLength { get; set; }
        public double? VWeight { get; set; }
        public double? VVolume { get; set; }
        public double? DWeight { get; set; }
        public string DUnit { get; set; }
        public string VUnit { get; set; }
        public string WUnit { get; set; }

        public StockVolumetricBatches FkBatch { get; set; }
    }
}
