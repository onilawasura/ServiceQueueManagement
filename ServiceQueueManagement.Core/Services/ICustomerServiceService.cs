using ServiceQueueManagement.Core.DTOs;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Core.Services
{
    public interface ICustomerServiceService
    {
        /// <summary>
        /// used to create customer services for given customer Id and list of service ids
        /// </summary>
        /// <param name="customerServiceDto">customerService dto having customer id and list of services required</param>
        /// <returns></returns>
        Task<CustomerServiceDto> CreateCustomerService(CustomerServiceDto customerServiceDto);
    }
}
