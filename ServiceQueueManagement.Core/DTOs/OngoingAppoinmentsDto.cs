using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Core.DTOs
{
    public class OngoingAppoinmentsDto
    {
        public int ServiceDesk { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public string RequiredService { get; set; }
        public string TimeSlot { get; set; }

    }
}
