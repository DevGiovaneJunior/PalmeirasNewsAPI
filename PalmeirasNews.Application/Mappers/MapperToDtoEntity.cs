using AutoMapper;
using PalmeirasNews.Domain.DTOs;
using PalmeirasNews.Domain.Entities;

namespace PalmeirasNews.Application.Mappers
{
    public class MapperToDtoEntity : Profile
    {
        public MapperToDtoEntity()
        {
            CreateMap<Noticia, NoticiaDTO>().ReverseMap();
        }
    }
}
