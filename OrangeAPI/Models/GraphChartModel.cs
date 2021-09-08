using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Models
{
    public class GraphChartModel
    {
        public List<string> Labels { get; set; }
        public List<int> Values { get; set; }

        public GraphChartModel()
        {
            Labels = new List<string>();
            Values = new List<int>();
        }
    }
}
