using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ShAccountShippingInfoes
    {
        public string AccountNumber { get; set; }
        public string RamHub { get; set; }
        public string RamHubtype { get; set; }
        public double RamEcminCharge { get; set; }
        public double RamEcmaxWeight { get; set; }
        public double RamEcperKg { get; set; }
        public double RamEcfuelSurcharge { get; set; }
        public double RamEcwaybillSurcharge { get; set; }
    }
}
