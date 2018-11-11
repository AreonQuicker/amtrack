using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentBoxes
    {
        public WmsDocumentBoxes()
        {
            InverseFkWmsDocumentBoxMaster = new HashSet<WmsDocumentBoxes>();
            PodCollectionNoteBoxInfo = new HashSet<PodCollectionNoteBoxInfo>();
            ReworkBoxes = new HashSet<ReworkBoxes>();
            ShipmentDetail = new HashSet<ShipmentDetail>();
            WmsDocumentBoxDetail = new HashSet<WmsDocumentBoxDetail>();
            WmsDocumentBoxInfo = new HashSet<WmsDocumentBoxInfo>();
            WmsDocumentBoxLinks = new HashSet<WmsDocumentBoxLinks>();
            WmsDocumentBoxTracking = new HashSet<WmsDocumentBoxTracking>();
        }

        public long Id { get; set; }
        public long? FkWmsDocumentBoxMasterId { get; set; }
        public DateTime Created { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public long? FkLocationId { get; set; }
        public string LocationName { get; set; }
        public int BoxSource { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
        public int SwadinfoCounter { get; set; }
        public long? TempFkWmsDocumentId { get; set; }

        public WmsDocumentBoxes FkWmsDocumentBoxMaster { get; set; }
        public ICollection<WmsDocumentBoxes> InverseFkWmsDocumentBoxMaster { get; set; }
        public ICollection<PodCollectionNoteBoxInfo> PodCollectionNoteBoxInfo { get; set; }
        public ICollection<ReworkBoxes> ReworkBoxes { get; set; }
        public ICollection<ShipmentDetail> ShipmentDetail { get; set; }
        public ICollection<WmsDocumentBoxDetail> WmsDocumentBoxDetail { get; set; }
        public ICollection<WmsDocumentBoxInfo> WmsDocumentBoxInfo { get; set; }
        public ICollection<WmsDocumentBoxLinks> WmsDocumentBoxLinks { get; set; }
        public ICollection<WmsDocumentBoxTracking> WmsDocumentBoxTracking { get; set; }
    }
}
