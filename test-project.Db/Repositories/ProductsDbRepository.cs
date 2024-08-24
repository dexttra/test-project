using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.Db.Models;

namespace test_project.Db.Repositories
{
    public class ProductsDbRepository : IProductsRepository
    {
        private readonly DatabaseContext databaseContext;

        public ProductsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public void AddProduct(Product product)
        {
            databaseContext.Products.Add(product);
            databaseContext.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return databaseContext.Products.ToList();
        }
    }
}
