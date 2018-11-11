using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class RushDocumentDetail
    {
        public long Id { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime Created { get; set; }
        public long? FkRushAccount { get; set; }
        public string Waybill { get; set; }
        public string CourierName { get; set; }
        public string Service { get; set; }
        public DateTime CollectionDate { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
    }
}
