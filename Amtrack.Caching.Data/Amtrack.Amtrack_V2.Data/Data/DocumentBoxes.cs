using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentBoxes
    {
        public DocumentBoxes()
        {
            DocumentBoxDetail = new HashSet<DocumentBoxDetail>();
        }

        public long Id { get; set; }
        public Guid FkDocumentId { get; set; }
        public DateTime Created { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string LocationName { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public Documents FkDocument { get; set; }
        public ICollection<DocumentBoxDetail> DocumentBoxDetail { get; set; }
    }
}
