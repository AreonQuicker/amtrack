using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class EntityAttachmentLinks
    {
        public string EntityKey { get; set; }
        public long FkAttachmentId { get; set; }
        public long LinkId { get; set; }
        public long Flags { get; set; }

        public EntityAttachments FkAttachment { get; set; }
    }
}
