using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Data.Configurations
{
    public class CustomerServiceConfiguration : IEntityTypeConfiguration<CustomerService>
    {
        public void Configure(EntityTypeBuilder<CustomerService> builder)
        {
            builder.
                HasKey(x => new { x.FkCustomerId, x.FkServiceId });
        }
    }
}
