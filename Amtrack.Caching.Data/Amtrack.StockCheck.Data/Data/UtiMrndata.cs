using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class UtiMrndata
    {
        public UtiMrndata()
        {
            UtiMrntransactions = new HashSet<UtiMrntransactions>();
        }

        public long Id { get; set; }
        public string Mrn { get; set; }
        public int LineNumber { get; set; }
        public string ItemCode { get; set; }
        public double Quantity { get; set; }
        public double ReceivedQty { get; set; }
        public double UsedQty { get; set; }
        public string Ponumber { get; set; }

        public ICollection<UtiMrntransactions> UtiMrntransactions { get; set; }
    }
}
