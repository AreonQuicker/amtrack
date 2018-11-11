using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AsmDeviceManufacturer
    {
        public AsmDeviceManufacturer()
        {
            AsmDeviceModels = new HashSet<AsmDeviceModels>();
        }

        public Guid ManufacturerId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public long Flags { get; set; }

        public ICollection<AsmDeviceModels> AsmDeviceModels { get; set; }
    }
}
