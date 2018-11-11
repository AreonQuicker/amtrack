using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrintAttributeValues
    {
        public int Id { get; set; }
        public long FkPrintDepartmentId { get; set; }
        public string ItemCode { get; set; }
        public string Position { get; set; }
        public string Material { get; set; }
        public string Ink { get; set; }
        public string Hardner { get; set; }
        public string Reduser { get; set; }
        public string Primer { get; set; }
        public string CuringMethod { get; set; }
        public double? CuringTemperature { get; set; }
        public double? CuringTime { get; set; }
        public string Comment { get; set; }

        public PrintDepartment FkPrintDepartment { get; set; }
    }
}
