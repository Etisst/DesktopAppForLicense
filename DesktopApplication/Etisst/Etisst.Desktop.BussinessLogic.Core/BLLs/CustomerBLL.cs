using Etisst.Desktop.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;
using WooCommerceNET.WooCommerce.v3;

namespace Etisst.Desktop.BussinessLogic.Core
{
    public class CustomerBLL
    {
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            CustomerDAL cDAL = new CustomerDAL();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("per_page", "100");
            return await cDAL.GetAllCustomersAsync(dic);
        }

        public async Task<Customer> GetCustomerByIdAsync(int? id)
        {
            CustomerDAL cDAL = new CustomerDAL();
            int actualId = id ?? default(int);
            if (id == 0) return null;
            return await cDAL.GetCustomerByIdAsync(actualId);
        }
    }
}
