using OrangeAPI.Libraries.Services;
using OrangeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Factories
{
    public partial class CustomerModelFactory:ICustomerModelFactory
    {
        public virtual IList<CustomerModel> PrepareCustomerModels(IList<Customer> customers)
        {
            var CustomerModels = new List<CustomerModel>();

            foreach (var item in customers)
            {
                var CustomerModel = new CustomerModel
                {
                    Id = item.Id,
                     CustomerName = item.CustomerName,
                     ContractDate = item.ContractDate,
                     ContractExpiryDate = item.ContractExpiryDate,
                    // CustomersSerivces = (IEnumerable<CustomersSerivcesModel>)item.CustomersSerivces
                };

                CustomerModels.Add(CustomerModel);
            }

            return CustomerModels;
        }
    }
}
