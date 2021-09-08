using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Libraries.Services
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName{ get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime ContractExpiryDate { get; set; }
        public IEnumerable<CustomersSerivces> CustomersSerivces { get; set; }
        public Customer()
        {
            CustomersSerivces = new HashSet<CustomersSerivces>();
        }
    }
}
