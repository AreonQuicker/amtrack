using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class MessageQueueItems
    {
        public Guid MessageQueueItemId { get; set; }
        public DateTime Created { get; set; }
        public short Status { get; set; }
        public short RetryCount { get; set; }
        public DateTime? Success { get; set; }
        public Guid? FkEntityNotificationId { get; set; }
    }
}
