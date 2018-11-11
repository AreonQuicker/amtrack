using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmGroupLeadtimes
    {
        public int Id { get; set; }
        public int FkGroupId { get; set; }
        public int QtyMin { get; set; }
        public int QtyMax { get; set; }
        public int? Colours { get; set; }
        public int Leadtime { get; set; }

        public LdmGroups FkGroup { get; set; }
    }
}
