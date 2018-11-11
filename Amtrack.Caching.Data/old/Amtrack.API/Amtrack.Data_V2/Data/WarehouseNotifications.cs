using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WarehouseNotifications
    {
        public Guid NotificationId { get; set; }
        public short Type { get; set; }
        public string RecipientEmail { get; set; }
        public Guid WarehouseId { get; set; }
        public Guid? RecipientId { get; set; }
        public bool IncludeExclude { get; set; }
        public short RecipientType { get; set; }

        public Warehouses Warehouse { get; set; }
    }
}
