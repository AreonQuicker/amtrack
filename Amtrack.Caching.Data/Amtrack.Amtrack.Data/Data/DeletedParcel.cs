using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class DeletedParcel
    {
        public long ParcelId { get; set; }
        public long OrderId { get; set; }
        public long? JobCardId { get; set; }
        public long? LocationId { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
