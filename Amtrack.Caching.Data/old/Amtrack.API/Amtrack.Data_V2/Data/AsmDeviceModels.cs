using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AsmDeviceModels
    {
        public AsmDeviceModels()
        {
            AsmDevice = new HashSet<AsmDevice>();
        }

        public Guid ModelId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public Guid FkDeviceManufacturerId { get; set; }
        public long Flags { get; set; }

        public AsmDeviceManufacturer FkDeviceManufacturer { get; set; }
        public ICollection<AsmDevice> AsmDevice { get; set; }
    }
}
