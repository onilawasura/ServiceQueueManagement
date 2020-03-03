using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServiceQueueManagement.Core.Models.Base
{
    public class Base
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="This Field is Required")]
        [StringLength(100, ErrorMessage ="Maximum Character length exceeded")]
        public string Name { get; set; }
    }
}
