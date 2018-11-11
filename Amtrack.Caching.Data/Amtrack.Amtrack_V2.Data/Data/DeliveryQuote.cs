using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryQuote
    {
        public DeliveryQuote()
        {
            DeliveryQuoteDetail = new HashSet<DeliveryQuoteDetail>();
            DeliveryQuoteDocuments = new HashSet<DeliveryQuoteDocuments>();
            DeliveryQuoteItems = new HashSet<DeliveryQuoteItems>();
        }

        public int Id { get; set; }
        public int FkDeliveryProviderId { get; set; }
        public int? FkDeliveryQuoteAddressId { get; set; }
        public int? FkDeliveryQuoteDetailId { get; set; }
        public int? FkAccountContactId { get; set; }
        public string CustomerCode { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Volumetric { get; set; }
        public double Weight { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }

        public DeliveryProvider FkDeliveryProvider { get; set; }
        public DeliveryAddress FkDeliveryQuoteAddress { get; set; }
        public ICollection<DeliveryQuoteDetail> DeliveryQuoteDetail { get; set; }
        public ICollection<DeliveryQuoteDocuments> DeliveryQuoteDocuments { get; set; }
        public ICollection<DeliveryQuoteItems> DeliveryQuoteItems { get; set; }
    }
}
