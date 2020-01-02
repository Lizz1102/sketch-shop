using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SketchShop.Models
{
	public class FakeProductRepository : IProductRepository
	{
		public IQueryable<Product> Products => new List<Product> {
new Product { Name = "Tranquility", Price = 25 },
new Product { Name = "Fearless", Price = 179 },
new Product { Name = "Rebel", Price = 95 }
}.AsQueryable<Product>();
	}
}
