using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqQueueTypeValues
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkLqQueueTypeId { get; set; }
        public string StringValue { get; set; }
        public long? BigIntValue { get; set; }
        public int? IntValue { get; set; }
        public int Flags { get; set; }

        public LqQueueTypes FkLqQueueType { get; set; }
    }
}
