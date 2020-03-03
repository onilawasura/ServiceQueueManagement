using ServiceQueueManagement.Core.DTOs;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface ICustomerServiceRepositry: IRepository<CustomerService>
    {
        void UpdateAssignedCustomerServices(int customerserviceId);
        List<CustomerService> GetAllNotAssignedCustomers();
    }
}
