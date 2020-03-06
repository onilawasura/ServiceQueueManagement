﻿using ServiceQueueManagement.Core.Models;
using ServiceQueueManagement.Core.Repositories;
using ServiceQueueManagement.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceQueueManagement.Data.Repositories
{
    public class ServicesRepository: Repository<Service>, IServicesRepository
    {
        public ServicesRepository(ServiceQueueDbContext contex) : base(contex)
        {

        }

        public List<ServiceSlot> GetAllServiceSlot()
        {
            return _Context.ServiceSlots.ToList();
        }
    }
}
