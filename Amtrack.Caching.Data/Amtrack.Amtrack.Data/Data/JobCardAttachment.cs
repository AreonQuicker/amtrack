using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardAttachment
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
        public string RelativePath { get; set; }
        public int Type { get; set; }
        public string FileUrl { get; set; }

        public JobCardAttachments JobCardAttachments { get; set; }
    }
}
