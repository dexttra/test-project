using Microsoft.EntityFrameworkCore;
using test_project.Db.Models;

namespace test_project.Db
{
    public class DatabaseContext : DbContext
    {
        // доступ к таблицам
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated(); // создаем БД при первом обращении
        }
    }
}