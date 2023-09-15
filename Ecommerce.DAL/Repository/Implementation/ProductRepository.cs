using Ecommerce.DAL.Common;
using Ecommerce.DAL.Repository.Interface;
using Ecommerce.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Repository.Implementation
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context; 
        }
        public IEnumerable<Product> GetPopularProducts(int count)
        {
            return _context.Products.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}
