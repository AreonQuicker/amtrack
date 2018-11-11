using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteAttachment
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
        public string RelativePath { get; set; }
        public string Type { get; set; }

        public CreditNoteAttachments CreditNoteAttachments { get; set; }
    }
}
