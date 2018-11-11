using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryWaybillDetail
    {
        public int Id { get; set; }
        public int FkDeliveryWaybillId { get; set; }
        public Guid? FkDocumentId { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public double QuoteVolumetric { get; set; }
        public double QuoteWeight { get; set; }
        public double? BookedVolumetric { get; set; }
        public double? BookedWeight { get; set; }
        public int QuoteVolumetricCalculationFlags { get; set; }
        public int? BookedVolumetricCalculationFlags { get; set; }

        public DeliveryWaybill FkDeliveryWaybill { get; set; }
        public Documents FkDocument { get; set; }
    }
}
