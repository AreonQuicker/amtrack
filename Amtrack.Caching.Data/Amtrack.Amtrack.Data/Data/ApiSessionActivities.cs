using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ApiSessionActivities
    {
        public long Id { get; set; }
        public long FkSessionId { get; set; }
        public DateTime Created { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public ApiSessions FkSession { get; set; }
    }
}
