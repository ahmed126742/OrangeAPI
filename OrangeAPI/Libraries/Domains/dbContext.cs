using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Libraries.Services
{
    public partial class dbContext:DbContext
    {
        public dbContext(DbContextOptions options):base(options)
        {
            // configuration 
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<CustomersSerivces> CustomersSerivces { get; set; }

    }
}
