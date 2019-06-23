using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst.Desktop.DataAccess
{
    public class ProductTagsDAL
    {
        private WCObject _wc;
        public ProductTagsDAL()
        {
            _wc = AppContext.wc;
        }
        public async Task<List<ProductTag>> GetAllProductTagsAsync()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("per_page", "100");
            int pageNumber = 1;
            dic.Add("page", pageNumber.ToString());
            return await _wc.Tag.GetAll(dic);
        }
        public async Task DeleteProductTagByIdAsync(int id)
        {
            await _wc.Tag.Delete(id, true);
        }
        public async Task AddProductTag(ProductTag productTag)
        {
            await _wc.Tag.Add(productTag);
        }
        public async Task UpdateProductTag(int id, ProductTag productTag)
        {
            await _wc.Tag.Update(id, productTag);
        }
    }
}
