using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Libraries.Services
{
    public partial class Service
    {
        public int ServiceId { get; set; }
        public string ServiceType { get; set; }
        public IEnumerable<CustomersSerivces> CustomersSerivces { get; set; }
        public Service()
        {
            CustomersSerivces = new HashSet<CustomersSerivces>();
        }
    }
}
