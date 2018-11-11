using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class EntityNotificationRecipients
    {
        public string RecipientEmail { get; set; }
        public short Type { get; set; }
        public Guid FkNotificationId { get; set; }

        public EntityNotifications FkNotification { get; set; }
    }
}
