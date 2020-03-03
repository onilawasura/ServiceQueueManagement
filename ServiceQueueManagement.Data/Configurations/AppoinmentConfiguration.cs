using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Data.Configurations
{
    public class AppoinmentConfiguration : IEntityTypeConfiguration<Appoinment>
    {
        public void Configure(EntityTypeBuilder<Appoinment> builder)
        {
            builder.
                HasKey(x => new { x.FkCustomerServiceId, x.FkEmployeeId, x.FkServiceSlotId, x.FkCustomerId});
        }
    }
}
