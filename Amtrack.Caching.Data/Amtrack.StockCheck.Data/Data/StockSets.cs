using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockSets
    {
        public StockSets()
        {
            StockSetComponents = new HashSet<StockSetComponents>();
            StockSetContents = new HashSet<StockSetContents>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string BaseCode { get; set; }
        public string ItemCode { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceDiscountCode { get; set; }
        public int Flags { get; set; }

        public ICollection<StockSetComponents> StockSetComponents { get; set; }
        public ICollection<StockSetContents> StockSetContents { get; set; }
    }
}
