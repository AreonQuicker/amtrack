using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class SuggestedReOrderPallets
    {
        public Guid WarehouseReOrderId { get; set; }
        public Guid PalletId { get; set; }

        public Pallets Pallet { get; set; }
        public WarehouseReorders WarehouseReOrder { get; set; }
    }
}
