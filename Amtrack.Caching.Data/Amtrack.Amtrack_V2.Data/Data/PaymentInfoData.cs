using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PaymentInfoData
    {
        public int Id { get; set; }
        public int FkPaymentId { get; set; }
        public string InfoKey { get; set; }
        public string InfoValue { get; set; }

        public PaymentInfoes FkPayment { get; set; }
    }
}
