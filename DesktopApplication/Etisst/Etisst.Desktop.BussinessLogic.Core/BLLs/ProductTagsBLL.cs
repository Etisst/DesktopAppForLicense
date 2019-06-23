using Etisst.Desktop.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BussinessLogic.Core
{
    public class ProductTagsBLL
    {
        public async Task<List<ProductTag>> GetAllProductTagsAsync()
        {
            ProductTagsDAL pcDAL = new ProductTagsDAL();
            return await pcDAL.GetAllProductTagsAsync();
        }

        public async Task DeleteProductTagByIdAsync(int? id)
        {
            ProductTagsDAL pDAL = new ProductTagsDAL();
            int actualId = id ?? default(int);
            await pDAL.DeleteProductTagByIdAsync(actualId);
        }

        public async Task AddProductCategory(ProductTag productTag)
        {
            ProductTagsDAL pDAL = new ProductTagsDAL();
            await pDAL.AddProductTag(productTag);
        }

        public async Task UpdateProductCategory(ProductTag productTag)
        {
            ProductTagsDAL pcDAL = new ProductTagsDAL();
            int id = productTag.id ?? default(int);
            await pcDAL.UpdateProductTag(id, productTag);
        }
    }
}
