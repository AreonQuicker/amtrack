using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class CommercialBrandingDocuments
    {
        public CommercialBrandingDocuments()
        {
            ShipmentCommercialBrandingDocumentLines = new HashSet<ShipmentCommercialBrandingDocumentLines>();
            ShipmentCommercialBrandingDocuments = new HashSet<ShipmentCommercialBrandingDocuments>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string SourceCompanyCode { get; set; }
        public string DestinationBranchCode { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<ShipmentCommercialBrandingDocumentLines> ShipmentCommercialBrandingDocumentLines { get; set; }
        public ICollection<ShipmentCommercialBrandingDocuments> ShipmentCommercialBrandingDocuments { get; set; }
    }
}
