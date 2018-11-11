using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentBoxDetail
    {
        public long FkDocumentBoxId { get; set; }
        public Guid FkDocumentLineId { get; set; }
        public int Quantity { get; set; }

        public DocumentBoxes FkDocumentBox { get; set; }
        public Lines FkDocumentLine { get; set; }
    }
}
