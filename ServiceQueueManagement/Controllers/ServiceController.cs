using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Services;

namespace ServiceQueueManagement.API.Controllers
{
    [ApiController]
    public class ServiceController : ControllerBase
    {

        private IServicesService _servicesService;
        public ServiceController(IServicesService servicesService)
        {
            this._servicesService = servicesService;
        }


        /// <summary>
        /// Retrieves All services
        /// </summary>
        /// <returns>List of Services</returns>
        [Route("api/service/GetAllServices")]
        [HttpGet]
        public Task<IEnumerable> GetAllServices()
        {
           return _servicesService.GetAllServices();
        }


        /// <summary>
        /// Retrieves All service slots available
        /// </summary>
        /// <returns> list of service slots </returns>
        [Route("api/service/GetAllServiceSlots")]
        [HttpGet]
        public ActionResult GetAllServiceSlots()
        {
            return Ok(_servicesService.GetAllServiceSlots());
        }
    }
}