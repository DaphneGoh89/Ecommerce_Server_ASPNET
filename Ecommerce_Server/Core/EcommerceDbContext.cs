using System;
using Ecommerce_Server.EntityConfigurations;
using Ecommerce_Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Server.Core
{
	public class EcommerceDbContext : DbContext
	{
		public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
		{

		}

		public DbSet<ProductMainCategory> ProductMainCategory { get; set; }
        // public DbSet<ProductSubCategory> ProductSubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.ApplyConfiguration(new ProductMainCatConfiguration());
			modelBuilder.ApplyConfiguration(new ProductSubCatConfiguration());

			base.OnModelCreating(modelBuilder);
        }



    }
}

