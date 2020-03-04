using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServiceQueueManagement.Core.Models
{
    /// <summary>
    /// responsible for store services meta data
    /// </summary>
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [StringLength(100, ErrorMessage = "Maximum Character length exceeded")]
        public string Name { get; set; }

        public int TimeDuration { get; set; }
        public virtual ICollection<EmployeeService> EmployeeService { get; set; }
        public virtual ICollection<CustomerService> CustomerService { get; set; }
    }
}
