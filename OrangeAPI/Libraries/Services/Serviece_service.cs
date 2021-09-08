using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Libraries.Services
{
    public partial class Serviece_service:IServiece_service
    {
        private readonly dbContext _context;
        public Serviece_service(dbContext context)
        {
            _context = context;
        }
        public virtual IList<Service> GetServicesList()
        { 
         return  _context.services.Include(ww => ww.CustomersSerivces).ToList();
            
        }
    }
}
