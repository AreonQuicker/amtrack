using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DocumentSyncStates
    {
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public bool? OnHold { get; set; }
        public long ToUpdate { get; set; }
    }
}
