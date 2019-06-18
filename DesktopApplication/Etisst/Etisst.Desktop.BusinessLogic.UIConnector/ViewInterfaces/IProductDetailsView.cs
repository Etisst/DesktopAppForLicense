using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IProductDetailsView
    {
        int ProductId { get; }
        Product Product { get; set; }
        List<ProductCategory> ProductCategories { set; }
        void AttachPresenter(ProductDetailsPresenter presenter);
    }
}
