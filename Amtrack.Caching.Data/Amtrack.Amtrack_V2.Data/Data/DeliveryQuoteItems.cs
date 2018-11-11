﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryQuoteItems
    {
        public int Id { get; set; }
        public int FkDeliveryQuoteId { get; set; }
        public DateTime Created { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }

        public DeliveryQuote FkDeliveryQuote { get; set; }
    }
}