using Etisst.Desktop.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
