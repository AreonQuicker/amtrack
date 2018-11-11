using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ImportStates
    {
        public long ImportId { get; set; }
        public string ImportKey { get; set; }
        public int ImportVersion { get; set; }
        public DateTime ImportDate { get; set; }
        public string ImportSource { get; set; }
        public Guid DocumentId { get; set; }
    }
}
