using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst.Desktop.DataAccess
{
    public class ProductCategoriesDAL
    {
        private WCObject _wc;
        public ProductCategoriesDAL()
        {
            _wc = AppContext.wc;
        }
        public async Task<List<ProductCategory>> GetAllProductCategoriesAsync()
        {
            return await _wc.Category.GetAll();
        }
        public async Task DeleteProductCategoryByIdAsync(int id)
        {
            await _wc.Category.Delete(id,true);
        }
        public async Task AddProductCategory(ProductCategory productCategory)
        {
            await _wc.Category.Add(productCategory);
        }
        public async Task UpdateProductCategory(int id,ProductCategory productCategory)
        {
            await _wc.Category.Update(id, productCategory);
        }
    }
}
