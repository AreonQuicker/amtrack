using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DocumentReservedStocks
    {
        public Guid ReserveId { get; set; }
        public string ItemCode { get; set; }
        public string DocumentNumber { get; set; }
        public int TotalQuantity { get; set; }
        public int ReservedMain { get; set; }
        public int ReservedOvf { get; set; }
        public int ReservedBnd { get; set; }
        public int ReservedInc { get; set; }
        public int ReservedGlx { get; set; }
        public DateTime Created { get; set; }
        public long Flags { get; set; }
        public int ReservedWmd { get; set; }
        public int ReservedWbn { get; set; }
    }
}
