using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface IAppoinmentRepository : IRepository<Appoinment>
    {

        List<Appoinment> GetAppoinmentsByEmployeeIdOrCustomerId(int employeeId, int customerId);
        bool IsExistAppoinmentByCustomerIdAndServiceSlotId(int customerId, int serviceSlotId);

        void addAppoinment(Appoinment appoinment);
    }
}
