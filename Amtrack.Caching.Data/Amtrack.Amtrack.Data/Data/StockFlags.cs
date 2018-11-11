using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StockFlags
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string ItemCode { get; set; }
        public string ItemCodeClear { get; set; }
        public int Flags { get; set; }
    }
}
