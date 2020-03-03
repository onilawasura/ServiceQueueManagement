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
        Task<CustomerServiceDto> CreateCustomerService(CustomerServiceDto customerServiceDto);
    }
}
