using Etisst.Desktop.BussinessLogic.Core;
using Etisst.Desktop.Common;
using System.Windows.Forms;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductTagDetailsPresenter
    {
        #region Private members
        private IProductTagDetailsView _view;
        #endregion
        #region Constructor
        public ProductTagDetailsPresenter(IProductTagDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Methods
        public async void Save(ProductTag productTag)
        {
            if (Validate(productTag))
            {
                if (productTag.id != null && productTag.id > 0)
                {
                    ProductTagsBLL pcBLL = new ProductTagsBLL();
                    await pcBLL.UpdateProductCategory(productTag);
                }
                else
                {
                    ProductTagsBLL pcBLL = new ProductTagsBLL();
                    await pcBLL.AddProductCategory(productTag);
                }
            }
        }
        private bool Validate(ProductTag productTag)
        {
            if (productTag.name == null || string.IsNullOrEmpty(productTag.name))
            {
                MessageBox.Show(AppTranslations.MUST_COMPLETE_ALL_MANDATORY_FIELDS, AppTranslations.PRODUCT_CATEGORY, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }
        #endregion
    }
}
