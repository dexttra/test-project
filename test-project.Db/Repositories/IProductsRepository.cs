using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.Db.Models;

namespace test_project.Db.Repositories
{
    public interface IProductsRepository
    {
        Product TryGetById(Guid id);
        List<Product> GetAll();
        void Add(Product product);
    }
}
