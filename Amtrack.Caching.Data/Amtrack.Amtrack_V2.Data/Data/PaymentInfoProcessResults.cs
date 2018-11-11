using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PaymentInfoProcessResults
    {
        public int Id { get; set; }
        public int FkPaymentId { get; set; }
        public DateTime Created { get; set; }
        public int ProcessType { get; set; }
        public bool ProcessResult { get; set; }
        public string ResultMessage { get; set; }

        public PaymentInfoes FkPayment { get; set; }
    }
}
