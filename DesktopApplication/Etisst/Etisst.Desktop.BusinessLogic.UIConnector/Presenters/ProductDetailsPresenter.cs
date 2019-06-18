using Etisst.Desktop.BussinessLogic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductDetailsPresenter
    {
        private IProductDetailsView _view;
        public ProductDetailsPresenter(IProductDetailsView view)
        {
            this._view = view;
        }

        public async Task InitAsync()
        {
            ProductCategoriesBLL pcBLL = new ProductCategoriesBLL();
            _view.ProductCategories = await pcBLL.GetAllProductCategoriesAsync();
        }
    }
}
