using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ServerDetails
    {
        public ServerDetails()
        {
            BranchServers = new HashSet<BranchServers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public string Url { get; set; }
        public string DatabaseName { get; set; }
        public string CommonDatabaseName { get; set; }
        public string PastelSerialNumber { get; set; }
        public string PastelAuthKey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public ICollection<BranchServers> BranchServers { get; set; }
    }
}
