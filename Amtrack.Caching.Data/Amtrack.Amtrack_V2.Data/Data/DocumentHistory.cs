using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentHistory
    {
        public long HistoryId { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }
        public string AdditionalInfo { get; set; }
        public int FkHistoryContributorId { get; set; }
        public Guid FkDocumentId { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }

        public HistoryContributor FkHistoryContributor { get; set; }
    }
}
