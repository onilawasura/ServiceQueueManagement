using ServiceQueueManagement.Core.DTOs;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface ICustomerServiceRepositry: IRepository<CustomerService>
    {
        /// <summary>
        /// update assigned customers flag "IsAssigned". used in appinment service
        /// </summary>
        /// <param name="customerserviceId">interger type data to identify updated customers</param>
        void UpdateAssignedCustomerServices(int customerserviceId);

        /// <summary>
        /// Retrieves all the customers "IsAssigned" if false. used in appinment service
        /// </summary>
        /// <returns></returns>
        List<CustomerService> GetAllNotAssignedCustomers();
    }
}
