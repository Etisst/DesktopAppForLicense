using System;
using System.Collections.Generic;
using System.Linq;
using Etisst.Desktop.Common;
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
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _wc.Product.GetAll();
        }
        
    }
}
