using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LinkedReturnStock
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long AccountId { get; set; }
        public string StockCode { get; set; }
        public double Quantity { get; set; }
        public long JobCardId { get; set; }
        public long UserId { get; set; }
        public long OrderId { get; set; }
        public long? JclineId { get; set; }

        public Account Account { get; set; }
        public JobCard JobCard { get; set; }
        public Order Order { get; set; }
        public User User { get; set; }
    }
}
