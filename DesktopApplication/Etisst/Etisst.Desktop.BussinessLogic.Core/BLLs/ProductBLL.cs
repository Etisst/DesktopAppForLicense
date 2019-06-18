using Etisst.Desktop.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BussinessLogic.Core
{
    public class ProductBLL
    {
        public async Task<List<Product>> GetAllProductsAsync()
        {
            ProductDAL pDAL = new ProductDAL();
            return await pDAL.GetAllProductsAsync();
        }

        public async Task DeleteProductByIdAsync(int? id)
        {
            ProductDAL pDAL = new ProductDAL();
            int actualId = id ?? default(int);
            await pDAL.DeleteProductByIdAsync(actualId);
        }
    }
}
