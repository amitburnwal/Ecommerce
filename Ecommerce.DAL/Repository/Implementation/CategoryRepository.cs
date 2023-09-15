
using Ecommerce.DAL.Common;
using Ecommerce.DAL.Repository.Interface;
using Ecommerce.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Repository.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public Category GetCategoryByName(string categoryName)
        {
            return _context.Categories.First(x=>x.CategoryName == categoryName);
        }
    }
}
