using System;
using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public interface IOrderReportsView
    {
        List<Customer> Customers { get; set; }
        List<Product> Products { get; set; }
        List<Order> Orders { get; set; }
        DateTime DateTimeFrom { get; set; }
        DateTime DateTimeUntil { get; set; }
        void AttachPresenter(OrderReportsPresenter presenter);
        void AddGraphSeries(Dictionary<string, decimal?> nodes, string seriesName);
    }
}
