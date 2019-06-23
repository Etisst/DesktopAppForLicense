using Etisst.Desktop.BussinessLogic.Core;
using System.Threading.Tasks;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class OrderListPresenter
    {
        private IOrderListView _view;
        public OrderListPresenter(IOrderListView view)
        {
            this._view = view;
        }
        public async void InitAsync()
        {
            OrderBLL orderBLL = new OrderBLL();
            _view.Orders = await orderBLL.GetAllProductsAsync();
        }
    }
}
