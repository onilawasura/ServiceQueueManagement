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
        //protected readonly ServiceQueueDbContext _Context;
        public CustomerServiceRepositry(ServiceQueueDbContext context)
            : base(context)
        {
           // this._Context = context;
        }

        public List<CustomerService> GetAllNotAssignedCustomers()
        {
            var lstNotAssignedCustomers = _Context.CustomerServices.Where(x => x.IsAssigned == false).ToList();
            return lstNotAssignedCustomers;
        }

        public void UpdateAssignedCustomerServices(int customerserviceId)
        {
            var customerService = _Context.CustomerServices.FirstOrDefault(x => x.Id == customerserviceId);
            customerService.IsAssigned = true;
        }
    }
}
