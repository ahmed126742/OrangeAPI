using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrangeAPI.Factories;
using OrangeAPI.Libraries.Services;
using OrangeAPI.Models;

namespace OrangeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiece_service _service;
        private readonly IGraphChartModelFactory _graphChartModelFactory;


        public ServicesController(IServiece_service service , IGraphChartModelFactory graphChartModelFactory)
        {
            _service = service;
            _graphChartModelFactory = graphChartModelFactory;
        }

        // GET: api/Services
        [HttpGet]
        public virtual IList<Service> Getservices()
        {
            var Services =  _service.GetServicesList();
            return Services;
        }

        //	Get customers counts according the service type
        [HttpGet("CustomerCountsByService")]
        public GraphChartModel GetCustomerCountsByServices()
        {
            var Services = _service.GetServicesList();

            var model = _graphChartModelFactory.PrepareGraphChartModelsForService(Services);

            return model;
        }
    }
}
