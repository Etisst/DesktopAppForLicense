using System;
using System.Collections.Generic;
using Etisst.Desktop.Common;
using System.Threading.Tasks;
using AppContext = Etisst.Desktop.Common.AppContext;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductListPresenter
    {
        private IProductListView _view;
        private WCObject _wc;
        private List<Product> _products;
        public ProductListPresenter(IProductListView view)
        {
            this._wc = AppContext.wc;
            this._view = view;
        }
        public async void InitAsync()
        {
            await this.GetAllProductsAsync();
                _view.SetGrid(_products);
        }

        private async Task GetAllProductsAsync()
        {
            _products = await _wc.Product.GetAll();
        }

    }
}
