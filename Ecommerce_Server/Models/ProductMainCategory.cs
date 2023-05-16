
using System;
using System.Collections.ObjectModel;

namespace Ecommerce_Server.Models
{
	public class ProductMainCategory
	{
		public int id { get; set; }
		public string name { get; set; }
		public bool active { get; set; }

		public ICollection<ProductSubCategory> ProductSubCategories { get; set; }

		public ProductMainCategory()
		{
			ProductSubCategories = new Collection<ProductSubCategory>();
		}

	}
}

