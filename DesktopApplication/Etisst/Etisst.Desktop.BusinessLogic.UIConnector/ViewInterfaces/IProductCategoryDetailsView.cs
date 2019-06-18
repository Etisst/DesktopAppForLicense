using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IProductCategoryDetailsView
    {
        int ProductCategoryId { get; }
        ProductCategory ProductCategory { get; set; }
        void AttachPresenter(ProductCategoryDetailsPresenter presenter);
    }
}
