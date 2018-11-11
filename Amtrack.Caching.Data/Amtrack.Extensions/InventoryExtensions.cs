using System.Collections.Generic;
using Amtrack.Caching.Data.StockCheckData;
using Amtrack.Enumeration;
using Amtrack.StockCheck.Data.Data;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;

namespace Amtrack.Extensions
{
    public static class InventoryExtensions
    {
        public static GroupVO ToGroupVo(this StockItemGroups itemGroup)
        {
            if(itemGroup == null)
                return null;

            return new GroupVO()
            {
                Id = itemGroup.Id,
                DateCreated = itemGroup.Created,
                DateLastModified = itemGroup.Created,
                Code = itemGroup.Code,
                Name = itemGroup.Name,
                Type = (InventoryGroupType)itemGroup.Type,
                Flags = (InventoryGroupFlags)itemGroup.Flags
            };
        }

        public static PriceListVO ToPriceListVo(this StockPricelists stockPricelist)
        {
            if(stockPricelist == null)
                return null;

            return new PriceListVO()
            {
                CompanyCode = stockPricelist.CompanyCode,
                CurrencyCode = stockPricelist.CurrencyCode,
                CurrencyName = stockPricelist.CurrencyName,
                CurrencySymbol = stockPricelist.CurrencySymbol,
                DateCreated = stockPricelist.Created,
                DateLastModified = stockPricelist.Modified ?? stockPricelist.Created,
                DisplayIndex = stockPricelist.DisplayIndex,
                DisplayName = stockPricelist.DisplayName,
                HostId = stockPricelist.XfxHostId,
                Id = stockPricelist.Id,
                PastelLookup = stockPricelist.PastelLookup,
                DisplayFormat = stockPricelist.DisplayFormat,
                Flags = (PriceListFlags)stockPricelist.Flags
            };
        }

        public static InventoryItemVO ToInventoryItemVo(this stCatalogue stCatalogue, StockItemGroups itemGroup)
        {
            return new InventoryItemVO()
            {
                Id = stCatalogue.InventoryId,
                DateCreated = stCatalogue.Created,
                DateLastModified = stCatalogue.Modified,
                BaseItemCode = stCatalogue.BaseItemCode,
                ItemCode = stCatalogue.ItemCode,
                ALPCategory = stCatalogue.ALPCategory,
                Colour = stCatalogue.Colour,
                Size = stCatalogue.Size,
                DangerousGoods = stCatalogue.DangerouGoods,
                Description = stCatalogue.Description,
                HasSampleQuantityException = stCatalogue.SampleShopQuantityExeption,
                HighValue = stCatalogue.HighValue,
                InventoryType = (InventoryType)stCatalogue.InventoryType,
                InvoiceVisible = stCatalogue.InvoiceItem,
                OnPromotion = stCatalogue.OnPromotion,
                QuoteVisible = stCatalogue.QuoteItem,
                WarehouseItem = stCatalogue.WarehouseItem,
                Flags = (StockInventoryMasterFlags)stCatalogue.InventoryFlags,
                Group = itemGroup?.ToGroupVo(),
                Brands = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BrandVO>>(stCatalogue.Brands)
            };
        }

    }
}

