using System;

namespace test_project.Db.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }

        public Product(Guid id, string name, decimal price, string description, Guid categoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            CategoryId = categoryId;
        }

        public Product()
        {
        }
    }
}
