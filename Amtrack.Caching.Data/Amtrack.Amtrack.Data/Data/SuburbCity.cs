using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class SuburbCity
    {
        public long Id { get; set; }
        public long ProvinceFk { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public Province ProvinceFkNavigation { get; set; }
    }
}
