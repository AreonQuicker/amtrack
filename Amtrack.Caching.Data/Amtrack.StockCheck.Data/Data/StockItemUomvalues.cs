using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemUomvalues
    {
        public StockItemUomvalues()
        {
            InverseFkParentUom = new HashSet<StockItemUomvalues>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemUomid { get; set; }
        public int FkItemUomtemplateId { get; set; }
        public int? FkParentUomid { get; set; }
        public int BaseQuantity { get; set; }
        public int Quantity { get; set; }
        public double DimWidth { get; set; }
        public double DimHeight { get; set; }
        public double DimLength { get; set; }
        public double Weight { get; set; }
        public string UnitsDims { get; set; }
        public string UnitsWeight { get; set; }
        public int Flags { get; set; }

        public StockItemUom FkItemUom { get; set; }
        public StockItemUomtemplates FkItemUomtemplate { get; set; }
        public StockItemUomvalues FkParentUom { get; set; }
        public ICollection<StockItemUomvalues> InverseFkParentUom { get; set; }
    }
}
