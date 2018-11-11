using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StTopCustomerSpend
    {
        public DateTime Date { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string PricelistName { get; set; }
        public double SpendToday { get; set; }
        public double SpendMonth { get; set; }
    }
}
