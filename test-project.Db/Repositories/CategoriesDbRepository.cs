using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.Db.Models;

namespace test_project.Db.Repositories
{
    public class CategoriesDbRepository : ICategoriesRepository
    {
        private readonly DatabaseContext databaseContext;

        public CategoriesDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public Category TryGetById(Guid id)
        {
            return databaseContext.Categories.SingleOrDefault(c => c.Id == id);
        }

        public void Add(Category category)
        {
            databaseContext.Categories.Add(category);
            databaseContext.SaveChanges();
        }
        public List<Category> GetAll()
        {
            return databaseContext.Categories.ToList();
        }
    }
}
