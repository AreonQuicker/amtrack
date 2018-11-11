using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class WarehouseInventory
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Inventory FkNavigation { get; set; }
        public Warehouse PkNavigation { get; set; }
    }
}
