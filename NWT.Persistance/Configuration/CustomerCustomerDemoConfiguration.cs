using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Persistence.Configurations
{
    public class CustomerCustomerDemoConfiguration : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.CustomerId)
                .HasColumnName("CustomerID")
                .HasMaxLength(5);

            builder.Property(c => c.CustomerTypeId)
                .HasColumnName("CustomerTypeID")
                .HasMaxLength(10);
        }
    }
}
