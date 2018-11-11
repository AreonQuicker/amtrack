using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class EntityNotificationRecipients
    {
        public string RecipientEmail { get; set; }
        public short Type { get; set; }
        public Guid FkNotificationId { get; set; }

        public EntityNotifications FkNotification { get; set; }
    }
}
