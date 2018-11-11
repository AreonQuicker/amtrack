using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockSetContents
    {
        public int Id { get; set; }
        public int FkSetId { get; set; }
        public DateTime Created { get; set; }
        public string ItemCode { get; set; }
        public string BaseItemCode { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
        public int Sequence { get; set; }
        public int Flags { get; set; }
        public int Multiplier { get; set; }

        public StockSets FkSet { get; set; }
    }
}
