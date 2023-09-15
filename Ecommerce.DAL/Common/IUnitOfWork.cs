using Ecommerce.DAL.Repository.Interface;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ecommerce.DAL.Common
{
    public interface IUnitOfWork : IDisposable
    {
        //IDeveloperRepository Developers { get; }
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; } 
        Task<int> CompleteAsync();
    }
}
 