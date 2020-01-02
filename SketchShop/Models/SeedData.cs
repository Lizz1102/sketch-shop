using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace SketchShop.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			ApplicationDbContext context = app.ApplicationServices
			.GetRequiredService<ApplicationDbContext>();
			context.Database.Migrate();
			if (!context.Products.Any())
			{
				context.Products.AddRange(
				new Product
				{
					Name = "Tranquility",
					Description = "Girl enjoying the sunshine on a summer afternoon, after a hectic tiring day",
					Category = "Self-potrait",
					Price = 500
				},
				new Product
				{
					Name = "Fearless",
					Description = "Figure of a strong fearless girl",
					Category = "Figure drawing",
					Price = 0.5m
				},
				new Product
				{
					Name = "Rebel",
					Description = "A boy against stereotypes",
					Category = "Figure drawing",
					Price = 5m
				},
				new Product
				{
					Name = "Embracing Thy inner Demons",
					Description = "Troubled women make peace with the demons in herself",
					Category = "Portrait",
					Price = 34.95m
				},
				new Product
				{
					Name = "Amidst All Chaos I Dance",
					Description = "Enjoying the moment despite all odds",
					Category = "Figure drawing",
					Price = 79500
				},
				new Product
				{
					Name = "Berwing A Cup Of Morning Melancholy",
					Description = "Girl starting her day with the sad thoughts that occupied her over the nights yesterday",
					Category = "Pochade",
					Price = 16
				},
				new Product
				{
					Name = "Claiming Back My Soul",
					Description = "Coming out of an abusive relationship",
					Category = "Cross-hatching",
					Price = 29.95m
				},
				new Product
				{
					Name = "Opening Pandora's Box",
					Description = "Man knows the consequences deep down yet kissing the troubled girl",
					Category = "Cross-hatching",
					Price = 75
				},
new Product
{
	Name = "Truth is Relative",
	Description = "Thinking about other perspectives",
	Category = "Cross-hatching",
	Price = 1200
}
);
				context.SaveChanges();
			}
		}
	}
}