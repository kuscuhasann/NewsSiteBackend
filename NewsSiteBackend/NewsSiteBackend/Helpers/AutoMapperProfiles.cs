using AutoMapper;
using NewsSiteBackend.Dtos;
using NewsSiteBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSiteBackend.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<News, NewsForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                });

            CreateMap<News, NewsForDetailDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<PhotoForReturnDto, Photo>();
        }
    }
}
