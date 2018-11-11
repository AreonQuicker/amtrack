using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AccountContactNotifications
    {
        public int Id { get; set; }
        public int FkAccountContactId { get; set; }
        public int FkNotificationId { get; set; }
        public int Flags { get; set; }

        public AccountContacts FkAccountContact { get; set; }
        public AccountSystemNotificationTypes FkNotification { get; set; }
    }
}
