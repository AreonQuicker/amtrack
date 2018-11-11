using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class QueryReasonCodes
    {
        public QueryReasonCodes()
        {
            JobCardQuery = new HashSet<JobCardQuery>();
            OrderQuery = new HashSet<OrderQuery>();
            QueryNotifications = new HashSet<QueryNotifications>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }

        public ICollection<JobCardQuery> JobCardQuery { get; set; }
        public ICollection<OrderQuery> OrderQuery { get; set; }
        public ICollection<QueryNotifications> QueryNotifications { get; set; }
    }
}
