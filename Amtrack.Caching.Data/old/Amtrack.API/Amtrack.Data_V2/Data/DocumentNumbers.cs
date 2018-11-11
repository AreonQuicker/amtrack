﻿using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DocumentNumbers
    {
        public Guid DocumentNumberId { get; set; }
        public short DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public int Value { get; set; }
        public bool Used { get; set; }
        public DateTime? DateIssued { get; set; }
    }
}