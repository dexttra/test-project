using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.Db.Models;

namespace test_project.Db.Repositories
{
    public interface ICategoriesRepository 
    {
        Category TryGetById(Guid id);
        List<Category> GetAll();
        void Add(Category category);
    }
}
