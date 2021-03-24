using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsSiteBackend.Data;
using NewsSiteBackend.Dtos;
using NewsSiteBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/News")]
    public class NewsController : ControllerBase
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public NewsController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        public ActionResult GetNews()
        {
            var news = _appRepository.GetNews();
            var newsToReturn = _mapper.Map<List<NewsForListDto>>(news);
            return Ok(newsToReturn);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] News news)
        {
            _appRepository.Add(news);
            _appRepository.SaveAll();
            return Ok(news);

        }

        [HttpGet]
        [Route("detail")]
        public ActionResult GetNewsById(int id)
        {
            var news = _appRepository.GetNewsById(id);
            var newsToReturn = _mapper.Map<NewsForDetailDto>(news);
            return Ok(newsToReturn);
        }

        [HttpGet]
        [Route("Photos")]
        public ActionResult GetPhotosByNews(int newsId)
        {
            var photos = _appRepository.GetPhotosByNews(newsId);
            return Ok(photos);
        }
        [HttpGet("getbycategory")]
        public ActionResult GetByCategory(int categoryId)
        {
            var result = _appRepository.GetAllByCategoryId(categoryId);
            if (result==null)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
