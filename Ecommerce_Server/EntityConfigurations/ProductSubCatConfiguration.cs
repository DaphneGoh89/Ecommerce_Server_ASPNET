using System;
using Ecommerce_Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Server.EntityConfigurations
{
    public class ProductSubCatConfiguration : IEntityTypeConfiguration<ProductSubCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductSubCategory> builder)
        {
            builder.ToTable("product_sub_cat");

            builder.Property(t => t.name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.active)
                .HasDefaultValue(true);
        }
    }
}

