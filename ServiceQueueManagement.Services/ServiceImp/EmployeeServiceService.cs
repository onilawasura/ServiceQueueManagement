using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Services.ServiceImp
{
    public class EmployeeServiceService : IEmployeeServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeServiceService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public List<EmployeeService> GetEmployeeServiceByServiceId(int serviceID)
        {
            return _unitOfWork.employeeService.GetEmployeeServiceByServiceId(serviceID);
        }
    }
}
