﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_project.Db.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Category(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category() 
        {
        }
    }
}
