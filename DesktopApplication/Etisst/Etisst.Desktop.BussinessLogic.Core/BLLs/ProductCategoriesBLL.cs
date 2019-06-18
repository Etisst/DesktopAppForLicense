using Etisst.Desktop.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BussinessLogic.Core
{
    public class ProductCategoriesBLL
    {
        public async Task<List<ProductCategory>> GetAllProductCategoriesAsync()
        {
            ProductCategoriesDAL pcDAL = new ProductCategoriesDAL();
            return await pcDAL.GetAllProductCategoriesAsync();
        }

        public async Task DeleteProductCategoryByIdAsync(int? id)
        {
            ProductCategoriesDAL pDAL = new ProductCategoriesDAL();
            int actualId = id ?? default(int);
            await pDAL.DeleteProductCategoryByIdAsync(actualId);
        }

        public async Task AddProductCategory(ProductCategory productCategory)
        {
            ProductCategoriesDAL pDAL = new ProductCategoriesDAL();
            await pDAL.AddProductCategory(productCategory);
        }

        public async Task UpdateProductCategory(ProductCategory productCategory)
        {
            ProductCategoriesDAL pcDAL = new ProductCategoriesDAL();
            int id = productCategory.id ?? default(int);
            await pcDAL.UpdateProductCategory(id, productCategory);
        }
    }
}
