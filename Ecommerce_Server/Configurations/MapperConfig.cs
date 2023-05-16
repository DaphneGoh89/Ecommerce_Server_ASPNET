using System;
using AutoMapper;
using Ecommerce_Server.Models;
using Ecommerce_Server.Resources;

namespace Ecommerce_Server.Configurations
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<ProductMainCategory, ProductMainCategoryResource>().ReverseMap();
			CreateMap<ProductSubCategory, ProductSubCategoryResource>().ReverseMap();
		}
	}
}

