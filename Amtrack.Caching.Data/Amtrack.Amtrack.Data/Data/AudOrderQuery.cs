using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AudOrderQuery
    {
        public long Aid { get; set; }
        public DateTime Actiondate { get; set; }
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long OrderId { get; set; }
        public long Author { get; set; }
        public string QueryData { get; set; }
        public bool Resolved { get; set; }
        public DateTime? ResolvedOn { get; set; }
        public long? ResolvedBy { get; set; }
        public string ResolvedData { get; set; }
        public int? FkReasonId { get; set; }
        public long? Status { get; set; }
        public bool? System { get; set; }
        public long? JobCardId { get; set; }
    }
}
