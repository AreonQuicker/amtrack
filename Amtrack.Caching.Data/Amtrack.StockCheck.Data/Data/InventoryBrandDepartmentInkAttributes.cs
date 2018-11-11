using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventoryBrandDepartmentInkAttributes
    {
        public string ItemCode { get; set; }
        public string BrandingPosition { get; set; }
        public string Ink { get; set; }
        public string Hardner { get; set; }
        public string Reduser { get; set; }
        public string Primer { get; set; }
        public string CuringMethod { get; set; }
        public int? CuringTemp { get; set; }
        public int? CuringTime { get; set; }
        public int PrintDepartment { get; set; }
        public string Material { get; set; }
    }
}
