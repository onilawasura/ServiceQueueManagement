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

        /// <summary>used to add appoinments when system finds the optimum appoinment for purticular custommer</summary>
        /// <param name="appoinment"></param>
        public void addAppoinment(Appoinment appoinment)
        {
            _Context.Appoinments.Add(appoinment);
        }

        //public List<Appoinment> GetAppoinmentsByEmployeeId(int employeeId)
        //{
        //    return _Context.Appoinments.Where(x => x.FkEmployeeId == employeeId).ToList();
        //}

        /// <summary>used to find out wheter if any record exist on giveb employeeId or customerId</summary>
        /// <param name="employeeId"></param>
        /// <param name="customerId"></param>
        /// <returns>If Record exist for given employeeId or customerId returns list appoinments</returns>
        public List<Appoinment> GetAppoinmentsByEmployeeIdOrCustomerId(int employeeId, int customerId)
        {
            return _Context.Appoinments.Where(x => x.FkEmployeeId == employeeId || x.FkCustomerId == customerId).ToList();
        }

        /// <summary>Retrieves list of ongoing appoinment by given customer Id id</summary>
        /// <param name="customerId"></param>
        /// <returns>lsit of ongoingAppoinmentDto type objects</returns>
        public List<OngoingAppoinmentsDto> GetOngoingAppoinmentsByCustomerId(int? customerId)
        {
            List<OngoingAppoinmentsDto> lstOngoingAppoinmentsDtos = new List<OngoingAppoinmentsDto>();
            var lstAppoinments = from A in _Context.Appoinments
                                 join E in _Context.Employees on A.FkEmployeeId equals E.Id
                                 join C in _Context.Customers on A.FkCustomerId equals C.Id
                                 join CS in _Context.CustomerServices on A.FkCustomerServiceId equals CS.Id
                                 join S in _Context.Services on CS.FkServiceId equals S.Id
                                 join SS in _Context.ServiceSlots on A.FkServiceSlotId equals SS.Id
                                 where (A.FkCustomerId == customerId || customerId == null)
                                 orderby A.FkServiceSlotId
                                 select new OngoingAppoinmentsDto
                                 {
                                     CustomerName = C.Name,
                                     ServiceDesk = E.HelpDesk_No,
                                     EmployeeName = E.Name,
                                     RequiredService = S.Name,
                                     TimeSlot = SS.Name
                                 };

            lstOngoingAppoinmentsDtos.AddRange(lstAppoinments);
            return lstOngoingAppoinmentsDtos;
        }

        /// <summary>Retrieves list of ongoing appoinment by given serivce slot id</summary>
        /// <param name="servicesSlotId">integer value</param>
        /// <returns>lsit of ongoingAppoinmentDto type objects</returns>
        public List<OngoingAppoinmentsDto> GetOngoingAppoinmentsByServiceSlotId(int? servicesSlotId)
        {
            List<OngoingAppoinmentsDto> lstOngoingAppoinmentsDtos = new List<OngoingAppoinmentsDto>();
            var lstAppoinments = from A in _Context.Appoinments
                                 join E in _Context.Employees on A.FkEmployeeId equals E.Id
                                 join C in _Context.Customers on A.FkCustomerId equals C.Id
                                 join CS in _Context.CustomerServices on A.FkCustomerServiceId equals CS.Id
                                 join S in _Context.Services on CS.FkServiceId equals S.Id
                                 join SS in _Context.ServiceSlots on A.FkServiceSlotId equals SS.Id
                                 where (A.FkServiceSlotId == servicesSlotId || servicesSlotId == null)
                                 orderby A.FkServiceSlotId
                                 select new OngoingAppoinmentsDto
                                 {
                                     CustomerName = C.Name,
                                     ServiceDesk = E.HelpDesk_No,
                                     EmployeeName = E.Name,
                                     RequiredService = S.Name,
                                     TimeSlot = SS.Name
                                 };

            lstOngoingAppoinmentsDtos.AddRange(lstAppoinments);
            return lstOngoingAppoinmentsDtos;
        }

        /// <summary>checking whether a purticular serviceSlot is alredy assigned for purticular customer</summary>
        /// <param name="customerId"></param>
        /// <param name="serviceSlotId"></param>
        /// <returns>return true or false</returns>
        public bool IsExistAppoinmentByCustomerIdAndServiceSlotId(int customerId, int serviceSlotId)
        {
            return _Context.Appoinments.Any(x => x.FkCustomerId == customerId && x.FkServiceSlotId == serviceSlotId);
        }

        /// <summary>Checking whether a purticural record exist for given employee and service slot</summary>
        /// <param name="employeeId">integer value</param>
        /// <param name="serviceSlotId">integer value</param>
        /// <returns>if record exist true else false</returns>
        public bool IsExistAppoinmentByEmployeeAndServiceSlot(int employeeId, int? serviceSlotId)
        {
            return _Context.Appoinments.Any(x => x.FkEmployeeId == employeeId && x.FkServiceSlotId == serviceSlotId);
        }
    }
}
