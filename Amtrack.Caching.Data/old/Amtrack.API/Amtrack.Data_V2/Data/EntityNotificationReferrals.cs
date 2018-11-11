using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class EntityNotificationReferrals
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string EntityKey { get; set; }
        public int Version { get; set; }
        public short Type { get; set; }
        public string ReferralEmail { get; set; }
        public int Flags { get; set; }
    }
}
