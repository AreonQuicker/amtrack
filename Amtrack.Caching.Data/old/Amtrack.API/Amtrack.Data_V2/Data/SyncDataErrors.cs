using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SyncDataErrors
    {
        public SyncDataErrors()
        {
            SyncDataErrorDetail = new HashSet<SyncDataErrorDetail>();
            SyncDataErrorRecipients = new HashSet<SyncDataErrorRecipients>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int Type { get; set; }
        public string TypeKey { get; set; }
        public string SyncSource { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<SyncDataErrorDetail> SyncDataErrorDetail { get; set; }
        public ICollection<SyncDataErrorRecipients> SyncDataErrorRecipients { get; set; }
    }
}
