using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class EntityNotifications
    {
        public EntityNotifications()
        {
            EntityNotificationRecipients = new HashSet<EntityNotificationRecipients>();
        }

        public Guid NotificationId { get; set; }
        public string EntityKey { get; set; }
        public int Version { get; set; }
        public short Type { get; set; }
        public short TransportType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? DateSent { get; set; }
        public long Flags { get; set; }

        public ICollection<EntityNotificationRecipients> EntityNotificationRecipients { get; set; }
    }
}
