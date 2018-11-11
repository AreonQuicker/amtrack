using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SyncDataErrorRecipients
    {
        public long Id { get; set; }
        public long FkSyncDataErrorId { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }

        public SyncDataErrors FkSyncDataError { get; set; }
    }
}
