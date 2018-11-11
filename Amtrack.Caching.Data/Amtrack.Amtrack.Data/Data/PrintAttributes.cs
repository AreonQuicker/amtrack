using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrintAttributes
    {
        public int Id { get; set; }
        public long FkPrintDepartmentId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public string DbColumnName { get; set; }
        public string Symbol { get; set; }

        public PrintDepartment FkPrintDepartment { get; set; }
    }
}
