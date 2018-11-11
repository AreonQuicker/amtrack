using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchDelivery
    {
        public BranchDelivery()
        {
            BranchDeliveryCourierInfoes = new HashSet<BranchDeliveryCourierInfoes>();
            BranchDeliveryParcels = new HashSet<BranchDeliveryParcels>();
        }

        public long Id { get; set; }
        public string BranchCode { get; set; }
        public string Prefix { get; set; }
        public string DocumentNumber { get; set; }
        public string DeliveryNumber { get; set; }
        public DateTime? HandOverDate { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? DispatchedDateWaitingPoddate { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public int Version { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<BranchDeliveryCourierInfoes> BranchDeliveryCourierInfoes { get; set; }
        public ICollection<BranchDeliveryParcels> BranchDeliveryParcels { get; set; }
    }
}
