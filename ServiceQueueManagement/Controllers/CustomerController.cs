using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceQueueManagement.Core.DTOs;
using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Services;

namespace ServiceQueueManagement.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;
        private readonly ICustomerServiceService _customerServiceService;

        public CustomerController(ICustomerService customerService, ICustomerServiceService customerServiceService)
        {
            this._customerService = customerService;
            this._customerServiceService = customerServiceService;
        }
        [Route("api/customer/GetAllCustomers")]
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return Ok();
        }

        [Route("api/customer/AddCustomer")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Customer>>> AddCustomer(Customer customer)
        {
            var cst = await _customerService.CreateCustomer(customer);
            return Ok(cst);
        }

        [Route("api/customer/AddCustomerService")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Customer>>> AddCustomerService(CustomerServiceDto customerServiceDto)
        {
            var res = await _customerServiceService.CreateCustomerService(customerServiceDto);
            return Ok(res);
        }

        //[Route("api/customer/AddCustomerService")]
        //[HttpPost]
        //public ActionResult AddCustomerService(CustomerServiceDto customerServiceDto)
        //{
        //    //var res = await _customerServiceService.CreateCustomerService(customerServiceDto);
        //    return Ok();
        //}
    }
}