using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface ICustomerDetailsView
    {
        int CustomerId { get; }
        Customer Customer { get; set; }
        void AttachPresenter(CustomerDetailsPresenter presenter);
    }
}
