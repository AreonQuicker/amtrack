using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobcardTimesheetRecords
    {
        public Guid RecordId { get; set; }
        public string JobcardNumber { get; set; }
        public DateTime Started { get; set; }
        public int Quantity { get; set; }
        public string Machine { get; set; }
        public Guid Author { get; set; }
        public DateTime? SetupComplete { get; set; }
        public DateTime? JobCompleted { get; set; }
        public int? CompletedQuantity { get; set; }
        public int Status { get; set; }
    }
}
