using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CsStockTakeParcel
    {
        public int Id { get; set; }
        public DateTime DateScanned { get; set; }
        public int FkStockTakeShelfId { get; set; }
        public long FkParcelId { get; set; }
        public int Flags { get; set; }

        public CsStockTakeShelf FkStockTakeShelf { get; set; }
    }
}
