using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CsStockTake
    {
        public CsStockTake()
        {
            CsStockTakeShelf = new HashSet<CsStockTakeShelf>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; }
        public long FkOwnerId { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public User FkOwner { get; set; }
        public ICollection<CsStockTakeShelf> CsStockTakeShelf { get; set; }
    }
}
