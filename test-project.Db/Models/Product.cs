using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_project.Db.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }

        public Product(Guid id, string name, decimal price, string description, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
        public Product()
        {
        }
    }
}
