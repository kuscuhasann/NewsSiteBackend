using Microsoft.EntityFrameworkCore;
using NewsSiteBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Data
{
    public class AppRepository:IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public List<News> GetNews()
        {
            var news = _context.News.Include(c => c.Photos).ToList();
            return news;
        }

        public News GetNewsById(int newsId)
        {
            var news = _context.News.Include(c => c.Photos).FirstOrDefault(c => c.Id == newsId);
            return news;
        }

        public Photo GetPhoto(int id)
        {
            var photo = _context.Photos.FirstOrDefault(p => p.Id == id);
            return photo;
        }

        public List<Photo> GetPhotosByNews(int newsId)
        {
            var photos = _context.Photos.Where(p => p.CityId == newsId).ToList();
            return photos;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
