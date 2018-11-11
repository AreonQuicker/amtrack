using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardSurplus
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long JobCardId { get; set; }
        public string ItemCode { get; set; }
        public int UnitsInvoiced { get; set; }
        public int Surplus { get; set; }
    }
}
