using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class SystemRequestAttachment
    {
        public long Id { get; set; }
        public long SystemRequestId { get; set; }
        public long? SystemRequestNoteId { get; set; }
        public DateTime Created { get; set; }
        public string Path { get; set; }
        public long FileSize { get; set; }
        public string Name { get; set; }

        public SystemRequest SystemRequest { get; set; }
        public SystemRequestNote SystemRequestNote { get; set; }
    }
}
