using OrangeAPI.Libraries.Services;
using OrangeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Factories
{
    public partial interface IGraphChartModelFactory
    {
        GraphChartModel PrepareGraphChartMonthModelsForMonth(Dictionary<int,int> month);
        GraphChartModel PrepareGraphChartModelsForService(IList<Service> Services);
    }
}
