
using System;
using Ecommerce_Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce_Server.EntityConfigurations
{
    public class ProductMainCatConfiguration : IEntityTypeConfiguration<ProductMainCategory>
    {
        public void Configure(EntityTypeBuilder<ProductMainCategory> builder)
        {
            builder.ToTable("product_main_cat");

            builder.Property(t => t.name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.active)
                .HasDefaultValue(true);
        }
    }
}








