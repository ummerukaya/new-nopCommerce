using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Web.Areas.Admin.Models.Catalog;

namespace Nop.Web.Areas.Admin.Factories
{
    public interface IProductCategoryModelFactory
    {
        Task<AddAssociatedProductListModel> PrepareAddAssociatedProductListModelAsync(AddAssociatedProductSearchModel searchModel);
        Task<AddAssociatedProductSearchModel> PrepareAddAssociatedProductSearchModelAsync(AddAssociatedProductSearchModel searchModel);
        Task<AddCrossSellProductListModel> PrepareAddCrossSellProductListModelAsync(AddCrossSellProductSearchModel searchModel);
        Task<AddCrossSellProductSearchModel> PrepareAddCrossSellProductSearchModelAsync(AddCrossSellProductSearchModel searchModel);
        Task<AddRelatedProductListModel> PrepareAddRelatedProductListModelAsync(AddRelatedProductSearchModel searchModel);
        Task<AddRelatedProductSearchModel> PrepareAddRelatedProductSearchModelAsync(AddRelatedProductSearchModel searchModel);
        Task<AddRequiredProductListModel> PrepareAddRequiredProductListModelAsync(AddRequiredProductSearchModel searchModel);
        Task<AddRequiredProductSearchModel> PrepareAddRequiredProductSearchModelAsync(AddRequiredProductSearchModel searchModel);
        Task<AddSpecificationAttributeModel> PrepareAddSpecificationAttributeModelAsync(int productId, int? specificationId);
        Task<AssociatedProductListModel> PrepareAssociatedProductListModelAsync(AssociatedProductSearchModel searchModel, Product product);
        Task<AssociateProductToAttributeValueListModel> PrepareAssociateProductToAttributeValueListModelAsync(AssociateProductToAttributeValueSearchModel searchModel);
        Task<AssociateProductToAttributeValueSearchModel> PrepareAssociateProductToAttributeValueSearchModelAsync(AssociateProductToAttributeValueSearchModel searchModel);
        Task<CrossSellProductListModel> PrepareCrossSellProductListModelAsync(CrossSellProductSearchModel searchModel, Product product);
        Task<ProductAttributeCombinationListModel> PrepareProductAttributeCombinationListModelAsync(ProductAttributeCombinationSearchModel searchModel, Product product);
        Task<ProductAttributeCombinationModel> PrepareProductAttributeCombinationModelAsync(ProductAttributeCombinationModel model, Product product, ProductAttributeCombination productAttributeCombination, bool excludeProperties = false);
        Task<ProductAttributeMappingListModel> PrepareProductAttributeMappingListModelAsync(ProductAttributeMappingSearchModel searchModel, Product product);
        Task<ProductAttributeMappingModel> PrepareProductAttributeMappingModelAsync(ProductAttributeMappingModel model, Product product, ProductAttributeMapping productAttributeMapping, bool excludeProperties = false);
        Task<ProductAttributeValueListModel> PrepareProductAttributeValueListModelAsync(ProductAttributeValueSearchModel searchModel, ProductAttributeMapping productAttributeMapping);
        Task<ProductAttributeValueModel> PrepareProductAttributeValueModelAsync(ProductAttributeValueModel model, ProductAttributeMapping productAttributeMapping, ProductAttributeValue productAttributeValue, bool excludeProperties = false);
        Task<ProductCategoryListModel> PrepareProductCategoryListModelAsync(ProductSearchModel searchModel);
        Task<ProductModel> PrepareProductModelAsync(ProductModel model, Product product, bool excludeProperties = false);
        Task<ProductOrderListModel> PrepareProductOrderListModelAsync(ProductOrderSearchModel searchModel, Product product);
        Task<ProductPictureListModel> PrepareProductPictureListModelAsync(ProductPictureSearchModel searchModel, Product product);
        Task<ProductSearchModel> PrepareProductSearchModelAsync(ProductSearchModel searchModel);
        Task<ProductSpecificationAttributeListModel> PrepareProductSpecificationAttributeListModelAsync(ProductSpecificationAttributeSearchModel searchModel, Product product);
        Task<ProductTagListModel> PrepareProductTagListModelAsync(ProductTagSearchModel searchModel);
        Task<ProductTagModel> PrepareProductTagModelAsync(ProductTagModel model, ProductTag productTag, bool excludeProperties = false);
        Task<ProductTagSearchModel> PrepareProductTagSearchModelAsync(ProductTagSearchModel searchModel);
        Task<RelatedProductListModel> PrepareRelatedProductListModelAsync(RelatedProductSearchModel searchModel, Product product);
        Task<StockQuantityHistoryListModel> PrepareStockQuantityHistoryListModelAsync(StockQuantityHistorySearchModel searchModel, Product product);
        Task<TierPriceListModel> PrepareTierPriceListModelAsync(TierPriceSearchModel searchModel, Product product);
        Task<TierPriceModel> PrepareTierPriceModelAsync(TierPriceModel model, Product product, TierPrice tierPrice, bool excludeProperties = false);
    }
}