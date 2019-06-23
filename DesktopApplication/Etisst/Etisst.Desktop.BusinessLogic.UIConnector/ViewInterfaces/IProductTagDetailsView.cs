using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IProductTagDetailsView
    {
        int ProductTagId { get; }
        ProductTag ProductTag { get; set; }
        void AttachPresenter(ProductTagDetailsPresenter presenter);
    }
}
