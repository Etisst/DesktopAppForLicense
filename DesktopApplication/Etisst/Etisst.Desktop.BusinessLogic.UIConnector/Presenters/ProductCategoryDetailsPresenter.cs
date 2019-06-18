using Etisst.Desktop.BussinessLogic.Core;
using Etisst.Desktop.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductCategoryDetailsPresenter
    {
        private IProductCategoryDetailsView _view;
        public ProductCategoryDetailsPresenter(IProductCategoryDetailsView view)
        {
            this._view = view;
        }

        public async void Save(ProductCategory productCategory)
        {
            if (Validate(productCategory))
            {
                if (productCategory.id != null && productCategory.id > 0)
                {
                    ProductCategoriesBLL pcBLL = new ProductCategoriesBLL();
                    await pcBLL.UpdateProductCategory(productCategory);
                }
                else
                {
                    ProductCategoriesBLL pcBLL = new ProductCategoriesBLL();
                    await pcBLL.AddProductCategory(productCategory);
                }
            }
        }

        private bool Validate(ProductCategory productCategory)
        {
            if (productCategory.name == null || string.IsNullOrEmpty(productCategory.name))
            {
                MessageBox.Show( AppTranslations.MUST_COMPLETE_ALL_MANDATORY_FIELDS, AppTranslations.PRODUCT_CATEGORY, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }
    }
}
