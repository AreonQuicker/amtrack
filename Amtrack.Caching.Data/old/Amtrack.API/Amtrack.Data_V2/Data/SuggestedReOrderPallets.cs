using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SuggestedReOrderPallets
    {
        public Guid WarehouseReOrderId { get; set; }
        public Guid PalletId { get; set; }

        public Pallets Pallet { get; set; }
        public WarehouseReorders WarehouseReOrder { get; set; }
    }
}
