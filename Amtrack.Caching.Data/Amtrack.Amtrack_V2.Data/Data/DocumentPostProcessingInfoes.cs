using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentPostProcessingInfoes
    {
        public int Id { get; set; }
        public int FkProcessingId { get; set; }
        public string ProcessingKey { get; set; }
        public string ProcessingValue { get; set; }

        public DocumentPostProcessing FkProcessing { get; set; }
    }
}
