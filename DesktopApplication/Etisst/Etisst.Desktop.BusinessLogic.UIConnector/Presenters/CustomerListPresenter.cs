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
        public async Task DeleteProductAsync(int? id)
        {
            //OrderBLL orderBLL = new OrderBLL();
            //await orderBLL.DeleteProductByIdAsync(id);
        }
    }
}
