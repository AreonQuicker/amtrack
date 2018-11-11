using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryWaybill
    {
        public DeliveryWaybill()
        {
            DeliveryWaybillDetail = new HashSet<DeliveryWaybillDetail>();
            DeliveryWaybillTracking = new HashSet<DeliveryWaybillTracking>();
            InverseFkHistory = new HashSet<DeliveryWaybill>();
        }

        public int Id { get; set; }
        public int? FkHistoryId { get; set; }
        public int? FkAccountContactId { get; set; }
        public Guid? FkDocumentId { get; set; }
        public int FkDeliveryProviderId { get; set; }
        public int? FkDeliveryWaybillAddressId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string QuoteNumber { get; set; }
        public string OrderNumber { get; set; }
        public string Courier { get; set; }
        public string Service { get; set; }
        public double QuotePrice { get; set; }
        public double? BookingPrice { get; set; }
        public double? ProviderPrice { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public int? QuoteEstDeliveryDate { get; set; }
        public int? BookingEstDeliveryDate { get; set; }
        public DateTime? ProviderEta { get; set; }
        public DateTime? Etadate { get; set; }
        public string Number { get; set; }
        public string ProviderNumber { get; set; }
        public string QuoteLeadTime { get; set; }
        public int? FkWaybillCourierDetailsId { get; set; }

        public AccountContacts FkAccountContact { get; set; }
        public DeliveryProvider FkDeliveryProvider { get; set; }
        public DeliveryAddress FkDeliveryWaybillAddress { get; set; }
        public Documents FkDocument { get; set; }
        public DeliveryWaybill FkHistory { get; set; }
        public ICollection<DeliveryWaybillDetail> DeliveryWaybillDetail { get; set; }
        public ICollection<DeliveryWaybillTracking> DeliveryWaybillTracking { get; set; }
        public ICollection<DeliveryWaybill> InverseFkHistory { get; set; }
    }
}
