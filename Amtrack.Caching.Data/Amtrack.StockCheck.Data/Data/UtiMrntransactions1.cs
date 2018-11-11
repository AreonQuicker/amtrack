using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class UtiMrntransactions1
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long MrnId { get; set; }
        public int Type { get; set; }
        public string Reason { get; set; }
        public double Quantity { get; set; }
        public int Flags { get; set; }

        public UtiMrndata1 Mrn { get; set; }
    }
}
