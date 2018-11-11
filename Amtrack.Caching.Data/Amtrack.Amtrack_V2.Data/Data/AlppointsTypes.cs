using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AlppointsTypes
    {
        public long Id { get; set; }
        public long FkAlpid { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public Alps FkAlp { get; set; }
    }
}
