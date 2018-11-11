using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StkimpotedSnapshotData
    {
        public int Id { get; set; }
        public int FkImportedSnapshot { get; set; }
        public string ItemStatus { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public int SuspenseQuantity { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public StkimportedSnapshot FkImportedSnapshotNavigation { get; set; }
    }
}
