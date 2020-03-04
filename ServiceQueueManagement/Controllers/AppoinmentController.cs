using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceQueueManagement.Core.DTOs;
using ServiceQueueManagement.Core.Services;

namespace ServiceQueueManagement.API.Controllers
{
    [ApiController]
    public class AppoinmentController : ControllerBase
    {
        private readonly IAppoinmentService _appoinmentService;

        public AppoinmentController(IAppoinmentService appoinmentService)
        {
            this._appoinmentService = appoinmentService;
        }

        /// <summary>
        /// responsible for add appoinments for seriveces required by customers
        /// </summary>
        [Route("api/appoinment/AddApoinments")]
        [HttpGet]
        public void AddAppoinments()
        {
            _appoinmentService.AddAppoinments();
        }

        /// <summary>
        /// Retrieves all the ongoing appoinments for given service slot
        /// </summary>
        /// <param name="serviceSlotId">integer value used to identify the service slot</param>
        /// <returns>list of objects of type OngoingAppoinmentsDto. which includes serviceDeskId, Customer, Employee and the CurreuntService</returns>
        [Route("api/appoinment/GetOngoingAppoinment")]
        [HttpGet]
        public List<OngoingAppoinmentsDto> GetOngoingAppoinment(int serviceSlotId)
        {
            return _appoinmentService.GetOngoingAppoinmentsByServiceSlotId(serviceSlotId);
        }
    }
}