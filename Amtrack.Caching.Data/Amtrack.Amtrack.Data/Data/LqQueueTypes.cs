using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqQueueTypes
    {
        public LqQueueTypes()
        {
            LqQueueTypeValues = new HashSet<LqQueueTypeValues>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<LqQueueTypeValues> LqQueueTypeValues { get; set; }
    }
}
