using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentBoxMovements
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public long? CurrentLocationId { get; set; }
        public string CurrentLocaitonBarcode { get; set; }
        public string CurrentLocationName { get; set; }
        public int? CurrentLocationStatus { get; set; }
        public int? CurrentLocationType { get; set; }
        public string CurrentLocationBranchCode { get; set; }
        public long ToParentLocationId { get; set; }
        public string ToParentLocationBarcode { get; set; }
        public string ToParentLocationName { get; set; }
        public int? ToParentLocationStatus { get; set; }
        public int? ToParentLocationType { get; set; }
        public string ToParentLocationBranchCode { get; set; }
        public string ToParentLocationInstruction { get; set; }
        public string ToParentLocationInstructionColor { get; set; }
        public string ToParentLocationInstructionNumber { get; set; }
        public string BoxBarcode { get; set; }
        public string BoxName { get; set; }
        public string BoxDocumentNumber { get; set; }
        public string BoxWmsDocumentNumber { get; set; }
        public int? BoxType { get; set; }
        public int? BoxStatus { get; set; }
    }
}
