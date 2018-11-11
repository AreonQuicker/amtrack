using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentPostProcessing
    {
        public DocumentPostProcessing()
        {
            DocumentPostProcessingInfoes = new HashSet<DocumentPostProcessingInfoes>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public int Type { get; set; }
        public long Flags { get; set; }

        public ICollection<DocumentPostProcessingInfoes> DocumentPostProcessingInfoes { get; set; }
    }
}
