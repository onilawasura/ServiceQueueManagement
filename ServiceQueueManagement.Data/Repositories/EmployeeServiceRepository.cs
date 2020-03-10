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


        /// <summary>Retrieve all the employees who can provide special serviec by serviceId. Use in appoinment table</summary>
        /// <param name="serviceID">integer type data to identify employees who can provide the purticular service</param>
        /// <returns>List if Employees belongs to purticular service id</returns>
        public List<EmployeeService> GetEmployeeServiceByServiceId(int serviceID)
        {
            return _Context.EmployeeServices.Where(x => x.FkServiceId == serviceID).ToList();
        }
    }
}
