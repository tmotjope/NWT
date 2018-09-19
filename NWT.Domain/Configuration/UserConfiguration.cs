using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Ignore(u => u.AdAccount);
            builder.OwnsOne(u => u.AdAccount).Property(u => u.Domain).HasColumnName("Domain");
            builder.OwnsOne(u => u.AdAccount).Property(u => u.Name).HasColumnName("Name");
                  
        }
    }
}
