using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ShipmentCommercialBrandingDocuments
    {
        public ShipmentCommercialBrandingDocuments()
        {
            ShipmentCommercialBrandingDocumentLines = new HashSet<ShipmentCommercialBrandingDocumentLines>();
        }

        public int Id { get; set; }
        public int? FkShipmentId { get; set; }
        public int? FkCommerBrandingDocumentId { get; set; }
        public DateTime Created { get; set; }
        public string SourceCompanyCode { get; set; }
        public string DestinationBranchCode { get; set; }
        public string ParentDocumentNumber { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public CommercialBrandingDocuments FkCommerBrandingDocument { get; set; }
        public Shipments FkShipment { get; set; }
        public ICollection<ShipmentCommercialBrandingDocumentLines> ShipmentCommercialBrandingDocumentLines { get; set; }
    }
}
