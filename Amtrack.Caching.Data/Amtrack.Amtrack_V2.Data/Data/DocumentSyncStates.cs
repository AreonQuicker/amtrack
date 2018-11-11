using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentSyncStates
    {
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public bool? OnHold { get; set; }
        public long ToUpdate { get; set; }
    }
}
