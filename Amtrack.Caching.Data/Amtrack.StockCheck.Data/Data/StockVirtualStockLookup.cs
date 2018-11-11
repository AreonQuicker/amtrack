using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockVirtualStockLookup
    {
        public int Id { get; set; }
        public string VirtualRangeCode { get; set; }
        public string PhysicalRangeCode { get; set; }
        public string ColourCode { get; set; }
        public string PrintDepartment { get; set; }
        public string PrintSteps { get; set; }
    }
}
