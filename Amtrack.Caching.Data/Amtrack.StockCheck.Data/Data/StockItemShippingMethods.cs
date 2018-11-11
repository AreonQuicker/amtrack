using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemShippingMethods
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long Flags { get; set; }
    }
}
