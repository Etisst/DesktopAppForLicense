using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst.Desktop.DataAccess
{
    public class OrderDAL
    {
        private WCObject _wc;
        public OrderDAL()
        {
            _wc = AppContext.wc;
        }
        public async Task<List<Order>> GetAllOrdersAsync(Dictionary<string,string> dic)
        {
            int pageNumber = 1;
            dic.Add("page", pageNumber.ToString());
            return await _wc.Order.GetAll(dic);
        }

        public async Task DeleteOrderByIdAsync(int id)
        {
            await _wc.Order.Delete(id);
        }

        public async Task UpdateOrderAsync (int id, Order order)
        {
            await _wc.Order.Update(id,order);
        }
    }
}
