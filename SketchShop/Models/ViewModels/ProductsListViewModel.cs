using System.Collections.Generic;
using SketchShop.Models;
namespace SketchShop.Models.ViewModels
{
	public class ProductsListViewModel
	{
		public IEnumerable<Product> Products { get; set; }
		public PagingInfo PagingInfo { get; set; }
	}
}
