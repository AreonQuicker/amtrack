using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchWifi
    {
        public int Id { get; set; }
        public string Ssid { get; set; }
        public bool Hidden { get; set; }
        public int AuthType { get; set; }
        public int FkAuthenticationId { get; set; }
        public long FkBranchId { get; set; }

        public Branches FkBranch { get; set; }
    }
}
