using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CsStockTakeSnapshot
    {
        public int Id { get; set; }
        public int FkStockTakeShelfId { get; set; }
        public long? FkOrderId { get; set; }
        public long FkParcelId { get; set; }

        public CsStockTakeShelf FkStockTakeShelf { get; set; }
    }
}
