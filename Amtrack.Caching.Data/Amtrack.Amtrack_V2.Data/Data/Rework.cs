using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Rework
    {
        public Rework()
        {
            ReworkBoxes = new HashSet<ReworkBoxes>();
            ReworkDocuments = new HashSet<ReworkDocuments>();
            ReworkInstructions = new HashSet<ReworkInstructions>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public string JobCardNumber { get; set; }
        public long? JobCardId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public long? FkUserId { get; set; }
        public string SkippedReason { get; set; }
        public long? FkSkippedUserId { get; set; }
        public DateTime? SkippedDate { get; set; }
        public DateTime? LinkUserDate { get; set; }

        public ICollection<ReworkBoxes> ReworkBoxes { get; set; }
        public ICollection<ReworkDocuments> ReworkDocuments { get; set; }
        public ICollection<ReworkInstructions> ReworkInstructions { get; set; }
    }
}
