using System;
using AutoMapper;
using Ecommerce_Server.Core;
using Ecommerce_Server.Models;
using Ecommerce_Server.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Server.Controllers
{
	public class ProductCategoryController : Controller
	{
        private readonly EcommerceDbContext _context;
        private readonly IMapper _mapper;

        public ProductCategoryController(EcommerceDbContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}


		// Create your controller methods here
		[HttpGet("api/getproductcat")]
		public async Task<IEnumerable<ProductMainCategoryResource>> GetProductCategory()
		{
			var productMainCategories = await _context.ProductMainCategory.Include(m => m.ProductSubCategories).ToListAsync();
			return _mapper.Map<List<ProductMainCategoryResource>>(productMainCategories);
		}
	}
}

