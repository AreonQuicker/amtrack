using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class EntityAttachments
    {
        public EntityAttachments()
        {
            EntityAttachmentLinks = new HashSet<EntityAttachmentLinks>();
        }

        public long AttachmentId { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }
        public long FileSize { get; set; }
        public string Extension { get; set; }
        public string Mimetype { get; set; }
        public string RelativePath { get; set; }
        public string Name { get; set; }
        public long Flags { get; set; }

        public ICollection<EntityAttachmentLinks> EntityAttachmentLinks { get; set; }
    }
}
