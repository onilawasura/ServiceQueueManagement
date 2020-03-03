using ServiceQueueManagement.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServiceQueueManagement.Core.Models
{
    public class Employee 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [StringLength(100, ErrorMessage = "Maximum Character length exceeded")]
        public string Name { get; set; }
        //public string B_Day { get; set; }
        public int HelpDesk_No { get; set; }
        public string Nic { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }

        public virtual ICollection<EmployeeService> EmployeeService { get; set; }
        public virtual ICollection<Appoinment> Appoinment { get; set; }
        //public virtual ICollection<CustomerService> CustomerService { get; set; }
    }
}
