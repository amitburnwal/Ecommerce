
using Ecommerce.DAL.Common;
using Ecommerce.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAL.Repository.Interface
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts(int count);
    }
}
