using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class MessageQueueLogs
    {
        public Guid MessageQueueLogId { get; set; }
        public Guid? MessageQueueItemId { get; set; }
        public DateTime Created { get; set; }
        public string LogInfo { get; set; }
        public short Attempt { get; set; }
        public Guid? FkMessageQueueItemId { get; set; }
    }
}
