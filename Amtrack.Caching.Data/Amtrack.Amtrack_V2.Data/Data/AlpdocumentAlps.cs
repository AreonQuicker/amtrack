using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AlpdocumentAlps
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
    }
}
