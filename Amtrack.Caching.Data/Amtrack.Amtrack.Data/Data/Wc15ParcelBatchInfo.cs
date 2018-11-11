using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Wc15ParcelBatchInfo
    {
        public int Id { get; set; }
        public long FkParcelId { get; set; }
        public string ParcelRangeCode { get; set; }
    }
}
