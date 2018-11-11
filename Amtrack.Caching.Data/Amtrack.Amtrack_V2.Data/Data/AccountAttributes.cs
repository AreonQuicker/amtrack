﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AccountAttributes
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkAccountId { get; set; }
        public int FkAttributeTemplateId { get; set; }
        public long? NumericValue { get; set; }
        public string StringValue { get; set; }
        public double? FloatValue { get; set; }
        public bool? BoolValue { get; set; }
        public string TextValue { get; set; }
        public int Flags { get; set; }

        public Accounts FkAccount { get; set; }
        public AccountAttributeTemplates FkAttributeTemplate { get; set; }
    }
}
