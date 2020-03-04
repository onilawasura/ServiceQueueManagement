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
    public class CustomerServiceController : ControllerBase
    {
        private readonly ICustomerServiceService _customerServiceService;

        public CustomerServiceController(ICustomerServiceService customerServiceService)
        {
            this._customerServiceService = customerServiceService;
        }


        /// <summary>
        /// Responsile for store customer and required services 
        /// </summary>
        /// <param name="customerServiceDto">CustomerServiceDto object type data used to retrive the customer and services data </param>
        /// <returns>customer who owns newly created customer services</returns>
        [Route("api/customerservice/AddCustomerService")]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Customer>>> AddCustomerService(CustomerServiceDto customerServiceDto)
        {
            var res = await _customerServiceService.CreateCustomerService(customerServiceDto);
            return Ok(res);
        }


    }
}