using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Models
{
    public partial class CustomerModel
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName{ get; set; }
        public DateTime ContractDate { get; set; }
        public DateTime ContractExpiryDate { get; set; }
        public IEnumerable<CustomersSerivcesModel> CustomersSerivces { get; set; }
        public CustomerModel()
        {
            CustomersSerivces = new HashSet<CustomersSerivcesModel>();
        }
    }
}
