using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WarehouseReorders
    {
        public WarehouseReorders()
        {
            SuggestedReOrderPallets = new HashSet<SuggestedReOrderPallets>();
        }

        public Guid WarehouseId { get; set; }
        public string ItemCode { get; set; }
        public DateTime DateIssued { get; set; }
        public Guid ReOrderId { get; set; }

        public ICollection<SuggestedReOrderPallets> SuggestedReOrderPallets { get; set; }
    }
}
