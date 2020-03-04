using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Core.Services
{
    public interface ICustomerService
    {
        /// <summary>
        /// used to create new customer 
        /// </summary>
        /// <param name="newCustomer">customer type object includs customer details about to be create</param>
        /// <returns>newly created customer</returns>
        Task<Customer> CreateCustomer(Customer newCustomer);
    }
}
