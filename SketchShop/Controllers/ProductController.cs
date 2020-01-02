using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SketchShop.Models;
using SketchShop.Models.ViewModels;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SketchShop.Controllers
{
	public class ProductController : Controller
	{
		private IProductRepository repository;
		public int PageSize = 4;
		public ProductController(IProductRepository repo)
		{
			repository = repo;
		}

		public ViewResult List(int productPage = 1)
				=> View(new ProductsListViewModel {
					Products = repository.Products
						.OrderBy(p => p.ProductID)
						.Skip((productPage - 1) * PageSize)
						.Take(PageSize),
					PagingInfo = new PagingInfo {
						CurrentPage = productPage,
						ItemsPerPage = PageSize,
						TotalItems = repository.Products.Count()
					}
				});
	}
}
