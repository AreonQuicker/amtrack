using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class QueryNotifications
    {
        public int Id { get; set; }
        public string Warehouse { get; set; }
        public string RecipientEmail { get; set; }
        public short Type { get; set; }
        public long? FkRecipientId { get; set; }
        public int FkReasonId { get; set; }

        public QueryReasonCodes FkReason { get; set; }
        public User FkRecipient { get; set; }
    }
}
