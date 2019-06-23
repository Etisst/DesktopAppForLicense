using Etisst.Desktop.BussinessLogic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductDetailsPresenter
    {
        #region Private members
        private IProductDetailsView _view;
        #endregion
        #region Constructor
        public ProductDetailsPresenter(IProductDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Methods
        public async Task InitAsync()
        {
            ProductCategoriesBLL pcBLL = new ProductCategoriesBLL();
            ProductTagsBLL ptBLL = new ProductTagsBLL();
            _view.ProductCategories = await pcBLL.GetAllProductCategoriesAsync();
            _view.ProductTags = await ptBLL.GetAllProductTagsAsync();
        }
        #endregion

    }
}
