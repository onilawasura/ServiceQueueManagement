using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceQueueManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceQueueManagement.Data.Configurations
{
    //there are two main methods in EF to create contraints and validations to tables => fluent api and data annotations
    //this is how contraints and validations are done using fluent api
    //there will be an instance of this class in dbcontext file 
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            //if there is one to many relationship

            //builder
            //    .HasOne(m => m.Artist)
            //    .WithMany(a => a.Musics)
            //    .HasForeignKey(m => m.ArtistId);

            builder
                .ToTable("Employee");

        }
    }
}
