using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemMaster
    {
        public StockItemMaster()
        {
            StockItemAttributes = new HashSet<StockItemAttributes>();
            StockItemBranchAttributes = new HashSet<StockItemBranchAttributes>();
            StockItemBranchShippingMethods = new HashSet<StockItemBranchShippingMethods>();
            StockItemBrandMatrix = new HashSet<StockItemBrandMatrix>();
            StockItemCosts = new HashSet<StockItemCosts>();
            StockItemLevel = new HashSet<StockItemLevel>();
            StockItemPriceMatrix = new HashSet<StockItemPriceMatrix>();
            StockItemPublication = new HashSet<StockItemPublication>();
            StockItemUom = new HashSet<StockItemUom>();
            StockItemValidation = new HashSet<StockItemValidation>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int? FkParentItemId { get; set; }
        public int FkGroupId { get; set; }
        public string ItemCode { get; set; }
        public string BaseItemCode { get; set; }
        public string Description { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
        public int? InventoryType { get; set; }
        public int Flags { get; set; }

        public StockItemGroups FkGroup { get; set; }
        public StockItemInventoryTypes InventoryTypeNavigation { get; set; }
        public ICollection<StockItemAttributes> StockItemAttributes { get; set; }
        public ICollection<StockItemBranchAttributes> StockItemBranchAttributes { get; set; }
        public ICollection<StockItemBranchShippingMethods> StockItemBranchShippingMethods { get; set; }
        public ICollection<StockItemBrandMatrix> StockItemBrandMatrix { get; set; }
        public ICollection<StockItemCosts> StockItemCosts { get; set; }
        public ICollection<StockItemLevel> StockItemLevel { get; set; }
        public ICollection<StockItemPriceMatrix> StockItemPriceMatrix { get; set; }
        public ICollection<StockItemPublication> StockItemPublication { get; set; }
        public ICollection<StockItemUom> StockItemUom { get; set; }
        public ICollection<StockItemValidation> StockItemValidation { get; set; }
    }
}
