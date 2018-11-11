using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmGroupItems
    {
        public long Id { get; set; }
        public int FkGroupId { get; set; }
        public string BaseItemCode { get; set; }

        public LdmGroups FkGroup { get; set; }
    }
}
