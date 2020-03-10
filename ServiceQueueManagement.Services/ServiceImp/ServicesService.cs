using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Core.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceQueueManagement.Services.ServiceImp
{
    public class ServicesService : IServicesService
    {

        private readonly IUnitOfWork _unitOfWork;

        public ServicesService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        /// <summary>Retrieves all of the available services</summary>
        /// <returns>list of  services</returns>
        public async Task<IEnumerable> GetAllServices()
        {
            return await _unitOfWork.ServicesRepository.GetAllAsync();
        }

        /// <summary>retrieves all the service slots available</summary>
        /// <returns>List of service slots</returns>
        public List<ServiceSlot> GetAllServiceSlots()
        {
            return _unitOfWork.ServicesRepository.GetAllServiceSlot();
        }
    }
}
