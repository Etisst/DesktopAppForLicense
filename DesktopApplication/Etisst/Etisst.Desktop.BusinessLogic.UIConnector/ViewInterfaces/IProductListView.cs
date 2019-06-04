using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IProductListView
    {
        void AttachPresenter(ProductListPresenter presenter);
        void SetGrid(List<Product> products);
    }
}
