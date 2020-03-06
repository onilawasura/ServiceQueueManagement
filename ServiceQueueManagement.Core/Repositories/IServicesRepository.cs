using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.Repositories
{
    public interface IServicesRepository : IRepository<Service>
    {

        /// <summary>
        /// Rtrieves list of servie slots available
        /// </summary>
        /// <returns>List of Service Slots</returns>
        List<ServiceSlot> GetAllServiceSlot();
    }
}
