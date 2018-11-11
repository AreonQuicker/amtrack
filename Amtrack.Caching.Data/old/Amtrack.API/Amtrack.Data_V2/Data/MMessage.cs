using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class MMessage
    {
        public MMessage()
        {
            MRecipients = new HashSet<MRecipients>();
            MStore = new HashSet<MStore>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string MessageText { get; set; }
        public string MessageHeading { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }

        public MDocuments MDocuments { get; set; }
        public MSchedules MSchedules { get; set; }
        public ICollection<MRecipients> MRecipients { get; set; }
        public ICollection<MStore> MStore { get; set; }
    }
}
