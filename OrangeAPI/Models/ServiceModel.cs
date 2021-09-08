using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Models
{
    public partial class ServiceModel
    {
        public int ServiceId { get; set; }
        public string ServiceType { get; set; }
        public IEnumerable<CustomersSerivcesModel> CustomersSerivces { get; set; }
        public ServiceModel()
        {
            CustomersSerivces = new HashSet<CustomersSerivcesModel>();
        }
    }
}
