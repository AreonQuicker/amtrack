using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PartialCollectionDetail
    {
        public long OrderId { get; set; }
        public string ItemCode { get; set; }
        public int QuantityCollected { get; set; }
        public int QuantityAvailableForCollection { get; set; }
    }
}
