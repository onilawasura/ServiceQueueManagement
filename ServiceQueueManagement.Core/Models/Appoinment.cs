using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServiceQueueManagement.Core.Models
{
    //this table has a many to many with customersevice (another many to many) and employee tables
    public class Appoinment
    {
        //[Key, Column(Order = 1)]
        public int FkCustomerServiceId { get; set; }
        public CustomerService CustomerService { get; set; }

        //[Key, Column(Order = 2)]
        public int FkEmployeeId { get; set; }
        public Employee Employee { get; set; }

        //[Key, Column(Order = 3)]
        public int? FkServiceSlotId { get; set; }
        public ServiceSlot ServiceSlot { get; set; }

        public int FkCustomerId { get; set; }
        public Customer Customer { get; set; }


        public decimal? StartingTime { get; set; }
        public decimal? EndTime { get; set; }
    }
}
