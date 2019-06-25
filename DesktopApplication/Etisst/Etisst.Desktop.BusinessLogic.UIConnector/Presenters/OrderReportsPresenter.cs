using Etisst.Desktop.BussinessLogic.Core;
using Etisst.Desktop.Common;
using System.Collections.Generic;
using System.Linq;
using WooCommerceNET.WooCommerce.v2;
namespace Etisst.Desktop.BusinessLogic.UIConnector
{
    public class OrderReportsPresenter
    {
        #region Private members
        private IOrderReportsView _view;
        #endregion
        #region Constructor
        public OrderReportsPresenter(IOrderReportsView view)
        {
            this._view = view;
        }
        #endregion
        public async void InitAsync()
        {
            ProductBLL pBLL = new ProductBLL();
            CustomerBLL cBLL = new CustomerBLL();
            _view.Products = await pBLL.GetAllProductsAsync();
            _view.Customers = await cBLL.GetAllCustomersAsync();
        }

        public void AddProductNameReport()
        {
            var line_items = _view.Orders.Where(o => o.status != Enums.OrderStatus.cancelled.ToString()).Select(o => o.line_items).ToList();
            Dictionary<int?, decimal?> nodes = new Dictionary<int?, decimal?>();
            foreach (WooCommerceNET.WooCommerce.v3.Product product in _view.Products)
            {
                nodes.Add(product.id, 0);
            }

            foreach (List<OrderLineItem> orderLineItems in line_items)
            {
                foreach (OrderLineItem orderLineItem in orderLineItems)
                {
                    nodes[orderLineItem.product_id] += orderLineItem.quantity;
                }
            }
            Dictionary<string, decimal?> userFriendlyNodes = new Dictionary<string, decimal?>();
            foreach (WooCommerceNET.WooCommerce.v3.Product product in _view.Products)
            {
                userFriendlyNodes.Add(product.name, nodes[product.id].Value);

            }
            _view.AddGraphSeries(userFriendlyNodes, "Product name");
        }

        public void AddCustomersReport()
        {
            Dictionary<int?, decimal?> nodes = new Dictionary<int?, decimal?>();
            foreach (WooCommerceNET.WooCommerce.v3.Customer customer in _view.Customers)
            {
                nodes.Add(customer.id, 0);
            }
            nodes.Add(0, 0);

            foreach (Order order in _view.Orders)
            {
                    nodes[order.customer_id] ++;
            }
            Dictionary<string, decimal?> userFriendlyNodes = new Dictionary<string, decimal?>();
            foreach (WooCommerceNET.WooCommerce.v3.Customer customer in _view.Customers)
            {
                if (customer.id > 0)
                {
                    userFriendlyNodes.Add(customer.username, nodes[customer.id].Value);
                }
            }
            userFriendlyNodes.Add("Others", nodes[0].Value);
            _view.AddGraphSeries(userFriendlyNodes, "Username");
        }

        public void AddOrderStatusReport()
        {
            Dictionary<string, decimal?> nodes = new Dictionary<string, decimal?>();
            foreach (WooCommerceNET.WooCommerce.v3.Order order in _view.Orders)
            {
                if (!nodes.ContainsKey(order.status))
                {
                    nodes.Add(order.status, 1);
                }
                else
                nodes[order.status]++;
            }

            _view.AddGraphSeries(nodes, "Status");
        }
    }
}
