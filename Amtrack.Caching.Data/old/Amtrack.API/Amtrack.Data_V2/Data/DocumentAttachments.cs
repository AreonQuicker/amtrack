using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DocumentAttachments
    {
        public Guid AttachmentId { get; set; }
        public DateTime Created { get; set; }
        public string Filename { get; set; }
        public string RelativePath { get; set; }
        public string Description { get; set; }
        public short Type { get; set; }
        public string DocumentNumber { get; set; }
    }
}
