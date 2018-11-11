using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WarehouseEntityMovements
    {
        public Guid EntityId { get; set; }
        public string EntityType { get; set; }
        public Guid MovementId { get; set; }
        public string MovementCode { get; set; }
        public string MovementDetails { get; set; }
        public string MovementActionarCode { get; set; }
        public DateTime MovementDate { get; set; }
        public Guid? LocationFromId { get; set; }
        public Guid? LocationToId { get; set; }
        public int Status { get; set; }
    }
}
