using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Persistance.Configuration
{
    public class CatergoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryId)
                .HasColumnName("CategoryID");

            builder.Property(c => c.CategoryName)
                .HasMaxLength(15)
                .IsRequired(true);
            

            builder.Property(c => c.Description)
                .HasColumnType("ntext");

            builder.Property(c => c.Picture)
                .HasColumnType("image");
        }
    }
}
