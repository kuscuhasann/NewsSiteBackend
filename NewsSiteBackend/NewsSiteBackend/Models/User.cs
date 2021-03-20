using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Models
{
    public class User
    {
        public User()
        {
            News = new List<News>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<News> News { get; set; }
    }
}
