using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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
