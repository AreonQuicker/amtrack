using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PaymentInfoes
    {
        public PaymentInfoes()
        {
            PaymentInfoData = new HashSet<PaymentInfoData>();
            PaymentInfoProcessResults = new HashSet<PaymentInfoProcessResults>();
        }

        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public string CustomerCode { get; set; }
        public DateTime Date { get; set; }
        public string PaymentReference { get; set; }
        public string AdditionalReference { get; set; }
        public string Provider { get; set; }
        public string Source { get; set; }
        public int AmountCents { get; set; }
        public string PaymentType { get; set; }
        public string PaymentStatus { get; set; }
        public long Flags { get; set; }
        public bool Processed { get; set; }

        public ICollection<PaymentInfoData> PaymentInfoData { get; set; }
        public ICollection<PaymentInfoProcessResults> PaymentInfoProcessResults { get; set; }
    }
}
