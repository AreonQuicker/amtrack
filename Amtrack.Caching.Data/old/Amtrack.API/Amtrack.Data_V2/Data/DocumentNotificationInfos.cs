using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DocumentNotificationInfos
    {
        public Guid DocumentNotificationId { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public int NotificationCode { get; set; }
        public DateTime DateSent { get; set; }
        public string Sender { get; set; }
        public string Recipients { get; set; }
    }
}
