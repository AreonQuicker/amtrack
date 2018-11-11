using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockVolumetricBatches
    {
        public StockVolumetricBatches()
        {
            StockVolumetric = new HashSet<StockVolumetric>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string BatchNumber { get; set; }

        public ICollection<StockVolumetric> StockVolumetric { get; set; }
    }
}
