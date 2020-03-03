using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Data.Configurations
{
    public class EmployeeServiceConfigurations : IEntityTypeConfiguration<EmployeeService>
    {
        public void Configure(EntityTypeBuilder<EmployeeService> builder)
        {
            builder.
                HasKey(x => new { x.FkEmployeeId, x.FkServiceId});                
        }
    }
}
