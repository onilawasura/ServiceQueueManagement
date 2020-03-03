using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceQueueManagement.Core.Services;

namespace ServiceQueueManagement.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class AppoinmentController : ControllerBase
    {
        private readonly IAppoinmentService _appoinmentService;

        public AppoinmentController(IAppoinmentService appoinmentService)
        {
            this._appoinmentService = appoinmentService;
        }

        [Route("api/appoinment/AddApoinments")]
        [HttpGet]
        public void AddAppoinments()
        {
            _appoinmentService.AddAppoinments();
        }
    }
}