using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class MStore
    {
        public MStore()
        {
            MRecipientResponses = new HashSet<MRecipientResponses>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkMessage { get; set; }
        public DateTime Date { get; set; }
        public long ExpiredTime { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }

        public MMessage FkMessageNavigation { get; set; }
        public ICollection<MRecipientResponses> MRecipientResponses { get; set; }
    }
}
