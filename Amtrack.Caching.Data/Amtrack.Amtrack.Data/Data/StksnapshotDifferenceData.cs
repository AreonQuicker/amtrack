using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StksnapshotDifferenceData
    {
        public int Id { get; set; }
        public int Version { get; set; }
        public int FkImportedSnapshot { get; set; }
        public string ItemStatus { get; set; }
        public string ItemCode { get; set; }
        public int OldQuantity { get; set; }
        public int NewQuantity { get; set; }
        public int DifferenceQuantity { get; set; }
        public int OldSuspenseQuantity { get; set; }
        public int NewSuspenseQuantity { get; set; }
        public int DifferenceSuspenseQuantity { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public StkimportedSnapshot FkImportedSnapshotNavigation { get; set; }
    }
}
