using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqLayoutDocuments
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkQueueId { get; set; }
        public bool Repeat { get; set; }
        public bool Change { get; set; }
        public string Path { get; set; }
        public long Flags { get; set; }

        public LqQueue FkQueue { get; set; }
    }
}
