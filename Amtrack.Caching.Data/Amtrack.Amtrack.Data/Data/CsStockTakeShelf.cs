using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CsStockTakeShelf
    {
        public CsStockTakeShelf()
        {
            CsStockTakeParcel = new HashSet<CsStockTakeParcel>();
            CsStockTakeSnapshot = new HashSet<CsStockTakeSnapshot>();
        }

        public int Id { get; set; }
        public int FkStockTakeId { get; set; }
        public long FkShelfId { get; set; }
        public int Flags { get; set; }

        public CsStockTake FkStockTake { get; set; }
        public ICollection<CsStockTakeParcel> CsStockTakeParcel { get; set; }
        public ICollection<CsStockTakeSnapshot> CsStockTakeSnapshot { get; set; }
    }
}
