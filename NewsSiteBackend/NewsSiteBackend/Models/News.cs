using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Models
{
    public class News
    {
        public News()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public List<Photo> Photos { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
