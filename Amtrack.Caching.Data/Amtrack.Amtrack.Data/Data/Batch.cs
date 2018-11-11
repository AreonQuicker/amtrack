using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Batch
    {
        public Batch()
        {
            BatchTracking = new HashSet<BatchTracking>();
            BatchedBaskets = new HashSet<BatchedBaskets>();
            BatchedBatchFkNavigation = new HashSet<BatchedBatch>();
            BatchedBatchPkNavigation = new HashSet<BatchedBatch>();
            BatchedJobCards = new HashSet<BatchedJobCards>();
            BatchedOrders = new HashSet<BatchedOrders>();
            BatchedParcels = new HashSet<BatchedParcels>();
            BatchedShipments = new HashSet<BatchedShipments>();
            BatchedStock = new HashSet<BatchedStock>();
            ClBatchContents = new HashSet<ClBatchContents>();
            LinkedBatchesBatch = new HashSet<LinkedBatches>();
            ReturnedBatchDetail = new HashSet<ReturnedBatchDetail>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Number { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public string BranchCode { get; set; }
        public string FromBranchCode { get; set; }
        public DateTime? DueDate { get; set; }

        public LinkedBatches LinkedBatchesFkLinkBatch { get; set; }
        public ICollection<BatchTracking> BatchTracking { get; set; }
        public ICollection<BatchedBaskets> BatchedBaskets { get; set; }
        public ICollection<BatchedBatch> BatchedBatchFkNavigation { get; set; }
        public ICollection<BatchedBatch> BatchedBatchPkNavigation { get; set; }
        public ICollection<BatchedJobCards> BatchedJobCards { get; set; }
        public ICollection<BatchedOrders> BatchedOrders { get; set; }
        public ICollection<BatchedParcels> BatchedParcels { get; set; }
        public ICollection<BatchedShipments> BatchedShipments { get; set; }
        public ICollection<BatchedStock> BatchedStock { get; set; }
        public ICollection<ClBatchContents> ClBatchContents { get; set; }
        public ICollection<LinkedBatches> LinkedBatchesBatch { get; set; }
        public ICollection<ReturnedBatchDetail> ReturnedBatchDetail { get; set; }
    }
}
