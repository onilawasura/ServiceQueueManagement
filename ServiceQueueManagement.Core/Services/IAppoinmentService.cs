using ServiceQueueManagement.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Services
{
    public interface IAppoinmentService
    {
        /// <summary>
        /// to trigger add apoinment method in apoinment service
        /// </summary>
        void AddAppoinments();

        /// <summary>
        /// get the list of ongoing appoinments by given service slot
        /// </summary>
        /// <param name="serviceSlotId">integer value for identify service slot</param>
        /// <returns>lsit of ongoing appoinments Dto object</returns>
        List<OngoingAppoinmentsDto> GetOngoingAppoinmentsByServiceSlotIdOrCustomerId(int? serviceSlotId, int? customerId);
    }
}
