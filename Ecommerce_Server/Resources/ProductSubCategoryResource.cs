using System;
using Ecommerce_Server.Models;

namespace Ecommerce_Server.Resources
{
	public class ProductSubCategoryResource
	{
        public int id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }

        //public ProductMainCategory ProductMainCategory { get; set; }
        //public int main_cat_id { get; set; }
    }
}

