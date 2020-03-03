using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceQueueManagement.Data.Repositories
{
    public class EmployeeServiceRepository : Repository<EmployeeService>, IEmployeeServiceRepository
    {
        public EmployeeServiceRepository(ServiceQueueDbContext context)
            : base(context)
        { }
        public List<EmployeeService> GetEmployeeServiceByServiceId(int serviceID)
        {
            return _Context.EmployeeServices.Where(x => x.FkServiceId == serviceID).ToList();
        }
    }
}
