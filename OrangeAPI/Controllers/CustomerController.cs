using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrangeAPI.Factories;
using OrangeAPI.Libraries.Services;
using OrangeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerModelFactory _customerModelFactory;
        private readonly IGraphChartModelFactory _graphChartModelFactory;

        //ctor
        public CustomerController(ICustomerService customerService, ICustomerModelFactory customerModelFactory, IGraphChartModelFactory graphChartModelFactory)
        {
            _customerService = customerService;
            _customerModelFactory = customerModelFactory;
            _graphChartModelFactory = graphChartModelFactory;
        }

        //--------------------------------------------------------------------------------------------
        //	Get customers from database with server side pagination
        [HttpGet("GetCustomers/{index}")]
        public virtual IEnumerable<CustomerModel> GetCustomers(int index = 1,int rows =20)
        {
            var customers = _customerService.GetPaginatedCustomers(index, rows);
            var model = _customerModelFactory.PrepareCustomerModels(customers);
            return model;
        }

        //--------------------------------------------------------------------------------------------
        //	Get Customers where their contract is expired
        [HttpGet("GetExpiredCustomers/{index}")]
        public virtual IEnumerable<CustomerModel> GetExpiredCustomers(int index = 1, int rows = 20)
        {
            var customers = _customerService.GetPaginatedtExpiredCustomers(index, rows);
            var model = _customerModelFactory.PrepareCustomerModels(customers);
            return model;
        }

        //-------------------------------------------------------------------------------------------
        //	Get Customers where their contact will be expired within 1 month
        [HttpGet("GetExpiredCustomersWithenMonth/{index}")]
        public virtual IEnumerable<CustomerModel> GetExpiredCustomersWithenMonth(int index = 1, int rows = 20)
        {
            var customers = _customerService.GetPaginatedtExpiredCustomersWithenMonth(index, rows);
            var model = _customerModelFactory.PrepareCustomerModels(customers);
            return model;
        }

        //--------------------------------------------------------------------------------------
        // 	Get customers count per month per year (for example all customers in January year 2021)
        [HttpGet("GetCustomersCount/{month}/{year}")]
        public virtual int GetCustomersCount(int month = 1, int year = 2020)
        {
            var customers = _customerService.GetCustomersCount(month, year);
            return customers;
        }

        //---------------------------------------------------------------------------------------------
        // 	Get customers count per month per year (for example all customers in January year 2021)
        [HttpGet("CustomersCountPerMonth/{year}")]
        public virtual GraphChartModel CustomersCountPerMonth(int year = 2020)
        {
            var ChartDictionary = _customerService.CustomersCountPerMonth(year);
            var graphModel = _graphChartModelFactory.PrepareGraphChartMonthModelsForMonth(ChartDictionary);         
            return graphModel;
        }

    }
}