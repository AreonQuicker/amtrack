using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BlanketAcceptances
    {
        public Guid BlanketAcceptanceId { get; set; }
        public string AcceptedBy { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string ContactDesignation { get; set; }
        public string CustomerCode { get; set; }
        public short BlanketType { get; set; }
        public DateTime Created { get; set; }
        public string BranchCode { get; set; }
    }
}
