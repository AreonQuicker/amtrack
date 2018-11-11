using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class BsFailedMrntransactions
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string WorkUnit { get; set; }
        public int? Sequence { get; set; }
        public string WorkType { get; set; }
        public string Boenumber { get; set; }
        public int? BoelineNumber { get; set; }
        public int? Quantity { get; set; }
        public string Reason { get; set; }
    }
}
