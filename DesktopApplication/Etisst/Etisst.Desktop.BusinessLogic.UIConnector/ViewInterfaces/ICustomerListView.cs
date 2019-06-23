using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;
namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface ICustomerListView
    {
        List<Customer> Customers { set; }
        void AttachPresenter(CustomerListPresenter presenter);
    }
}
