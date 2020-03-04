using ServiceQueueManagement.Core.Services;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServiceQueueManagement.Core.DTOs;
using ServiceQueueManagement.Core.Repositories;

namespace ServiceQueueManagement.Services.ServiceImp
{
    public class CustomerServiceService : ICustomerServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerServiceService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        //public bool CreateCustomer(CustomerServiceDto customerServiceDto)
        //{
        //   // List<CustomerService> customerServices = new List<CustomerService>();

        //    foreach(var item in customerServiceDto.LstServiceId)
        //    {
        //        Core.Models.CustomerService customerServices = new Core.Models.CustomerService();
        //        customerServices.FkCustomerId = customerServiceDto.CustomerId;
        //        customerServices.FkServiceId = item;
        //        _unitOfWork.CustomerService.AddAsync(customerServices);
        //    }

        //    _unitOfWork.CommitAsync();

        //    return true;
        //}

        public async Task<CustomerServiceDto> CreateCustomerService(CustomerServiceDto customerServiceDto)
        {

            foreach (var item in customerServiceDto.LstServiceId)
            {
                Core.Models.CustomerService customerServices = new Core.Models.CustomerService();
                customerServices.FkCustomerId = customerServiceDto.CustomerId;
                customerServices.FkServiceId = item;
                customerServices.IsAssigned = false;
                await _unitOfWork.CustomerService.AddAsync(customerServices);
            }

            await _unitOfWork.CommitAsync();

            return customerServiceDto;
        }
    }
}
