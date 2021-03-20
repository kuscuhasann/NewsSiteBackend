using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Url { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }

        public News News { get; set; }
    }
}
