using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// used to create customer 
        /// </summary>
        /// <param name="newCustomer">requires Customer type object</param>
        /// <returns>eturns the details of newly created customer</returns>
        public async Task<Customer> CreateCustomer(Customer newCustomer)
        {
            await _unitOfWork.Customer.AddAsync(newCustomer);

            //var xx = _unitOfWork.Customer.GetAllWithServiceAsync();
            await _unitOfWork.CommitAsync();
            return newCustomer;
        }
    }
}
