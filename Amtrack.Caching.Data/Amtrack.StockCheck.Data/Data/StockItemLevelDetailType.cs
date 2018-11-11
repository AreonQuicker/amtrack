using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemLevelDetailType
    {
        public StockItemLevelDetailType()
        {
            StockItemLevelDetail = new HashSet<StockItemLevelDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Wmslookup { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemLevelDetail> StockItemLevelDetail { get; set; }
    }
}
