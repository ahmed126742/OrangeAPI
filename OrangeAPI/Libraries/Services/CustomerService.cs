using Microsoft.EntityFrameworkCore;
using OrangeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Libraries.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly dbContext _context;
        public CustomerService(dbContext context)
        {
            _context = context;
        }
        public virtual IList<Customer> GetPaginatedCustomers(int index = 1, int rows = 20)
        {
            var customers = _context.customers.Include(ww => ww.CustomersSerivces)
                            .Skip((index - 1) * rows)
                            .Take(rows)
                            .ToList();
            return customers;
        }
        public virtual IList<Customer> GetPaginatedtExpiredCustomers(int index = 1, int rows = 20)
        {
            var customers = _context.customers.Include(ww => ww.CustomersSerivces)
                            .Where(ww => ww.ContractExpiryDate < DateTime.Now)
                            .Skip((index - 1) * rows)
                            .Take(rows)
                            .ToList();
            return customers;
        }
        public virtual IList<Customer> GetPaginatedtExpiredCustomersWithenMonth(int index = 1, int rows = 20)
        {
            var customers = _context.customers.Include(ww => ww.CustomersSerivces)
                            .Where(ww => ww.ContractExpiryDate > DateTime.Now && ww.ContractExpiryDate < DateTime.Now.AddMonths(1))
                            .Skip((index - 1) * rows)
                            .Take(rows)
                            .ToList();
            return customers;
        }
        public virtual int GetCustomersCount(int month = 1, int year = 2020)
        {
            var customerCount = _context.customers
                            .Where(ww => ww.ContractExpiryDate.Month == month && ww.ContractExpiryDate.Year == year)
                            .Count();
            return customerCount;
        }
        public virtual Dictionary<int, int> CustomersCountPerMonth(int year = 2020)
        {
            var customers = _context.customers
                            .Where(ww => ww.ContractExpiryDate.Year == year).GroupBy(ww => ww.ContractDate.Month)
                            .Select(ww => new { ww.Key, count = ww.Count() }).OrderBy(ww => ww.Key)
                            .ToList();

            Dictionary<int, int> GraphChartArray = new Dictionary<int, int>();

            for (int i = 0; i < customers.Count() ; i++)
            {
                GraphChartArray.Add(customers[i].Key, customers[i].count);
            }

            return GraphChartArray;
        }
    }
}
