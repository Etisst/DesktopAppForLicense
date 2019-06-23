using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst.Desktop.DataAccess
{
    public class ProductDAL
    {
        private WCObject _wc;
        public ProductDAL()
        {
            _wc = AppContext.wc;
        }
        public async Task<List<Product>> GetAllProductsAsync(Dictionary<string, string> dic)
        {
            int pageNumber = 1;
            dic.Add("page", pageNumber.ToString());
            return await _wc.Product.GetAll(dic);
        }

        public async Task DeleteProductByIdAsync(int id)
        {
            await _wc.Product.Delete(id);
        }

    }
}
