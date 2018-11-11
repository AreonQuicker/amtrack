using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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
