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
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("per_page", "100");
            return await pDAL.GetAllProductsAsync(dic);
        }

        public async Task DeleteProductByIdAsync(int? id)
        {
            ProductDAL pDAL = new ProductDAL();
            int actualId = id ?? default(int);
            await pDAL.DeleteProductByIdAsync(actualId);
        }
    }
}
