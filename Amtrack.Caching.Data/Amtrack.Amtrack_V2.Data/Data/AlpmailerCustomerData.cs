using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AlpmailerCustomerData
    {
        public int Id { get; set; }
        public int FkMailerId { get; set; }
        public string CustomerCode { get; set; }
        public string AccountName { get; set; }
        public string CurrentStatus { get; set; }
        public double CurrentSpend { get; set; }
        public double CurrentAlp { get; set; }
        public double? Alpmaintain { get; set; }
        public double? Alpupgrade { get; set; }
        public double? CarryOver { get; set; }
        public int? GenerationStatus { get; set; }
    }
}
