using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqAllocation
    {
        public long Id { get; set; }
        public long? FkJobCardId { get; set; }
        public long? FkOrderId { get; set; }
        public DateTime DateAllocated { get; set; }
        public long FkUserId { get; set; }
        public long Flags { get; set; }

        public JobCard FkJobCard { get; set; }
        public Order FkOrder { get; set; }
        public User FkUser { get; set; }
    }
}
