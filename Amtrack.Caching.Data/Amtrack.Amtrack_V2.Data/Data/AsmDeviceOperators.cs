﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AsmDeviceOperators
    {
        public Guid FkDeviceId { get; set; }
        public Guid FkOperatorId { get; set; }

        public AsmDevice FkDevice { get; set; }
        public Users FkOperator { get; set; }
    }
}
