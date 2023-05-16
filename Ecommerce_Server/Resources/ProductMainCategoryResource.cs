using System;
using Ecommerce_Server.Models;
using System.Collections.ObjectModel;

namespace Ecommerce_Server.Resources
{
	public class ProductMainCategoryResource
	{
        public int id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }

        public ICollection<ProductSubCategoryResource> ProductSubCategories { get; set; }

        public ProductMainCategoryResource()
        {
            ProductSubCategories = new Collection<ProductSubCategoryResource>();
        }
    }
}

