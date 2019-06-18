using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IProductCategoriesView
    {
        void AttachPresenter(ProductCategoriesPresenter presenter);
        List<ProductCategory> ProductCategories { set; }
        ProductCategory SelectedProductCategory { get; }
    }
}
