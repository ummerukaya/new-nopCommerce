using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Admin.Models.Settings;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product model
    /// </summary>
    public partial record ProductCategoryModel : BaseNopEntityModel,
        IAclSupportedModel, ILocalizedModel<ProductCategoryLocalizedModel>
    {
        #region Ctor

        public ProductCategoryModel()
        {
            ProductPictureModels = new List<ProductPictureModel>();
            Locales = new List<ProductCategoryLocalizedModel>();
            
            AddProductPictureModel = new ProductPictureModel();
            AddCategoryPictureModel = new CategoryPictureModel();

            ProductEditorSettingsModel = new ProductEditorSettingsModel();


            SelectedCategoryIds = new List<int>();
            AvailableCategories = new List<SelectListItem>(); 
          
        }

        #endregion

        #region Properties

        // public int Id { get; set; }

        public int CategoryId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public int ProductTypeId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public string ProductTypeName { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        public string ProductName { get; set; }

        [NopResourceDisplayName("Admin.Catalog.ProductCategories.Fields.Name")]
        public string CategoryName { get; set; }

        //picture thumbnail
        [NopResourceDisplayName("Admin.Catalog.Products.Fields.PictureThumbnailUrl")]
        public string ProductPictureThumbnailUrl { get; set; }

        [NopResourceDisplayName("Admin.Catalog.ProductCategories.Fields.PictureThumbnailUrl")]
        public string CategoryPictureThumbnailUrl { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.Sku")]
        public string Sku { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.StockQuantity")]
        public string StockQuantityStr { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.Price")]
        public decimal Price { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.Published")]
        public bool Published { get; set; }

        public IList<ProductCategoryLocalizedModel> Locales { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.ManageInventoryMethod")]
        public int ManageInventoryMethodId { get; set; }

        //ACL (customer roles)
        [NopResourceDisplayName("Admin.Catalog.Products.Fields.AclCustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

  
        //categories
        [NopResourceDisplayName("Admin.Catalog.Products.Fields.Categories")]
        public IList<int> SelectedCategoryIds { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }


        //pictures
        public ProductPictureModel AddProductPictureModel { get; set; }
        public CategoryPictureModel AddCategoryPictureModel { get; set; }
        public IList<ProductPictureModel> ProductPictureModels { get; set; }
        public IList<CategoryPictureModel> CategoryPictureModels { get; set; }

        //editor settings
        public ProductEditorSettingsModel ProductEditorSettingsModel { get; set; }


        #endregion
    }

    public partial record ProductCategoryLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.ShortDescription")]
        public string ShortDescription { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.FullDescription")]
        public string FullDescription { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Products.Fields.SeName")]
        public string SeName { get; set; }
    }
}