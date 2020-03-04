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
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;

        }

        /// <summary>
        /// Test Method. not important 
        /// </summary>
        /// <returns></returns>
        [Route("api/customer/GetAllCustomers")]
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            return Ok();
        }

        /// <summary>
        /// respnsible for store customer data
        /// </summary>
        /// <param name="customer">used customer type object to retrive customer data</param>
        /// <returns>newly created customer</returns>
        [Route("api/customer/AddCustomer")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Customer>>> AddCustomer(Customer customer)
        {
            var cst = await _customerService.CreateCustomer(customer);
            return Ok(cst);
        }



    }
}