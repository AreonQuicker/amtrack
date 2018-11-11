using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PickingSlips
    {
        public PickingSlips()
        {
            PickingInstructions = new HashSet<PickingInstructions>();
            PickingSlipMovements = new HashSet<PickingSlipMovements>();
            PickingSlipReservedStocks = new HashSet<PickingSlipReservedStocks>();
        }

        public Guid PickingSlipId { get; set; }
        public DateTime Created { get; set; }
        public string Barcode { get; set; }
        public string PickingSlipNumber { get; set; }
        public long Status { get; set; }
        public Guid DocumentDocumentId { get; set; }

        public Documents DocumentDocument { get; set; }
        public ICollection<PickingInstructions> PickingInstructions { get; set; }
        public ICollection<PickingSlipMovements> PickingSlipMovements { get; set; }
        public ICollection<PickingSlipReservedStocks> PickingSlipReservedStocks { get; set; }
    }
}
