using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SyncDataErrorDetail
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkSyncDataErrorId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public SyncDataErrors FkSyncDataError { get; set; }
    }
}
