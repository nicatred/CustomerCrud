using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerCrud.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerCrud.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
            builder.Property(e => e.SureName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.date).IsRequired();

            builder.ToTable("CUSTOMERS");
        }
    }
}
