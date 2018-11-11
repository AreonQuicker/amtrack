using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockSetComponents
    {
        public int Id { get; set; }
        public int FkSetId { get; set; }
        public DateTime Created { get; set; }
        public string BaseCode { get; set; }
        public string Prefix { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }
        public int Sequence { get; set; }
        public string AutoAdditionItemCode { get; set; }

        public StockSets FkSet { get; set; }
    }
}
