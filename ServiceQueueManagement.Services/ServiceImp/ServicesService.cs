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
        public async Task<IEnumerable> GetAllServices()
        {
            return await _unitOfWork.ServicesRepository.GetAllAsync();
        }

        public List<ServiceSlot> GetAllServiceSlots()
        {
            return _unitOfWork.ServicesRepository.GetAllServiceSlot();
        }
    }
}
