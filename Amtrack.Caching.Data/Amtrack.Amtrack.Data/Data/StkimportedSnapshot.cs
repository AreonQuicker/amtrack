using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StkimportedSnapshot
    {
        public StkimportedSnapshot()
        {
            StkimpotedSnapshotData = new HashSet<StkimpotedSnapshotData>();
            StksnapshotDifferenceData = new HashSet<StksnapshotDifferenceData>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<StkimpotedSnapshotData> StkimpotedSnapshotData { get; set; }
        public ICollection<StksnapshotDifferenceData> StksnapshotDifferenceData { get; set; }
    }
}
