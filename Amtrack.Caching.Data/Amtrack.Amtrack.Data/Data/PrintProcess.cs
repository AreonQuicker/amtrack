using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrintProcess
    {
        public PrintProcess()
        {
            JobCardPrintingProcess = new HashSet<JobCardPrintingProcess>();
            LeadTimesJobCard = new HashSet<LeadTimesJobCard>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int NumberOfColours { get; set; }

        public PrintingDepartmentProcesses PrintingDepartmentProcesses { get; set; }
        public ICollection<JobCardPrintingProcess> JobCardPrintingProcess { get; set; }
        public ICollection<LeadTimesJobCard> LeadTimesJobCard { get; set; }
    }
}
