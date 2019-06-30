using Etisst.Desktop.BussinessLogic.Core;
using System.Threading.Tasks;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class CustomerListPresenter
    {
        private ICustomerListView _view;
        public CustomerListPresenter(ICustomerListView view)
        {
            this._view = view;
        }
        public async void InitAsync()
        {
            CustomerBLL customerBLL = new CustomerBLL();
            _view.Customers = await customerBLL.GetAllCustomersAsync();
        }
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task DeleteProductAsync(int? id)
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
            //OrderBLL orderBLL = new OrderBLL();
            //await orderBLL.DeleteProductByIdAsync(id);
        }
    }
}
