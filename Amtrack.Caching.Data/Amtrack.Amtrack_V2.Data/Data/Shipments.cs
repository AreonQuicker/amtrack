using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Shipments
    {
        public Shipments()
        {
            ShipmentCommercialBrandingDocuments = new HashSet<ShipmentCommercialBrandingDocuments>();
            ShipmentDetail = new HashSet<ShipmentDetail>();
            ShipmentProcessTracking = new HashSet<ShipmentProcessTracking>();
            ShipmentReservesRecycle = new HashSet<ShipmentReservesRecycle>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public Guid FkCreatedUserId { get; set; }
        public string Number { get; set; }
        public int BranchShipmentType { get; set; }
        public int Status { get; set; }
        public string CommercialInvoiceNumber { get; set; }
        public string SourceCompanyCode { get; set; }
        public string Ponumber { get; set; }
        public string DestinationBranchCode { get; set; }
        public double? Volume { get; set; }
        public double? Value { get; set; }
        public int Flags { get; set; }
        public string CommercialDocumentNumber { get; set; }

        public ICollection<ShipmentCommercialBrandingDocuments> ShipmentCommercialBrandingDocuments { get; set; }
        public ICollection<ShipmentDetail> ShipmentDetail { get; set; }
        public ICollection<ShipmentProcessTracking> ShipmentProcessTracking { get; set; }
        public ICollection<ShipmentReservesRecycle> ShipmentReservesRecycle { get; set; }
    }
}
