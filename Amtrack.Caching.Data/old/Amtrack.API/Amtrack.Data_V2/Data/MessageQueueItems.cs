using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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
