using NewsSiteBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Data
{
    public interface ICategoryService
    {
       List<Category> GetCategories();

        bool SaveAll();

    }
}
