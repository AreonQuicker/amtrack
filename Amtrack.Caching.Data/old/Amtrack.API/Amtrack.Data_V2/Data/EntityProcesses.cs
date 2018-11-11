using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class EntityProcesses
    {
        public Guid ProcessId { get; set; }
        public string EntityKey { get; set; }
        public int Version { get; set; }
        public short Type { get; set; }
        public DateTime DateProcessed { get; set; }
        public long Flags { get; set; }
        public int? Status { get; set; }
    }
}
