using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IOrderDetailsView
    {
        int OrderId { get; }
        Order Order { get; set; }
        void AttachPresenter(OrderDetailsPresenter presenter);
        Customer Customer { set; }
        bool SetAvailability { set; }
    }
}
