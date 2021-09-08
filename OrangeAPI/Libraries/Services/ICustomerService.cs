using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Libraries.Services
{
    public interface ICustomerService
    {
        IList<Customer> GetPaginatedCustomers(int index = 1, int rows = 20);
        IList<Customer> GetPaginatedtExpiredCustomers(int index = 1, int rows = 20);
        IList<Customer> GetPaginatedtExpiredCustomersWithenMonth(int index = 1, int rows = 20);
        int GetCustomersCount(int month = 1, int year = 2020);
        Dictionary<int, int> CustomersCountPerMonth(int year = 2020);    
    }
}
