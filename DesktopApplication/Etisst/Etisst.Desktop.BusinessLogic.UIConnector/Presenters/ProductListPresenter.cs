using System;
using System.Collections.Generic;
using Etisst.Desktop.Common;
using System.Threading.Tasks;
using AppContext = Etisst.Desktop.Common.AppContext;
using WooCommerceNET.WooCommerce.v3;
using Etisst.Desktop.BussinessLogic.Core;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductListPresenter
    {
        private IProductListView _view;
        public ProductListPresenter(IProductListView view)
        {
            this._view = view;
        }
        public async void InitAsync()
        {
            ProductBLL productBLL = new ProductBLL();
                _view.Products= await productBLL.GetAllProductsAsync();
        }
        public async Task DeleteProductAsync(int? id)
        {
            ProductBLL productBLL = new ProductBLL();
            await productBLL.DeleteProductByIdAsync(id);
        }
    }
}
