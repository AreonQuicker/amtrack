﻿using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ScannedConveyerParcels
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Barcode { get; set; }
        public string Error { get; set; }
        public string Document { get; set; }
    }
}