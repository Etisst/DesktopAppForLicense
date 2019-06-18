using Etisst.Desktop.BussinessLogic.Core;
using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductCategoriesPresenter 
    {
        private IProductCategoriesView _view;
        public ProductCategoriesPresenter(IProductCategoriesView view)
        {
            this._view = view;
        }
        public async void InitAsync()
        {
            ProductCategoriesBLL productBLL = new ProductCategoriesBLL();
            _view.ProductCategories = await productBLL.GetAllProductCategoriesAsync();
        }
        public async Task DeleteProductCategoryAsync(int? id)
        {
            ProductCategoriesBLL productBLL = new ProductCategoriesBLL();
            await productBLL.DeleteProductCategoryByIdAsync(id);
        }
    }
}
