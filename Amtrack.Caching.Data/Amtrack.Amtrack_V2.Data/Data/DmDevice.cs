using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DmDevice
    {
        public DmDevice()
        {
            DmDeviceHandler = new HashSet<DmDeviceHandler>();
            DmDeviceLogBook = new HashSet<DmDeviceLogBook>();
            DmDeviceRotation = new HashSet<DmDeviceRotation>();
            DmDeviceTracking = new HashSet<DmDeviceTracking>();
        }

        public int DeviceId { get; set; }
        public string Udid { get; set; }
        public string SerialNumber { get; set; }
        public string Platform { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? PurchasedDate { get; set; }
        public int Status { get; set; }
        public int Location { get; set; }
        public int Flags { get; set; }
        public DateTime Created { get; set; }
        public string Ipaddress { get; set; }
        public string Macaddress { get; set; }
        public int? OsmajorVersion { get; set; }
        public int? OsminorVersion { get; set; }
        public string Wap { get; set; }
        public int AmtrackMajorVersion { get; set; }
        public int AmtrackMinorVersion { get; set; }
        public int AmtrackBuildVersion { get; set; }

        public ICollection<DmDeviceHandler> DmDeviceHandler { get; set; }
        public ICollection<DmDeviceLogBook> DmDeviceLogBook { get; set; }
        public ICollection<DmDeviceRotation> DmDeviceRotation { get; set; }
        public ICollection<DmDeviceTracking> DmDeviceTracking { get; set; }
    }
}
