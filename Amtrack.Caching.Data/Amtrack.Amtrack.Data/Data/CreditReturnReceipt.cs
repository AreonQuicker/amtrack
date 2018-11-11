using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditReturnReceipt
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public DateTime Modified { get; set; }
        public int? UserCompletedById { get; set; }
        public int? UserBusyId { get; set; }
    }
}
