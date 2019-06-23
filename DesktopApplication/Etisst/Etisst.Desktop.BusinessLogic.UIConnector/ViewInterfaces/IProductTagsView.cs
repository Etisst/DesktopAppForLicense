using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IProductTagsView
    {
        void AttachPresenter(ProductTagsPresenter presenter);
        List<ProductTag> ProductTags { set; }
        ProductTag SelectedProductTag { get; }
    }
}
