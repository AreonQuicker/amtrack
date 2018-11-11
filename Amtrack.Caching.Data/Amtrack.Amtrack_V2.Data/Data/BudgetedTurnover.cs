using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
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
