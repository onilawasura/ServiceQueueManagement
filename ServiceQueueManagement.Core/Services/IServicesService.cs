using ServiceQueueManagement.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Core.Services
{
    public interface IServicesService
    {
        /// <summary>
        /// Retrieves all of the available services
        /// </summary>
        /// <returns>list of  services</returns>
        Task<IEnumerable> GetAllServices();


        /// <summary>
        /// retrieves all the service slots available
        /// </summary>
        /// <returns>List of service slots</returns>
        List<ServiceSlot> GetAllServiceSlots();
    }
}
