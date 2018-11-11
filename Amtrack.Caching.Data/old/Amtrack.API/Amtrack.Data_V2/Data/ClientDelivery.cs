using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ClientDelivery
    {
        public int FkClientContactId { get; set; }
        public int FkClientDeliveryAddressId { get; set; }
        public int FkAccountId { get; set; }

        public ClientContact FkClientContact { get; set; }
        public ClientDeliveryAddress FkClientDeliveryAddress { get; set; }
    }
}
