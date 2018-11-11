using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Terminal
    {
        public Terminal()
        {
            TerminalTracking = new HashSet<TerminalTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public TerminalLocations TerminalLocations { get; set; }
        public ICollection<TerminalTracking> TerminalTracking { get; set; }
    }
}
