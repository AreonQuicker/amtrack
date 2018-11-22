using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WdbActiveJobcards
    {
        public string JobCardNumber { get; set; }
        public long JobCardId { get; set; }
        public DateTime JobCardDate { get; set; }
        public string AccountNumber { get; set; }
        public string DocumentNumber { get; set; }
        public long OrderId { get; set; }
        public string CustomerReference { get; set; }
        public DateTime DocumentDate { get; set; }
        public string JobCardStatusText { get; set; }
        public long JobCardStatus { get; set; }
        public string PrintProcessCode { get; set; }
        public string PrintProcessDescription { get; set; }
        public string PrintDepartment { get; set; }
        public int PrintColours { get; set; }
        public string PrintStockItem { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Brand { get; set; }
        public DateTime? DueDate { get; set; }
        public int? LeadTime { get; set; }
    }
}
