using OrangeAPI.Libraries.Services;
using OrangeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Factories
{
    public partial class GraphChartModelFactory : IGraphChartModelFactory
    {
        public virtual GraphChartModel PrepareGraphChartMonthModelsForMonth(Dictionary<int,int> MonthChartDictionary)
        {
            GraphChartModel model = new GraphChartModel();

            model.Labels = new List<string>() {"January","February","March","April","May","June","July"
            ,"August","September","October","November","December"};

            model.Values = new List<int>();

            foreach (var item in MonthChartDictionary)
            {
                model.Values.Add(item.Value);
            }

            return model;
        }

        public virtual GraphChartModel PrepareGraphChartModelsForService(IList<Service> Services)
        {
            GraphChartModel model = new GraphChartModel();
                
                        foreach (var item in Services)
                        {
                            model.Labels.Add(item.ServiceType);
                            model.Values.Add(item.CustomersSerivces.Count());
                        }

            return model;
        }
    }
}
