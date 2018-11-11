﻿using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class MRecipients
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkMessage { get; set; }
        public Guid RecipientId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }

        public MMessage FkMessageNavigation { get; set; }
    }
}