using Etisst.Desktop.Common;
using Etisst.Desktop.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BussinessLogic.Core
{
    public class OrderBLL
    {
        public async Task<List<Order>> GetAllProductsAsync()
        {
            OrderDAL oDAL = new OrderDAL();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("per_page", "100");
            return await oDAL.GetAllOrdersAsync(dic);
        }
        public async Task DeleteOrderByIdAsync(int? id)
        {
            OrderDAL oDAL = new OrderDAL();
            int actualId = id ?? default(int);
            await oDAL.DeleteOrderByIdAsync(actualId);
        }
        public async Task RejectOrderAsync(int? id)
        {
            OrderDAL oDAL = new OrderDAL();
            Order orderUpdated = new Order { status = Enums.OrderStatus.cancelled.ToString() };
            int actualId = id ?? default(int);
            await oDAL.UpdateOrderAsync(actualId, orderUpdated);
        }
        public async Task ConfirmOrderAsync(int? id)
        {
            OrderDAL oDAL = new OrderDAL();
            Order orderUpdated = new Order { status = Enums.OrderStatus.completed.ToString(), date_completed = DateTime.Now };
            int actualId = id ?? default(int);
            await oDAL.UpdateOrderAsync(actualId, orderUpdated);
        }
        public async Task<List<Report>> GetOrderReport()
        {
            OrderDAL oDAL = new OrderDAL();
            return await oDAL.GerOrderReport();
        }
    }
}
