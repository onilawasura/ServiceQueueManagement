using ServiceQueueManagement.Core.DTOs;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface IAppoinmentRepository : IRepository<Appoinment>
    {

        /// <summary>
        /// used to find out wheter if any record exist on giveb employeeId or customerId
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="customerId"></param>
        /// <returns>If Record exist for given employeeId or customerId returns list appoinments</returns>
        List<Appoinment> GetAppoinmentsByEmployeeIdOrCustomerId(int employeeId, int customerId);

        /// <summary>
        /// checking whether a purticular serviceSlot is alredy assigned for purticular customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="serviceSlotId"></param>
        /// <returns>return true or false</returns>
        bool IsExistAppoinmentByCustomerIdAndServiceSlotId(int customerId, int serviceSlotId);

        /// <summary>
        /// Retrieves list of ongoing appoinment by given serivce slot id
        /// </summary>
        /// <param name="servicesSlotId">integer value</param>
        /// <returns>lsit of ongoingAppoinmentDto type objects</returns>
        List<OngoingAppoinmentsDto> GetOngoingAppoinmentsByServiceSlotId(int? servicesSlotId);

        /// <summary>
        /// Retrieves list of ongoing appoinment by given customer Id id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns>lsit of ongoingAppoinmentDto type objects</returns>
        List<OngoingAppoinmentsDto> GetOngoingAppoinmentsByCustomerId(int? customerId);

        /// <summary>
        /// used to add appoinments when system finds the optimum appoinment for purticular custommer
        /// </summary>
        /// <param name="appoinment"></param>
        void addAppoinment(Appoinment appoinment);

        /// <summary>
        /// Checking whether a purticural record exist for given employee and service slot
        /// </summary>
        /// <param name="employeeId">integer value</param>
        /// <param name="serviceSlotId">integer value</param>
        /// <returns>if record exist true else false</returns>
        bool IsExistAppoinmentByEmployeeAndServiceSlot(int employeeId, int? serviceSlotId);
    }
}
