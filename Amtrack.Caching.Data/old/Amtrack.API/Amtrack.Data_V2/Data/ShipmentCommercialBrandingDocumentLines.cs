using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ShipmentCommercialBrandingDocumentLines
    {
        public int Id { get; set; }
        public int? FkShipmentCommercialBrandingDocumentId { get; set; }
        public int? FkCommerBrandingDocumentId { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }

        public CommercialBrandingDocuments FkCommerBrandingDocument { get; set; }
        public ShipmentCommercialBrandingDocuments FkShipmentCommercialBrandingDocument { get; set; }
    }
}
