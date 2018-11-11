using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Documents
    {
        public Documents()
        {
            DeliveryWaybill = new HashSet<DeliveryWaybill>();
            DeliveryWaybillDetail = new HashSet<DeliveryWaybillDetail>();
            DocumentBoxes = new HashSet<DocumentBoxes>();
            DocumentPallet = new HashSet<DocumentPallet>();
            LineDisplay = new HashSet<LineDisplay>();
            Lines = new HashSet<Lines>();
            PickingSlips = new HashSet<PickingSlips>();
        }

        public Guid DocumentId { get; set; }
        public short DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public short DocumentVersion { get; set; }
        public double TotalExcl { get; set; }
        public double TotalIncl { get; set; }
        public double Tax { get; set; }
        public long Status { get; set; }
        public string Warehouse { get; set; }
        public string CustomerReference { get; set; }
        public string CustomerCode { get; set; }
        public string SalesmanCode { get; set; }
        public DateTime? Created { get; set; }
        public long Flags { get; set; }
        public long? ExceptionFlags { get; set; }

        public ICollection<DeliveryWaybill> DeliveryWaybill { get; set; }
        public ICollection<DeliveryWaybillDetail> DeliveryWaybillDetail { get; set; }
        public ICollection<DocumentBoxes> DocumentBoxes { get; set; }
        public ICollection<DocumentPallet> DocumentPallet { get; set; }
        public ICollection<LineDisplay> LineDisplay { get; set; }
        public ICollection<Lines> Lines { get; set; }
        public ICollection<PickingSlips> PickingSlips { get; set; }
    }
}
