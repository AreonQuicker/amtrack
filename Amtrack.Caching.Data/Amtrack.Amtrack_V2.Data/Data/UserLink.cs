﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class UserLink
    {
        public Guid FkPrimaryUserId { get; set; }
        public Guid FkLinkUserId { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
    }
}