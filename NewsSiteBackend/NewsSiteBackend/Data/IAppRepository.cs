using NewsSiteBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

        List<News> GetNews();
        List<Photo> GetPhotosByNews(int newsId);
        News GetNewsById(int newsId);
        Photo GetPhoto(int id);
        List<News> GetAllByCategoryId(int id);
    }
}
