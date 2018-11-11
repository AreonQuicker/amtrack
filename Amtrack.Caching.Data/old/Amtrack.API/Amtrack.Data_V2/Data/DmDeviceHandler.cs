using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DmDeviceHandler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Eta { get; set; }
        public string Company { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Created { get; set; }
        public int FkDeviceId { get; set; }

        public DmDevice FkDevice { get; set; }
    }
}
