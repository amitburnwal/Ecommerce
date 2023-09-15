using Ecommerce.DAL.Common;
using Ecommerce.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Data
{
    public static class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any board games.
                if (context.Products.Any())
                {
                    return;   // Data was already seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        ProductId = 1,
                        Name = "AirFryer",
                        CategoryName = "Kitchen",
                        Price = 100
                    },
                    new Product
                    {
                        ProductId = 1,
                        Name = "Bike",
                        CategoryName = "Toy",
                        Price = 400
                    },
                    new Product
                    {
                        ProductId = 1,
                        Name = "Mattress",
                        CategoryName = "Home",
                        Price = 700
                    });
                context.Categories.AddRange(
                    new Category
                    {
                        CategoryId=1,
                        CategoryName="Home",
                        CategoryDescription="Products used in Living/Bed Room"
                    },
                     new Category
                     {
                         CategoryId = 2,
                         CategoryName = "Kitchen",
                         CategoryDescription = "Products used in Kitchen"
                     },
                      new Category
                      {
                          CategoryId = 3,
                          CategoryName = "Toys",
                          CategoryDescription = "Toys"
                      });
                context.SaveChanges();
            }
        }
    }
}
