using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ReturnedLine
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public int? RowNumber { get; set; }

        public ReturnedBatchDetail ReturnedBatchDetail { get; set; }
    }
}
