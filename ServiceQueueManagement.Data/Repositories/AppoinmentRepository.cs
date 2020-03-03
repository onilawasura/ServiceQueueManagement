using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceQueueManagement.Data.Repositories
{
    public class AppoinmentRepository : Repository<Appoinment>, IAppoinmentRepository
    {

        public AppoinmentRepository(ServiceQueueDbContext context)
            : base(context)
        { }

        public void addAppoinment(Appoinment appoinment)
        {
            _Context.Appoinments.Add(appoinment);
        }

        //public List<Appoinment> GetAppoinmentsByEmployeeId(int employeeId)
        //{
        //    return _Context.Appoinments.Where(x => x.FkEmployeeId == employeeId).ToList();
        //}

        public List<Appoinment> GetAppoinmentsByEmployeeIdOrCustomerId(int employeeId, int customerId)
        {
            return _Context.Appoinments.Where(x => x.FkEmployeeId == employeeId || x.FkCustomerId == customerId).ToList();
        }

        public bool IsExistAppoinmentByCustomerIdAndServiceSlotId(int customerId, int serviceSlotId)
        {
            return _Context.Appoinments.Any(x => x.FkCustomerId == customerId && x.FkServiceSlotId == serviceSlotId);
        }
    }
}
