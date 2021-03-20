using NewsSiteBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Dtos
{
    public class NewsForDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Photo> Photos { get; set; }
    }
}
