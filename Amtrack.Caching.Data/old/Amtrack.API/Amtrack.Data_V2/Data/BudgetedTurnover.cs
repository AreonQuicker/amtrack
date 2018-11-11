using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BudgetedTurnover
    {
        public long Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Gifts { get; set; }
        public decimal Clothing { get; set; }
        public decimal Branding { get; set; }
    }
}
