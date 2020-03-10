using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceQueueManagement.Data.Repositories
{
    public class CustomerServiceRepositry : Repository<CustomerService>, ICustomerServiceRepositry
    {
        public CustomerServiceRepositry(ServiceQueueDbContext context)
            : base(context)
        {
        }

        /// <summary>Retrieves all the customers "IsAssigned" if false. used in appinment service</summary>
        /// <returns></returns>
        public List<CustomerService> GetAllNotAssignedCustomers()
        {
            var lstNotAssignedCustomers = _Context.CustomerServices.Where(x => x.IsAssigned == false).ToList();
            return lstNotAssignedCustomers;
        }

        /// <summary>update assigned customers flag "IsAssigned". used in appinment service</summary>
        /// <param name="customerserviceId">interger type data to identify updated customers</param>
        public void UpdateAssignedCustomerServices(int customerserviceId)
        {
            var customerService = _Context.CustomerServices.FirstOrDefault(x => x.Id == customerserviceId);
            customerService.IsAssigned = true;
        }
    }
}
