using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class MRecipientResponses
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkStore { get; set; }
        public Guid RecipientId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }

        public MStore FkStoreNavigation { get; set; }
    }
}
