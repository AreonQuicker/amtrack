using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrintDepartment
    {
        public PrintDepartment()
        {
            AccountManagerLayoutArtists = new HashSet<AccountManagerLayoutArtists>();
            Machines = new HashSet<Machines>();
            PrintAttributeValues = new HashSet<PrintAttributeValues>();
            PrintAttributes = new HashSet<PrintAttributes>();
            PrintDepartmentQueues = new HashSet<PrintDepartmentQueues>();
            PrintingDepartmentProcesses = new HashSet<PrintingDepartmentProcesses>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public LdmDepartments LdmDepartments { get; set; }
        public PrintDepartmentUsers PrintDepartmentUsers { get; set; }
        public ICollection<AccountManagerLayoutArtists> AccountManagerLayoutArtists { get; set; }
        public ICollection<Machines> Machines { get; set; }
        public ICollection<PrintAttributeValues> PrintAttributeValues { get; set; }
        public ICollection<PrintAttributes> PrintAttributes { get; set; }
        public ICollection<PrintDepartmentQueues> PrintDepartmentQueues { get; set; }
        public ICollection<PrintingDepartmentProcesses> PrintingDepartmentProcesses { get; set; }
    }
}
