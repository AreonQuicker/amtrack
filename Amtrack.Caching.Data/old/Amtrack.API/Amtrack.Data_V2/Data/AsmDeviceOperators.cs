using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AsmDeviceOperators
    {
        public Guid FkDeviceId { get; set; }
        public Guid FkOperatorId { get; set; }

        public AsmDevice FkDevice { get; set; }
        public Users FkOperator { get; set; }
    }
}
