using Etisst.Desktop.BussinessLogic.Core;
using System.Threading.Tasks;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class ProductTagsPresenter
    {
        private IProductTagsView _view;
        public ProductTagsPresenter(IProductTagsView view)
        {
            this._view = view;
        }
        public async void InitAsync()
        {
            ProductTagsBLL tagBLL = new ProductTagsBLL();
            _view.ProductTags = await tagBLL.GetAllProductTagsAsync();
        }
        public async Task DeleteProductTagAsync(int? id)
        {
            ProductTagsBLL tagBLL = new ProductTagsBLL();
            await tagBLL.DeleteProductTagByIdAsync(id);
        }
    }
}
