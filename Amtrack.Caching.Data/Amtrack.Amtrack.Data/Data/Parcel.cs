using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Parcel
    {
        public Parcel()
        {
            BatchedParcels = new HashSet<BatchedParcels>();
            CreditNotePackaging = new HashSet<CreditNotePackaging>();
            ParcelTracking = new HashSet<ParcelTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Barcode { get; set; }
        public int Number { get; set; }
        public string DisplayNumber { get; set; }
        public double Weight { get; set; }
        public int Status { get; set; }

        public Packaging Packaging { get; set; }
        public ParcelLocations ParcelLocations { get; set; }
        public ICollection<BatchedParcels> BatchedParcels { get; set; }
        public ICollection<CreditNotePackaging> CreditNotePackaging { get; set; }
        public ICollection<ParcelTracking> ParcelTracking { get; set; }
    }
}
