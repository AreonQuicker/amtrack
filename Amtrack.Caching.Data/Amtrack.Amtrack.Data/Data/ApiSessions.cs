using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ApiSessions
    {
        public ApiSessions()
        {
            ApiSessionActivities = new HashSet<ApiSessionActivities>();
            PrinterSessions = new HashSet<PrinterSessions>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expire { get; set; }
        public Guid SessionId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public long XfxAccountId { get; set; }
        public long XfxCustomerId { get; set; }
        public long XfxPriceGroupId { get; set; }
        public string RemoteHost { get; set; }

        public ICollection<ApiSessionActivities> ApiSessionActivities { get; set; }
        public ICollection<PrinterSessions> PrinterSessions { get; set; }
    }
}
