using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class TempAplookup
    {
        public string ParentAccountNumber { get; set; }
        public string ChildAccountNumber { get; set; }
        public int IsAmtrackSoftLink { get; set; }
    }
}
