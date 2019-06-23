using Etisst.Desktop.BussinessLogic.Core;
using Etisst.Desktop.Common;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class OrderDetailsPresenter
    {
        #region Private members
        private IOrderDetailsView _view;
        #endregion
        #region Constructor
        public OrderDetailsPresenter(IOrderDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Methods
        public async void InitAsync()
        {
            CustomerBLL customerBLL = new CustomerBLL();
            _view.SetAvailability = _view.Order.status == Enums.OrderStatus.processing.ToString();
            _view.Customer = await customerBLL.GetCustomerByIdAsync(_view.Order.customer_id);
        }
        public async void ConfirmOrderAsync()
        {
            OrderBLL orderBLL = new OrderBLL();
            await orderBLL.ConfirmOrderAsync(_view.Order.id);
        }
        public async void RejectOrderAsync()
        {
            OrderBLL orderBLL = new OrderBLL();
            await orderBLL.RejectOrderAsync(_view.Order.id);
        }
        #endregion
    }
}
