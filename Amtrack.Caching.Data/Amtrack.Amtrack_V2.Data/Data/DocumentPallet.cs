using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentPallet
    {
        public Guid DocumentsDocumentId { get; set; }
        public Guid PalletsPalletId { get; set; }

        public Documents DocumentsDocument { get; set; }
        public Pallets PalletsPallet { get; set; }
    }
}
