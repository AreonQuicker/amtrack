using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class SystemRequestNote
    {
        public SystemRequestNote()
        {
            SystemRequestAttachment = new HashSet<SystemRequestAttachment>();
        }

        public long Id { get; set; }
        public long SystemRequestId { get; set; }
        public DateTime Created { get; set; }
        public long AuthorId { get; set; }
        public string Data { get; set; }

        public User Author { get; set; }
        public ICollection<SystemRequestAttachment> SystemRequestAttachment { get; set; }
    }
}
