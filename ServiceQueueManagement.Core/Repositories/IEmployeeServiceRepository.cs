using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface IEmployeeServiceRepository : IRepository<EmployeeService>
    {
        List<EmployeeService> GetEmployeeServiceByServiceId(int serviceID);
    }
}
