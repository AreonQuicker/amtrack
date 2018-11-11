using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CsStockTakeResolved
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? FkStockTakeId { get; set; }
        public long? FkStockTakeParcelId { get; set; }
        public long? FkStockTakeSnapshotId { get; set; }
        public int ReasonId { get; set; }
        public int UserId { get; set; }
    }
}
