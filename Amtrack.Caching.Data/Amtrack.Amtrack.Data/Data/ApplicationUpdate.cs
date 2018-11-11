using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ApplicationUpdate
    {
        public Guid ApplicationKey { get; set; }
        public Guid VersionKey { get; set; }
        public byte Major { get; set; }
        public byte Minor { get; set; }
        public byte Revision { get; set; }
        public long Size { get; set; }
        public string Hash { get; set; }
    }
}
