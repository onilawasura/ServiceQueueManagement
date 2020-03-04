using ServiceQueueManagement.Core.DTOs;
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

        public List<OngoingAppoinmentsDto> GetOngoingAppoinmentsByServiceSlotId(int servicesSlotId)
        {
            List<OngoingAppoinmentsDto> lstOngoingAppoinmentsDtos = new List<OngoingAppoinmentsDto>();
            var lstAppoinments = from A in _Context.Appoinments
                                 join E in _Context.Employees on A.FkEmployeeId equals E.Id
                                 join C in _Context.Customers on A.FkCustomerId equals C.Id
                                 join CS in _Context.CustomerServices on A.FkCustomerServiceId equals CS.Id
                                 join S in _Context.Services on CS.FkServiceId equals S.Id
                                 where A.FkServiceSlotId == servicesSlotId
                                 select new OngoingAppoinmentsDto
                                 {
                                     CustomerName = C.Name,
                                     ServiceDesk = E.HelpDesk_No,
                                     EmployeeName = E.Name,
                                     RequiredService = S.Name
                                 };

            //var xx = lstAppoinments;
            lstOngoingAppoinmentsDtos.AddRange(lstAppoinments);
            return lstOngoingAppoinmentsDtos;
        }

        public bool IsExistAppoinmentByCustomerIdAndServiceSlotId(int customerId, int serviceSlotId)
        {
            return _Context.Appoinments.Any(x => x.FkCustomerId == customerId && x.FkServiceSlotId == serviceSlotId);
        }
    }
}
