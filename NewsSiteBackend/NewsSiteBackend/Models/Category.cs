﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Models
{
    public class Category
    {
        public Category()
        {
            News = new List<News>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<News> News { get; set; }
    }
}
