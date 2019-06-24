using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IOrderListView
    {
        List<Order> Orders { get; set; }
        Order SelectedOrder { get; }
        void AttachPresenter(OrderListPresenter presenter);
    }
}
