using System;

namespace Ecommerce_Server.Models
{
	public class ProductSubCategory
	{
		public int id { get; set; }
		public string name { get; set; }
		public bool active { get; set; }

		public ProductMainCategory ProductMainCategory { get; set; }
		public int main_cat_id { get; set; }
	}
}

