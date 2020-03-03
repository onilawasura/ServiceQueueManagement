using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.DTOs
{
    public class CustomerServiceDto
    {
        public int CustomerId { get; set; }
        //public int ServiceId { get; set; }

        public List<int> LstServiceId { get; set; }


        public CustomerServiceDto()
        {
            LstServiceId = new List<int>();
        }

    }
}
