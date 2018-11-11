using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class InventoryStock
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Stock FkNavigation { get; set; }
        public Inventory PkNavigation { get; set; }
    }
}
