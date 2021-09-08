using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Models
{
    public partial class CustomersSerivcesModel
    {
        public int CustomersSerivcesId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }
    }
}
