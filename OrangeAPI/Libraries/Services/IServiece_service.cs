using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Libraries.Services
{
    public partial interface IServiece_service
    {
        IList<Service> GetServicesList();
    }
}
