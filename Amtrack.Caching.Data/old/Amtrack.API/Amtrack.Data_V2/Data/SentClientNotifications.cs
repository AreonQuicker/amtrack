using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SentClientNotifications
    {
        public Guid NotificationId { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }
        public string SentBy { get; set; }
        public string SentToIdentifier { get; set; }
        public string SentToEmails { get; set; }
        public string EntityIdentifier { get; set; }
        public int Flags { get; set; }
    }
}
