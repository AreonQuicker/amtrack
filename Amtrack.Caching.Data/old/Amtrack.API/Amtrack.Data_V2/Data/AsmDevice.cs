using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AsmDevice
    {
        public AsmDevice()
        {
            AsmDeviceNotes = new HashSet<AsmDeviceNotes>();
            AsmDeviceOperators = new HashSet<AsmDeviceOperators>();
        }

        public Guid DeviceId { get; set; }
        public string SerialNumber { get; set; }
        public string AssetTag { get; set; }
        public long DeviceFunctions { get; set; }
        public Guid FkDeviceModelId { get; set; }
        public Guid FkManagerId { get; set; }
        public long Flags { get; set; }

        public AsmDeviceModels FkDeviceModel { get; set; }
        public Users FkManager { get; set; }
        public ICollection<AsmDeviceNotes> AsmDeviceNotes { get; set; }
        public ICollection<AsmDeviceOperators> AsmDeviceOperators { get; set; }
    }
}
