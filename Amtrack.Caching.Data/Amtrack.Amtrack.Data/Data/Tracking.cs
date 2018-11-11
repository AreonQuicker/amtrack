using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Tracking
    {
        public Tracking()
        {
            BatchTracking = new HashSet<BatchTracking>();
            CreditNoteRequestTracking = new HashSet<CreditNoteRequestTracking>();
            CreditNoteTracking = new HashSet<CreditNoteTracking>();
            DeliveryRequestTracking = new HashSet<DeliveryRequestTracking>();
            EmbroideryQuoteRequestTracking = new HashSet<EmbroideryQuoteRequestTracking>();
            JobCardTracking = new HashSet<JobCardTracking>();
            LocationTracking = new HashSet<LocationTracking>();
            SystemRequestTracking = new HashSet<SystemRequestTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string TypeCode { get; set; }
        public string TrackDate { get; set; }
        public string TrackTime { get; set; }
        public string Description { get; set; }

        public LayoutTracking LayoutTracking { get; set; }
        public OrderTracking OrderTracking { get; set; }
        public ParcelTracking ParcelTracking { get; set; }
        public TerminalTracking TerminalTracking { get; set; }
        public UserTracking UserTracking { get; set; }
        public ICollection<BatchTracking> BatchTracking { get; set; }
        public ICollection<CreditNoteRequestTracking> CreditNoteRequestTracking { get; set; }
        public ICollection<CreditNoteTracking> CreditNoteTracking { get; set; }
        public ICollection<DeliveryRequestTracking> DeliveryRequestTracking { get; set; }
        public ICollection<EmbroideryQuoteRequestTracking> EmbroideryQuoteRequestTracking { get; set; }
        public ICollection<JobCardTracking> JobCardTracking { get; set; }
        public ICollection<LocationTracking> LocationTracking { get; set; }
        public ICollection<SystemRequestTracking> SystemRequestTracking { get; set; }
    }
}
