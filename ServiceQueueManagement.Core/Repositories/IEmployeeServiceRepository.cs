using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface IEmployeeServiceRepository : IRepository<EmployeeService>
    {

        /// <summary>
        /// Retrieve all the employees who can provide special serviec by serviceId. Use in appoinment table
        /// </summary>
        /// <param name="serviceID">integer type data to identify employees who can provide the purticular service</param>
        /// <returns>List if Employees belongs to purticular service id</returns>
        List<EmployeeService> GetEmployeeServiceByServiceId(int serviceID);
    }
}
