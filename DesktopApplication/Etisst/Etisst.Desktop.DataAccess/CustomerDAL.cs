using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;
using AppContext = Etisst.Desktop.Common.AppContext;

namespace Etisst.Desktop.DataAccess
{
    public class CustomerDAL
    {
        private WCObject _wc;
        public CustomerDAL()
        {
            _wc = AppContext.wc;
        }
        public async Task<List<Customer>> GetAllCustomersAsync(Dictionary<string,string> dic)
        {
            int pageNumber = 1;
            dic.Add("page", pageNumber.ToString());
            return await _wc.Customer.GetAll(dic);
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _wc.Customer.Get(id);
        }
    }
}
